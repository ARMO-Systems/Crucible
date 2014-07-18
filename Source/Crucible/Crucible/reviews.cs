using System;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Crucible.Crucible
{
    [Serializable]
    [DebuggerStepThrough]
    [XmlRoot( Namespace = "", IsNullable = true )]
    public sealed class reviews
    {
        private reviewData[] reviewDataField;

        /// <remarks/>
        [XmlElement( "reviewData", Form = XmlSchemaForm.Unqualified, IsNullable = true )]
        public reviewData[] reviewData
        {
            get { return reviewDataField; }
            set { reviewDataField = value; }
        }
    }

    [Serializable]
    [DebuggerStepThrough]
    [XmlRoot( Namespace = "", IsNullable = true )]
    public sealed class detailedReviews
    {
        private detailedReviewData[] detaildReviewDataField;

        /// <remarks/>
        [XmlElement( "detailedReviewData", Form = XmlSchemaForm.Unqualified, IsNullable = true )]
        public detailedReviewData[] detaildReviewData
        {
            get { return detaildReviewDataField; }
            set { detaildReviewDataField = value; }
        }
    }

    [Serializable]
    [DebuggerStepThrough]
    [XmlRoot( Namespace = "", IsNullable = true )]
    public sealed class users
    {
        private userData[] userDataField;

        /// <remarks/>
        [XmlElement( "userData", Form = XmlSchemaForm.Unqualified, IsNullable = true )]
        public userData[] userData
        {
            get { return userDataField; }
            set { userDataField = value; }
        }
    }
}