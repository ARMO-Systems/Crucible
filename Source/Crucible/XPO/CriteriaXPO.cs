using DevExpress.Xpo;

namespace Crucible.XPO
{
    public sealed class CriteriaXPO : XPObject
    {
        private string criteria;
        private string name;

        public CriteriaXPO( Session session ) : base( session )
        {
        }

        [DbType( "NTEXT" )]
        public string Criteria
        {
            get { return criteria; }
            set { SetPropertyValue( "Criteria", ref criteria, value ); }
        }

        [DbType( "NTEXT" )]
        public string Name
        {
            get { return name; }
            set { SetPropertyValue( "Name", ref name, value ); }
        }
    }
}