using SMEV3v13.Types.Basic;
using System;
using System.Xml.Serialization;
using System.Xml;

namespace SMEV3v13.Types
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3")]
    public class Response
    {
        [XmlElement(Order = 0)]
        public string OriginalMessageId { get; set; }

        [XmlElement(Order = 1)]
        public string OriginalTransactionCode { get; set; }

        [XmlElement(Order = 2)]
        public string ReferenceMessageID { get; set; }

        [XmlElement(Order = 3)]
        public SenderProvidedResponseData SenderProvidedResponseData { get; set; }

        [XmlElement(Order = 4)]
        public MessageMetadata MessageMetadata { get; set; }

        [XmlArray(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3", Order = 5)]
        [XmlArrayItem("FSAttachment", IsNullable = false)]
        public FSAuthInfo[] FSAttachmentsList { get; set; }

        [XmlElement(Order = 6)]
        public XmlElement SenderInformationSystemSignature { get; set; }

        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }
    }
}
