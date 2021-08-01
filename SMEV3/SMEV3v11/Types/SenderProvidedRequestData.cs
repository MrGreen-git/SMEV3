using System;
using System.Xml.Serialization;
using System.Xml;
using SMEV3v11.Types.Basic;

namespace SMEV3v11.Types
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1")]
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

        [XmlIgnore]
        public bool EOLSpecified { get; set; }

        [XmlElement(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.1", Order = 5)]
        public XmlElement MessagePrimaryContent { get; set; }

        [XmlElement(Order = 6)]
        public XmlElement PersonalSignature { get; set; }

        [XmlElement("AttachmentHeaderList", typeof(AttachmentHeaderList), Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.1", Order = 7)]
        public AttachmentHeaderType[] AttachmentHeaderList { get; set; }

        [XmlElement("RefAttachmentHeaderList", typeof(RefAttachmentHeaderList), Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.1", Order = 8)]
        public RefAttachmentHeaderType[] RefAttachmentHeaderList { get; set; }

        [XmlElement(Order = 9)]
        public SenderProvidedRequestDataBusinessProcessMetadata BusinessProcessMetadata { get; set; }

        [XmlElement(Order = 10)]
        public Basic.Void TestMessage { get; set; }

        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }
    }
}
