using System;
using System.Linq;
using DevExpress.Xpo;

namespace Crucible.XPO
{
    public sealed class ReviewXPO : XPObject
    {
        private UserXPO author;
        private DateTime createTime;
        private string id;
        private string name;
        private state state;

        public ReviewXPO( Session session ) : base( session )
        {
        }

        public UserXPO Author
        {
            get { return author; }
            set { SetPropertyValue( "Author", ref author, value ); }
        }

        public state State
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
    }
}