using System;
using System.Xml.Serialization;
using System.Xml;
using SMEV3v12.Types.Basic;

namespace SMEV3v12.Types
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2")]
    public class SenderProvidedResponseData
    {
        [XmlElement(Order = 0)]
        public string MessageID { get; set; }

        [XmlElement(Order = 1)]
        public string To { get; set; }

        [XmlElement("AsyncProcessingStatus", typeof(AsyncProcessingStatus), Order = 2)]
        [XmlElement("PersonalSignature", typeof(XmlElement), Order = 2)]
        [XmlElement("RequestRejected", typeof(SenderProvidedResponseDataRequestRejected), Order = 2)]
        [XmlElement("RequestStatus", typeof(SenderProvidedResponseDataRequestStatus), Order = 2)]
        [XmlElement("AttachmentHeaderType", typeof(AttachmentHeaderType), Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2", Order = 2)]
        [XmlElement("MessagePrimaryContent", typeof(XmlElement), Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2", Order = 2)]
        [XmlElement("RefAttachmentHeaderType", typeof(RefAttachmentHeaderType), Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2", Order = 2)]
        [XmlChoiceIdentifier("ItemsElementName")]
        public object[] Items { get; set; }

        [XmlElement("ItemsElementName", Order = 3)]
        [XmlIgnore]
        public ItemsChoiceType[] ItemsElementName { get; set; }

        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }
    }
}
