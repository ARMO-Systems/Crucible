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
            ClosedSnippet,
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

        public DateTime LastChangeTime
        {
            get { return Changes.MaxBy( item => item.ChangeTime ).First().ChangeTime; }
        }

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
        public XPCollection< ReviewChangeItemXPO > Changes
        {
            get { return GetCollection< ReviewChangeItemXPO >( "Changes" ); }
        }

        [Association( "Review-Reviewer" )]
        public XPCollection< ReviewerXPO > Reviewers
        {
            get { return GetCollection< ReviewerXPO >( "Reviewers" ); }
        }

        public void SetState( string stat )
        {
            switch ( stat )
            {
                case "Draft":
                    state = EState.Draft;
                    break;
                case "Approval":
                    state = EState.Approval;
                    break;
                case "Review":
                    state = EState.Review;
                    break;
                case "Summarize":
                    state = EState.Summarize;
                    break;
                case "Closed":
                    state = EState.Closed;
                    break;
                case "Dead":
                    state = EState.Dead;
                    break;
                case "Rejected":
                    state = EState.Rejected;
                    break;
                case "Unknown":
                    state = EState.Unknown;
                    break;
                case "OpenSnippet":
                    state = EState.OpenSnippet;
                    break;
                case "ClosedSnippet":
                    state = EState.ClosedSnippet;
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}