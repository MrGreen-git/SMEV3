using System;
using System.Xml.Serialization;
using System.Xml;

namespace SMEV3v13.Types.Routing
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/routing/1.3")]
    public class Routing
    {
        [XmlElement(Order = 0)]
        public RoutingInformation RoutingInformation { get; set; }

        [XmlElement(Order = 1)]
        public XmlElement RoutingSignature { get; set; }
    }
}
