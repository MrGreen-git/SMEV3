using System;
using System.Xml.Serialization;

namespace SMEV3v11.Types
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1")]
    public class SenderProvidedResponseDataRequestStatus
    {
        [XmlElement(Order = 0)]
        public int StatusCode { get; set; }

        [XmlElement("StatusParameter", Order = 1)]
        public SenderProvidedResponseDataRequestStatusStatusParameter[] StatusParameter { get; set; }

        [XmlElement(Order = 2)]
        public string StatusDescription { get; set; }
    }
}
