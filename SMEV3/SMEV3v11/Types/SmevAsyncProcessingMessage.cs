using System;
using System.Xml.Serialization;
using System.Xml;

namespace SMEV3v11.Types
{
    /// <summary>
    /// Сообщение об статусе асинхронной обработки в СМЭВ
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1")]
    public class SmevAsyncProcessingMessage
    {
        [XmlElement("AsyncProcessingStatusData", Order = 0)]
        public AsyncProcessingStatusData Item { get; set; }

        /// <summary>
        /// ЭП-СМЭВ. Подписан элемент preceding-sibling:
        /// </summary>
        [XmlElement(Order = 1)]
        public XmlElement SMEVSignature { get; set; }
    }
}
