using System;
using System.Xml.Serialization;
using System.Xml;

namespace SMEV3v12.Types
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2")]
    public class SmevAsyncProcessingMessage
    {
        [XmlElement("AsyncProcessingStatusData", Order = 0)]
        public AsyncProcessingStatusData Item { get; set; }

        [XmlElement(Order = 1)]
        public XmlElement SMEVSignature { get; set; }
    }
}
