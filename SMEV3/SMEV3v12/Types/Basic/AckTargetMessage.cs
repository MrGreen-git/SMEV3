using System;
using System.Xml.Serialization;

namespace SMEV3v12.Types.Basic
{
    /// <summary>
    /// Ссылка на сообщение, получение которого подтверждается методом Ack.
    /// Сюда нужно писать Id СМЭВ-сообщения, который берётся
    /// из //GetRequestResponse/.../SenderProvidedRequestData/MessageID/text() либо
    /// из //GetResponseResponse/.../SenderProvidedRequestData/MessageID/text().
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2")]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2")]
    public class AckTargetMessage
    {
        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }

        /// <summary>
        /// true, если ЭП-СМЭВ прошла валидацию и сообщение передано ИС. false, если ЭП-СМЭВ отвергнута, и сообщение проигнорировано
        /// </summary>
        [XmlAttribute()]
        public bool accepted { get; set; }

        [XmlIgnore]
        public bool acceptedSpecified { get; set; }

        [XmlText()]
        public string Value { get; set; }
    }
}
