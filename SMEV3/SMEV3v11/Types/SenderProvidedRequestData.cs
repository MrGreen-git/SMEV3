using System;
using System.Xml.Serialization;
using System.Xml;
using SMEV3v11.Types.Basic;
using System.ServiceModel.Channels;

namespace SMEV3v11.Types
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1")]
    public class SenderProvidedRequestData
    {
        /// <summary>
        /// Идентификатор, присвоенный сообщению отправителем.
        /// Генерируется в соответствии с RFC-4122, по варианту 1 (на основании MAC-адреса и текущего времени).
        /// </summary>
        [XmlElement(Order = 0)]
        public string MessageID { get; set; }

        /// <summary>
        /// Идентификатор сообщения, порождающего цепочку сообщений.
        /// При отправке подчиненных сообщений значение соответствует MessageID корневого сообщения цепочки сообщений.
        /// Для корневого сообщения значение совпадает с MessageID
        /// </summary>
        [XmlElement(Order = 1)]
        public string ReferenceMessageID { get; set; }

        /// <summary>
        /// Идентификатор кода транзакции.
        /// </summary>
        [XmlElement(Order = 2)]
        public string TransactionCode { get; set; }

        /// <summary>
        /// Идентификатор нода отправителя.
        /// </summary>
        [XmlElement(Order = 3)]
        public string NodeID { get; set; }

        /// <summary>
        /// Ограничение жизни сообщения.
        /// </summary>
        [XmlElement(Order = 4)]
        public DateTime EOL { get; set; }

        [XmlIgnore]
        public bool EOLSpecified { get; set; }

        /// <summary>
        /// Содержательная часть запроса, XML-документ.
        /// </summary>
        [XmlElement(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.1", Order = 5)]
        public XmlElement MessagePrimaryContent { get; set; }

        /// <summary>
        /// ЭП-СП содержательной части запроса.
        /// Подписывается элемент, находящийся сразу под MessagePrimaryContent.
        /// Хотя этот элемент не обязателен, поставщик данных может потребовать,
        /// чтобы в запросах определённых типов ЭП-СП всегда была.
        /// Это вызвано тем, что в ряде случаев, согласно ФЗ, сведения могут предоставляться только по запросам
        /// должностных лиц определённого уровня.
        /// </summary>
        [XmlElement(Order = 6)]
        public XmlElement PersonalSignature { get; set; }

        /// <summary>
        /// Заголовки вложенных файлов.
        /// </summary>
        [XmlElement("AttachmentHeaderList", typeof(AttachmentHeaderList), Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.1", Order = 7)]
        public AttachmentHeaderType[] AttachmentHeaderList { get; set; }

        /// <summary>
        /// Заголовки файлов по ссылке.
        /// </summary>
        [XmlElement("RefAttachmentHeaderList", typeof(RefAttachmentHeaderList), Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.1", Order = 8)]
        public RefAttachmentHeaderType[] RefAttachmentHeaderList { get; set; }

        /// <summary>
        /// Информация о бизнес-процессе, в рамках которого пересылается данное сообщение.
        /// Формат данных определяется в отдельной схеме(схемах).
        /// На текущий эта информация не обязательна для заполнения отправителем.
        /// </summary>
        [XmlElement(Order = 9)]
        public BusinessProcessMetadata BusinessProcessMetadata { get; set; }

        /// <summary>
        /// Если этот элемент присутствует, то запрос - тестовый.
        /// В этом случае, ИС-поставщик данных должна гарантировать, что её данные не будут изменены
        /// в результате выполнения этого запроса.
        /// </summary>
        [XmlElement(Order = 10)]
        public Basic.Void TestMessage { get; set; }

        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }
    }
}
