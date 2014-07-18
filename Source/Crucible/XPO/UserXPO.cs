using DevExpress.Xpo;

namespace Crucible.XPO
{
    public sealed class UserXPO : XPObject
    {
        private string avatarUrl;
        private string displayName;
        private string userName;

        public UserXPO( Session session ) : base( session )
        {
        }

        [DbType( "NTEXT" )]
        public string DisplayName
        {
            get { return displayName; }
            set { SetPropertyValue( "Comment", ref displayName, value ); }
        }

        public string UserName
        {
            get { return userName; }
            set { SetPropertyValue( "UserName", ref userName, value ); }
        }

        public string AvatarUrl
        {
            get { return avatarUrl; }
            set { SetPropertyValue( "AvatarUrl", ref avatarUrl, value ); }
        }
    }
}