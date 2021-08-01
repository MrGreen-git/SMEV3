using System;
using System.Xml.Serialization;
using System.Xml;

namespace SMEV3v11.Types
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1")]
    public class SenderProvidedRequestDataBusinessProcessMetadata
    {
        [XmlAnyElement(Order = 0)]
        public XmlElement[] Any { get; set; }
    }
}
