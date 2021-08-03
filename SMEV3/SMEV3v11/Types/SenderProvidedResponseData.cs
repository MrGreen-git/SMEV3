using System;
using System.Xml.Serialization;
using System.Xml;
using SMEV3v11.Types.Basic;

namespace SMEV3v11.Types
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1")]
    public class SenderProvidedResponseData
    {
        /// <summary>
        /// Идентификатор, присвоенный сообщению отправителем.
        /// Генерируется в соответствии с RFC-4122, по варианту 1 (на основании MAC-адреса и текущего времени).
        /// </summary>
        [XmlElement(Order = 0)]
        public string MessageID { get; set; }

        /// <summary>
        /// Адрес доставки ответа. Копируется из запроса, //GetRequestResponse/ReplyTo/text()
        /// </summary>
        [XmlElement(Order = 1)]
        public string To { get; set; }

        [XmlElement("AsyncProcessingStatus", typeof(AsyncProcessingStatus), Order = 2)]
        [XmlElement("PersonalSignature", typeof(XmlElement), Order = 2)]
        [XmlElement("RequestRejected", typeof(RequestRejected), Order = 2)]
        [XmlElement("RequestStatus", typeof(RequestStatus), Order = 2)]
        [XmlElement("AttachmentHeaderList", typeof(AttachmentHeaderList), Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.1", Order = 2)]
        [XmlElement("MessagePrimaryContent", typeof(XmlElement), Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.1", Order = 2)]
        [XmlElement("RefAttachmentHeaderList", typeof(RefAttachmentHeaderList), Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.1", Order = 2)]
        [XmlChoiceIdentifier("ItemsElementName")]
        public object[] Items { get; set; }

        [XmlElement("ItemsElementName", Order = 3)]
        [XmlIgnore]
        public ItemsChoiceType[] ItemsElementName { get; set; }

        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }
    }
}
