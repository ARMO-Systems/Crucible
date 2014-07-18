using System;
using DevExpress.Xpo;

namespace Crucible.XPO
{
    public sealed class ReviewChangeItemXPO : XPObject
    {
        private DateTime changeTime;
        private string comment;
        private string id;
        private ReviewXPO review;
        private UserXPO user;

        public ReviewChangeItemXPO( Session session ) : base( session )
        {
        }

        [Association( "Review-ReviewChange" )]
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

        [DbType( "NTEXT" )]
        public string Comment
        {
            get { return comment; }
            set { SetPropertyValue( "Comment", ref comment, value ); }
        }

        public DateTime ChangeTime
        {
            get { return changeTime; }
            set { SetPropertyValue( "ChangeTime", ref changeTime, value ); }
        }

        public string ID
        {
            get { return id; }
            set { SetPropertyValue( "ID", ref id, value ); }
        }
    }
}