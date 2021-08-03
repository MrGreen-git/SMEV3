using System;
using System.Xml.Serialization;

namespace SMEV3v11.Types
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1")]
    public class RequestRejected
    {
        /// <summary>
        /// Код причины отклонения запроса.
        /// </summary>
        [XmlElement(Order = 0)]
        public RejectCode RejectionReasonCode { get; set; }

        /// <summary>
        /// Причина отклонения запроса, в человекочитаемом виде.
        /// </summary>
        [XmlElement(Order = 1)]
        public string RejectionReasonDescription { get; set; }
    }
}
