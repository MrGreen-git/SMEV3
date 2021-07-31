using System;
using System.Xml.Serialization;

namespace SMEV3v13.Types.Routing
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/routing/1.3")]
    public class RegistryRoutingStatus
    {
        [XmlElement(Order = 0)]
        public int RecordId { get; set; }

        [XmlElement(Order = 1)]
        public RoutingStatusCodeType RoutingStatusCode { get; set; }

        [XmlElement("DynamicRoutingStatus", Order = 2)]
        public DynamicRoutingStatus[] DynamicRoutingStatus { get; set; }

        [XmlElement("IdentifierRoutingStatus", Order = 3)]
        public IdentifierRoutingStatus[] IdentifierRoutingStatus { get; set; }
    }
}
