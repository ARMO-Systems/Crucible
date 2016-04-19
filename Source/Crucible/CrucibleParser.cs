using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crucible.XPO;
using DevExpress.Xpo;
using RestSharp;
using RestSharp.Authenticators;

namespace Crucible
{
    internal sealed class CrucibleParser
    {
        private readonly bool allReviews;
        private readonly RestClient client;
        private readonly UnitOfWork uow;
        private Dictionary< string, ReviewXPO > myReviews;
        private Dictionary< string, ReviewChangeItemXPO > reviewChanges;
        private Dictionary< string, UserXPO > usersXPO;

        private CrucibleParser( string server, string username, string password, bool allReviews )
        {
            this.allReviews = allReviews;
            uow = new UnitOfWork { LockingOption = LockingOption.None };
            client = new RestClient( "http://" + server + "/rest-service/" ) { Authenticator = new HttpBasicAuthenticator( username, password ) };
            UpdateReviews();
        }

        private void UpdateReviews()
        {
            UpdateUsers();
            myReviews = new XPCollection< ReviewXPO >( uow ).ToDictionary( item => item.ID );
            var reviews = allReviews ? GetReview( DateTime.Now.AddDays( -500 ) ) : GetOpenReview();
            reviews.Select( item => new { review = item, reviewXPO = GetReview( item.permaId.id ) } ).ForEach( item => UpdateReview( item.review, item.reviewXPO ) );

            uow.CommitChanges();
        }

        private IEnumerable< Review > GetOpenReview()
        {
            return client.Execute< List< Review > >( new RestRequest( "/reviews-v1/filter/allOpenReviews", Method.GET ) { RootElement = "reviewData", Timeout = 5 * 60 * 1000 } ).Data;
        }

        private static long GetGmtinMs( DateTime date )
        {
            return ( long ) ( date.ToUniversalTime() - new DateTime( 1970, 1, 1, 0, 0, 0, DateTimeKind.Utc ) ).TotalMilliseconds;
        }

        private static DateTime GetDate( long time )
        {
            return new DateTime( 1970, 1, 1 ).AddMilliseconds( time ).ToLocalTime();
        }

        private void UpdateReviewChanges( ReviewXPO reviewXpo )
        {
            reviewChanges = reviewXpo.Changes.ToDictionary( item => GetComplexId( item.ID, item.ChangeType ) );
            var created = GetChange( reviewXpo, "Ñçä", ReviewChangeItemXPO.EType.eComment );
            created.User = reviewXpo.Author;
            created.ChangeTime = reviewXpo.CreateTime;

            UpdateComments( reviewXpo );
            UpdateGeneralComments( reviewXpo );
            UpdateLastReviewItems( reviewXpo );
        }

        private void UpdateGeneralComments( ReviewXPO reviewXpo )
        {
            var comments = client.Execute< List< CommentGeneral > >( new RestRequest( string.Format( "reviews-v1/{0}/comments/general", reviewXpo.ID ), Method.GET ) { RootElement = "comments" } ).Data;
            foreach ( var comment in comments.Expand( item => item.replies ) )
            {
                var change = GetChange( reviewXpo, comment.permId.id, ReviewChangeItemXPO.EType.eGeneralComment );
                change.ChangeTime = comment.createDate;
                change.Comment = comment.message;
                change.User = GetUser( comment.user.userName );
            }
        }

        private void UpdateComments( ReviewXPO reviewXpo )
        {
            var comments = client.Execute< List< Comment > >( new RestRequest( string.Format( "reviews-v1/{0}/comments/versioned", reviewXpo.ID ), Method.GET ) { RootElement = "comments" } ).Data;

            foreach ( var comment in comments )
            {
                var change = GetChange( reviewXpo, comment.permaId, ReviewChangeItemXPO.EType.eComment );
                change.ChangeTime = GetDate( comment.createDate );
                change.Comment = comment.message;
                change.User = GetUser( comment.user.userName );
                foreach ( var reply in comment.replies.Expand( item => item.replies ) )
                {
                    var ch = GetChange( reviewXpo, reply.permId.id, ReviewChangeItemXPO.EType.eReply );
                    ch.ChangeTime = reply.createDate;
                    ch.Comment = reply.message;
                    ch.User = GetUser( reply.user.userName );
                }
            }
        }

        static string GetComplexId( string id, ReviewChangeItemXPO.EType type )
        {
            return id + type;
        }

        ReviewChangeItemXPO GetChange( ReviewXPO reviewXpo, string id, ReviewChangeItemXPO.EType type )
        {
            var complexId = GetComplexId( id, type );
            if ( reviewChanges.ContainsKey( complexId ) )
                return reviewChanges[ complexId ];

            reviewChanges[ complexId ] = new ReviewChangeItemXPO( uow ) { ID = id, ChangeType = type };
            reviewXpo.Changes.Add( reviewChanges[ complexId ] );

            return reviewChanges[ complexId ];
        }

        private void UpdateUsers()
        {
            usersXPO = new XPCollection< UserXPO >( uow ).ToDictionary( user => user.UserName );
            foreach ( var user in client.Execute< List< User > >( new RestRequest( "users-v1", Method.GET ) { RootElement = "userData" } ).Data )
            {
                var xpo = GetUser( user.userName );
                xpo.DisplayName = user.displayName;
            }
            uow.CommitChanges();
        }

        IEnumerable< Review > GetReview( DateTime from )
        {
            return client.Execute< List< Review > >( new RestRequest( string.Format( "reviews-v1/filter?fromDate={0}", GetGmtinMs( @from ) ), Method.GET ) { RootElement = "reviewData", Timeout = 10 * 60 * 1000 } ).Data;
        }

        private ReviewXPO GetReview( string id )
        {
            if ( !myReviews.ContainsKey( id ) )
                myReviews[ id ] = new ReviewXPO( uow ) { ID = id };

            return myReviews[ id ];
        }

        public static async Task GetDataFromCrucibleAsync( string server, string username, string password, bool allReview )
        {
            await Task.Factory.StartNew( () => new CrucibleParser( server, username, password, allReview ).UpdateReviews() );
        }

        private void UpdateReview( Review review, ReviewXPO reviewXPO )
        {
            reviewXPO.Author = GetUser( review.author.userName );
            reviewXPO.CreateTime = review.createDate;
            reviewXPO.SetState( review.state );
            reviewXPO.Name = review.name;

            UpdateReviewers( reviewXPO );
            UpdateReviewChanges( reviewXPO );
        }

        private void UpdateReviewers( ReviewXPO reviewXpo )
        {
            var revs = GetReviewers( reviewXpo.ID ).ToList();

            ( from rev in revs join reviewerXpo in reviewXpo.Reviewers on rev.userName equals reviewerXpo.User.UserName into groupRevs where !groupRevs.Any() select rev ).ToList().
                ForEach( rev => reviewXpo.Reviewers.Add( new ReviewerXPO( uow ) { User = GetUser( rev.userName ) } ) );

            ( from rev in revs join reviewerXpo in reviewXpo.Reviewers on rev.userName equals reviewerXpo.User.UserName select new { rev, reviewerXPO = reviewerXpo } ).ToList().
                ForEach( item => item.reviewerXPO.Completed = item.rev.completed );
        }

        private IEnumerable< Reviewer > GetReviewers( string id )
        {
            return client.Execute< List< Reviewer > >( new RestRequest( string.Format( "reviews-v1/{0}/reviewers", id ), Method.GET ) { RootElement = "reviewer" } ).Data;
        }

        private UserXPO GetUser( string userName )
        {
            if ( userName == null )
                userName = "DummyUser";

            if ( !usersXPO.ContainsKey( userName ) )
                usersXPO[ userName ] = new UserXPO( uow ) { UserName = userName };

            return usersXPO[ userName ];
        }

        private void UpdateLastReviewItems( ReviewXPO reviewXpo )
        {
            var reviewItems = client.Execute< List< ReviewItem > >( new RestRequest( string.Format( "reviews-v1/{0}/reviewitems", reviewXpo.ID ), Method.GET ) { RootElement = "reviewItem" } ).Data;
            foreach ( var reviewItem in reviewItems )
            {
                var change = GetChange( reviewXpo, reviewItem.permId.id, ReviewChangeItemXPO.EType.eFile );
                change.ChangeTime = GetDate( reviewItem.commitDate );
                change.Comment = reviewItem.fromPath;
            }
        }

        // ReSharper disable ClassNeverInstantiated.Local
        // ReSharper disable UnusedAutoPropertyAccessor.Local
        private class ReviewItem
        {
            public string fromPath { get; set; }
            public long commitDate { get; set; }
            public ID permId { get; set; }
        }

        private class Comment
        {
            public string message { get; set; }
            public User user { get; set; }
            public long createDate { get; set; }
            public string permaId { get; set; }
            public List< CommentGeneral > replies { get; set; }
        }

        private class CommentGeneral
        {
            public string message { get; set; }
            public User user { get; set; }
            public DateTime createDate { get; set; }
            public ID permId { get; set; }
            public List< CommentGeneral > replies { get; set; }
        }

        private class Reviewer
        {
            public string userName { get; set; }
            public bool completed { get; set; }
        }

        private class Review
        {
            public string name { get; set; }
            public ID permaId { get; set; }
            public User author { get; set; }
            public string state { get; set; }
            public DateTime createDate { get; set; }
        }

        private class ID
        {
            public string id { get; set; }
        }

        private class User
        {
            public string userName { get; set; }
            public string displayName { get; set; }
        }

        // ReSharper restore UnusedAutoPropertyAccessor.Local
        // ReSharper restore ClassNeverInstantiated.Local
    }
}