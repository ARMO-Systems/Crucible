using System;
using System.Linq;
using DevExpress.Xpo;

namespace Crucible.XPO
{
    public sealed class ReviewXPO : XPObject
    {
        public enum EState
        {
            Draft,
            Approval,
            Review,
            Summarize,
            Closed,
            Dead,
            Rejected,
            Unknown,
            OpenSnippet,
            ClosedSnippet
        }

        private UserXPO author;
        private DateTime createTime;
        private string id;
        private string name;
        private EState state;

        public ReviewXPO( Session session ) : base( session )
        {
        }

        public UserXPO Author
        {
            get { return author; }
            set { SetPropertyValue( "Author", ref author, value ); }
        }

        public EState State
        {
            get { return state; }
            set { SetPropertyValue( "State", ref state, value ); }
        }

        public DateTime LastChangeTime => Changes.MaxBy( item => item.ChangeTime ).First().ChangeTime;

        public DateTime CreateTime
        {
            get { return createTime; }
            set { SetPropertyValue( "CreateTime", ref createTime, value ); }
        }

        public string ID
        {
            get { return id; }
            set { SetPropertyValue( "ID", ref id, value ); }
        }

        [DbType( "NTEXT" )]
        public string Name
        {
            get { return name; }
            set { SetPropertyValue( "Name", ref name, value ); }
        }

        [Association( "Review-ReviewChange" )]
        public XPCollection< ReviewChangeItemXPO > Changes => GetCollection< ReviewChangeItemXPO >( "Changes" );

        [Association( "Review-Reviewer" )]
        public XPCollection< ReviewerXPO > Reviewers => GetCollection< ReviewerXPO >( "Reviewers" );

        public void SetState( string stat )
        {
            switch ( stat )
            {
                case "Draft":
                    State = EState.Draft;
                    break;
                case "Approval":
                    State = EState.Approval;
                    break;
                case "Review":
                    State = EState.Review;
                    break;
                case "Summarize":
                    State = EState.Summarize;
                    break;
                case "Closed":
                    State = EState.Closed;
                    break;
                case "Dead":
                    State = EState.Dead;
                    break;
                case "Rejected":
                    State = EState.Rejected;
                    break;
                case "Unknown":
                    State = EState.Unknown;
                    break;
                case "OpenSnippet":
                    State = EState.OpenSnippet;
                    break;
                case "ClosedSnippet":
                    State = EState.ClosedSnippet;
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}