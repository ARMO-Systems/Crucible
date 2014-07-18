using DevExpress.Xpo;

namespace Crucible.XPO
{
    public sealed class ReviewerXPO : XPObject
    {
        private bool completed;
        private ReviewXPO review;
        private UserXPO user;

        public ReviewerXPO( Session session ) : base( session )
        {
        }

        [Association( "Review-Reviewer" )]
        public ReviewXPO Review
        {
            get { return review; }
            set { SetPropertyValue( "Review", ref review, value ); }
        }

        public UserXPO User
        {
            get { return user; }
            set { SetPropertyValue( "User", ref user, value ); }
        }

        public bool Completed
        {
            get { return completed; }
            set { SetPropertyValue( "Completed", ref completed, value ); }
        }
    }
}