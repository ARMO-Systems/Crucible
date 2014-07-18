using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Crucible.Crucible;
using Crucible.XPO;
using DevExpress.Xpo;

namespace Crucible
{
    internal sealed class CrucibleParser
    {
        private readonly bool allReview;
        private readonly string password;
        private readonly string server;
        private readonly UnitOfWork uow;
        private readonly string username;
        private Dictionary< string, ReviewXPO > myReviews;
        private Dictionary< string, UserXPO > usersXPO;

        private CrucibleParser( string server, string username, string password, bool allReview )
        {
            this.server = server;
            this.username = username;
            this.password = password;
            this.allReview = allReview;

            uow = new UnitOfWork { LockingOption = LockingOption.None };
        }

        private T GetData< T >( string urlAddition )
        {
            try
            {
                return ( T ) new XmlSerializer( typeof ( T ) ).Deserialize( GetHttpStream( urlAddition ) );
            }
            catch ( WebException )
            {
                throw;
            }
            catch ( Exception )
            {
                return default( T );
            }
        }

        private Stream GetHttpStream( string urlAddition )
        {
            var request = ( HttpWebRequest ) WebRequest.Create( string.Format( "http://{0}/rest-service/{1}", server, urlAddition ) );
            Trace.WriteLine( string.Format( "http://{0}/rest-service/{1}", server, urlAddition ) );
            request.Headers.Add( "AUTHORIZATION", string.Format( "Basic {0}", Convert.ToBase64String( Encoding.UTF8.GetBytes( string.Format( "{0}:{1}", username, password ) ) ) ) );
            return ( request.GetResponse() ).GetResponseStream();
        }

        public static async Task GetDataFromCrucibleAsync( string server, string username, string password, bool allReview )
        {
            await Task.Factory.StartNew( () => new CrucibleParser( server, username, password, allReview ).UpdateReviews() );
        }

        private void UpdateReviews()
        {
            UpdateUsers();
            myReviews = new XPCollection< ReviewXPO >( uow ).ToDictionary( item => item.ID );

            IEnumerable< reviewData > reviews;
            if ( allReview )
            {
                reviews = GetAllReview().ToList();
                myReviews.Keys.Select( item => item ).Except( reviews.Select( item => item.permaId.id ) ).ToList().ForEach( item =>
                                                                                                                            {
                                                                                                                                myReviews[ item ].Delete();
                                                                                                                                myReviews.Remove( item );
                                                                                                                            } );
            }
            else
                reviews = GetReviewByIDs().ToList();

            reviews.Select( item => new { review = item, reviewXPO = GetReview( item.permaId.id ) } ).ForEach( item => UpdateReview( item.review, item.reviewXPO ) );
            uow.CommitChanges();
        }

        private void UpdateReview( reviewData review, ReviewXPO reviewXPO )
        {
            reviewXPO.Author = GetUser( review.author.userName );
            reviewXPO.CreateTime = review.createDate.ToDT();
            reviewXPO.State = review.state;
            reviewXPO.Name = review.name;

            UpdateReviewers( reviewXPO );
            UpdateReviewChanges( reviewXPO );
        }

        private ReviewXPO GetReview( string id )
        {
            if ( !myReviews.ContainsKey( id ) )
                myReviews[ id ] = new ReviewXPO( uow ) { ID = id };

            return myReviews[ id ];
        }

        private void UpdateUsers()
        {
            usersXPO = new XPCollection< UserXPO >( uow ).ToDictionary( user => user.UserName );
            var users = GetData< users >( "users-v1" ).userData.Select( user => new { AvatarUrl = user.avatarUrl, DisplayName = user.displayName, UserName = user.userName } );
            ( from user in users select new { user, userXPO = GetUser( user.UserName ) } ).ForEach( userFull =>
                                                                                                    {
                                                                                                        userFull.userXPO.AvatarUrl = userFull.user.AvatarUrl;
                                                                                                        userFull.userXPO.DisplayName = userFull.user.DisplayName;
                                                                                                    } );
        }

        private IEnumerable< reviewData > GetReviewByIDs()
        {
            return
                myReviews.Where( item => item.Value.LastChangeTime >= DateTime.Now.AddDays( -7 ) ).
                    Select( item => item.Key ).
                    Union( GetReviewsByState( state.Review ).Select( item => item.permaId.id ) ).
                    Select( id => GetData< reviewData >( string.Format( "reviews-v1/{0}", id ) ) );
        }

        private IEnumerable< reviewData > GetAllReview()
        {
            return Enum.GetValues( typeof ( state ) ).Cast< state >().SelectMany( GetReviewsByState );
        }

        private IEnumerable< reviewData > GetReviewsByState( state st )
        {
            return GetData< reviews >( string.Format( "reviews-v1?state={0}", st ) ).reviewData ?? new reviewData[ 0 ];
        }

        private void UpdateReviewers( ReviewXPO reviewXPO )
        {
            var revs = GetData< reviewers >( string.Format( "reviews-v1/{0}/reviewers", reviewXPO.ID ) ).reviewer;
            if ( revs == null )
                return;

            ( from rev in revs join reviewerXPO in reviewXPO.Reviewers on rev.userName equals reviewerXPO.User.UserName into groupRevs where !groupRevs.Any() select rev ).ToList().
                ForEach( rev => reviewXPO.Reviewers.Add( new ReviewerXPO( uow ) { User = GetUser( rev.userName ) } ) );

            ( from rev in revs join reviewerXPO in reviewXPO.Reviewers on rev.userName equals reviewerXPO.User.UserName select new { rev, reviewerXPO } ).ToList().ForEach( item => item.reviewerXPO.Completed = item.rev.completed );
        }

        private UserXPO GetUser( string userName )
        {
            if ( !usersXPO.ContainsKey( userName ) )
                usersXPO[ userName ] = new UserXPO( uow ) { UserName = userName };

            return usersXPO[ userName ];
        }

        private static string Decorate( string xml, string tag )
        {
            return String.Format( "{0}<{1}>{2}</{1}>", "<?xml version=\"1.0\" encoding=\"utf-8\"?>", tag, xml );
        }

        private static T GetData< T >( XmlNode xmlElement )
        {
            return ( T ) new XmlSerializer( typeof ( T ) ).Deserialize( new StringReader( Decorate( xmlElement.InnerXml, typeof ( T ).Name ) ) );
        }

        private void UpdateReviewChanges( ReviewXPO reviewXPO )
        {
            if ( reviewXPO.Changes.All( rev => rev.ID != "Ñçä" ) )
                reviewXPO.Changes.Add( new ReviewChangeItemXPO( uow ) { ChangeTime = reviewXPO.CreateTime, ID = "Ñçä", User = reviewXPO.Author } );

            UpdateComments< versionedLineCommentData >( reviewXPO.ID, "versioned", reviewXPO.Changes );
            UpdateComments< generalCommentData >( reviewXPO.ID, "general", reviewXPO.Changes );

            UpdateLastReviewItems( reviewXPO.ID, reviewXPO.Changes );
        }

        private void UpdateLastReviewItems( string reviewID, ICollection< ReviewChangeItemXPO > changes )
        {
            var reviewItems = GetData< reviewItems >( string.Format( "reviews-v1/{0}/reviewitems", reviewID ) ).reviewItem;
            if ( reviewItems == null )
                return;

            ( from reviewItem in reviewItems join change in changes on reviewItem.permId.id equals change.ID into groupChanges where !groupChanges.Any() select reviewItem.permId.id ).ToList().
                ForEach( id => changes.Add( new ReviewChangeItemXPO( uow ) { ID = id } ) );

            ( from reviewItem in reviewItems join change in changes on reviewItem.permId.id equals change.ID select new { reviewItem, change } ).ToList().ForEach( item =>
                                                                                                                                                                   {
                                                                                                                                                                       item.change.ChangeTime =
                                                                                                                                                                           item.reviewItem.expandedRevisions.MaxBy( exp => exp.addDate ).
                                                                                                                                                                               First().
                                                                                                                                                                               addDate;
                                                                                                                                                                       item.change.User = GetUser( item.reviewItem.authorName );
                                                                                                                                                                       item.change.Comment = item.reviewItem.fromPath;
                                                                                                                                                                   } );
        }

        private void UpdateComments< T >( string reviewID, string addition, ICollection< ReviewChangeItemXPO > changes )
        {
            var crComments = GetData< comments >( string.Format( "reviews-v1/{0}/comments/{1}", reviewID, addition ) );
            if ( crComments == null || crComments.Any == null )
                return;

            var versionedLineCommentDatas = ( from xmlComment in crComments.Any select GetData< T >( xmlComment ) ).ToList();

            ( from versComment in
                versionedLineCommentDatas.Select( item => ( dynamic ) item ).
                    Select( item => new Tuple< DateTime, UserXPO, string, string >( DateTime.Parse( item.createDate ), GetUser( item.user.userName ), item.message, CreateCommentLink( item.permaId ) ) ).
                    Union( versionedLineCommentDatas.Cast< commentDataImpl >().SelectMany( GetReplies ) )
                join changeXPO in changes on versComment.Item4 equals changeXPO.ID into groupChange
                where !groupChange.Any()
                select versComment ).ToList().
                ForEach( versComment => changes.Add( new ReviewChangeItemXPO( uow ) { ChangeTime = versComment.Item1, User = versComment.Item2, Comment = versComment.Item3, ID = versComment.Item4 } ) );
        }

        private List< Tuple< DateTime, UserXPO, string, string > > GetReplies( commentDataImpl comment )
        {
            var accum = new List< Tuple< DateTime, UserXPO, string, string > >();

            return AddReplies( accum, comment.replies );
        }

        private List< Tuple< DateTime, UserXPO, string, string > > AddReplies( List< Tuple< DateTime, UserXPO, string, string > > accum, commentDataImplReplies replies )
        {
            if ( replies.Any == null )
                return accum;

            var repsIml = replies.Any.Select( GetData< generalCommentData > ).ToList();
            accum.AddRange( repsIml.Select( item => new Tuple< DateTime, UserXPO, string, string >( item.createDate.ToDT(), GetUser( item.user.userName ), item.message, CreateCommentLink( item.permId ) ) ) );
            repsIml.ForEach( item => AddReplies( accum, item.replies ) );
            return accum;
        }

        private static string CreateCommentLink( permId id )
        {
            return string.Format( "c{0}", id.id.Substring( 4 ) );
        }
    }
}