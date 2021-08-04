using SMEV3v12.Types.Basic;
using System;
using System.Xml.Serialization;

namespace SMEV3v12.Types
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2")]
    public class AsyncProcessingStatus
    {
        [XmlElement(Order = 0)]
        public string OriginalMessageId { get; set; }

        /// <summary>
        /// Категория статуса
        /// </summary>
        [XmlElement(Order = 1)]
        public InteractionStatusType StatusCategory { get; set; }

        /// <summary>
        /// Описание процессинга в человекочитаемом виде
        /// </summary>
        [XmlElement(Order = 2)]
        public string StatusDetails { get; set; }

        [XmlElement(Order = 3)]
        public SmevFault SmevFault { get; set; }
    }
}
