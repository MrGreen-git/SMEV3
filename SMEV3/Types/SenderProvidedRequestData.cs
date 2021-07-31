using System;
using System.Xml.Serialization;
using System.Xml;
using SMEV3v13.Types.Basic;

namespace SMEV3v13.Types
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3")]
    public class SenderProvidedRequestData
    {
        [XmlElement(Order = 0)]
        public string MessageID { get; set; }

        [XmlElement(Order = 1)]
        public string ReferenceMessageID { get; set; }

        [XmlElement(Order = 2)]
        public string TransactionCode { get; set; }

        [XmlElement(Order = 3)]
        public string NodeID { get; set; }

        [XmlElement(Order = 4)]
        public DateTime EOL { get; set; }

        [XmlIgnore()]
        public bool EOLSpecified { get; set; }

        [XmlElement(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3", Order = 5)]
        public XmlElement MessagePrimaryContent { get; set; }

        [XmlElement(Order = 6)]
        public XmlElement PersonalSignature { get; set; }

        [XmlElement("AttachmentHeaderList", typeof(AttachmentHeaderList), Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3", Order = 7)]
        public AttachmentHeaderType[] AttachmentHeaderList { get; set; }

        [XmlElement("RefAttachmentHeaderList", typeof(RefAttachmentHeaderList), Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3", Order = 8)]
        public RefAttachmentHeaderType[] RefAttachmentHeaderList { get; set; }

        [XmlElement(Order = 9)]
        public SenderProvidedRequestDataBusinessProcessMetadata BusinessProcessMetadata { get; set; }

        [XmlElement(Order = 10)]
        public Void TestMessage { get; set; }

        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }
    }
}
