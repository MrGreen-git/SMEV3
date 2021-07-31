using System;
using System.Xml.Serialization;

namespace SMEV3v13.Types.Routing
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/routing/1.3")]
    public class RoutingStatus
    {
        [XmlElement("DynamicRoutingStatus", Order = 0)]
        public DynamicRoutingStatus[] DynamicRoutingStatus { get; set; }

        [XmlElement("IdentifierRoutingStatus", Order = 1)]
        public IdentifierRoutingStatus[] IdentifierRoutingStatus { get; set; }

        [XmlElement("RegistryRoutingStatus", Order = 2)]
        public RegistryRoutingStatus[] RegistryRoutingStatus { get; set; }
    }
}
