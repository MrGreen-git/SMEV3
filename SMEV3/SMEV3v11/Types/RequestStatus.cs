using System;
using System.Xml.Serialization;

namespace SMEV3v11.Types
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1")]
    public class RequestStatus
    {
        /// <summary>
        /// Код бизнес статуса запроса.
        /// </summary>
        [XmlElement(Order = 0)]
        public int StatusCode { get; set; }

        [XmlElement("StatusParameter", Order = 1)]
        public StatusParameter[] StatusParameter { get; set; }

        /// <summary>
        /// Бизнес статус запроса, в человекочитаемом виде.
        /// </summary>
        [XmlElement(Order = 2)]
        public string StatusDescription { get; set; }
    }
}
