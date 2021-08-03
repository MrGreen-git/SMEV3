using System;
using System.Xml.Serialization;
using System.Xml;
using SMEV3v11.Types.Basic;

namespace SMEV3v11.Types
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1")]
    public class Request
    {
        [XmlElement(Order = 0)]
        public SenderProvidedRequestData SenderProvidedRequestData { get; set; }

        /// <summary>
        /// Информация об отправителе, дате отправки, маршрутизации сообщения, и другая (см. определение типа).
        /// Все данные заполняются СМЭВ.
        /// Элемент //MessageMetadata/SendingTimestamp содержит дату и время, начиная с которых отсчитывается срок исполнения запроса.
        /// Остальные данные предназначены для целей анализа (машинного и ручного) качества обслуживания
        /// информационной системы - получателя сообщения,
        /// а также для предоставления службе поддержки оператора СМЭВ в случае необходимости.
        /// </summary>
        [XmlElement(Order = 1)]
        public MessageMetadata MessageMetadata { get; set; }

        [XmlArray(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.1", Order = 2)]
        [XmlArrayItem("FSAttachment", IsNullable = false)]
        public FSAuthInfo[] FSAttachmentsList { get; set; }

        /// <summary>
        /// Аналог обратного адреса; непрозрачный объект, по которому СМЭВ сможет вычислить, кому доставить ответ на этот запрос.
        /// При отправке ответа нужно скопировать это значение в //SenderProvidedResponseData/To/text().
        /// N.B.Формат обратного адреса не специфицирован, и может меняться со временем.
        /// Больше того, в запросах, пришедших от одного и того же отправителя через сколь угодно малый промежуток времени,
        /// обратный адрес не обязан быть одним и тем же.
        /// Если получатель хочет идентифицировать отправителя, можно использовать либо маршрутную информацию СМЭВ
        /// (//GetMessageIfAnyResponse/SMEVRoutingInfo/Sender/*), либо сертификат отправителя
        /// (//GetMessageIfAnyResponse/CallerInformationSystemSignature/xmldsig:Signature/...)
        /// </summary>
        [XmlElement(Order = 3)]
        public string ReplyTo { get; set; }

        /// <summary>
        /// ЭП-ОВ или ЭП-ПГУ отправителя. Подписан элемент //SenderProvidedRequestData
        /// </summary>
        [XmlElement(Order = 4)]
        public XmlElement SenderInformationSystemSignature { get; set; }

        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }
    }
}
