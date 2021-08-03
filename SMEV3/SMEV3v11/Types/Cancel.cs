using System;
using System.Xml.Serialization;
using System.Xml;
using SMEV3v11.Types.Basic;

namespace SMEV3v11.Types
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1")]
    public class Cancel
    {
        /// <summary>
        /// Ссылка на запрос, который нужно отменить.
        /// Сюда нужно писать ID СМЭВ-сообщения, который был передан при отправке запроса в элементе
        /// //SendRequestRequest/SenderProvidedRequestData/MessageID.
        /// </summary>
        [XmlElement(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.1", Order = 0)]
        public MessageReference MessageReference { get; set; }

        /// <summary>
        /// Идентификатор, присвоенный СМЭВ уведомлению об отмене.
        /// Генерируется в соответствии с RFC-4122, по варианту 1 (на основании MAC-адреса и текущего времени).
        /// </summary>
        [XmlElement(Order = 1)]
        public string MessageID { get; set; }

        [XmlElement(Order = 2)]
        public MessageMetadata MessageMetadata { get; set; }

        /// <summary>
        /// ЭП-ОВ или ЭП-ПГУ отправителя. Подписан элемент //SenderProvidedCancelData
        /// </summary>
        [XmlElement(Order = 3)]
        public XmlElement SenderInformationSystemSignature { get; set; }

        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }
    }
}
