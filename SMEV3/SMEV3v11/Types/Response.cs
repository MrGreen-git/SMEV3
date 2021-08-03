using System;
using System.Xml.Serialization;
using System.Xml;
using SMEV3v11.Types.Basic;
using System.ServiceModel.Channels;

namespace SMEV3v11.Types
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1")]
    public class Response
    {
        [XmlElement(Order = 0)]
        public string OriginalMessageId { get; set; }

        [XmlElement(Order = 1)]
        public string OriginalTransactionCode { get; set; }

        /// <summary>
        /// Идентификатор сообщения, порождающего цепочку сообщений.
        /// При отправке подчиненных сообщений значение соответствует MessageID корневого сообщения цепочки сообщений.
        /// Для корневого сообщения значение совпадает с MessageID
        /// </summary>
        [XmlElement(Order = 2)]
        public string ReferenceMessageID { get; set; }

        [XmlElement(Order = 3)]
        public SenderProvidedResponseData SenderProvidedResponseData { get; set; }

        [XmlElement(Order = 4)]
        public MessageMetadata MessageMetadata { get; set; }

        [XmlArray(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.1", Order = 5)]
        [XmlArrayItem("FSAttachment", IsNullable = false)]
        public FSAuthInfo[] FSAttachmentsList { get; set; }

        /// <summary>
        /// ЭП-ОВ или ЭП-ПГУ отправителя. Подписан элемент //SenderProvidedResponseData
        /// </summary>
        [XmlElement(Order = 6)]
        public XmlElement SenderInformationSystemSignature { get; set; }

        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }
    }
}
