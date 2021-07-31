using System;
using System.Xml.Serialization;

namespace SMEV3v13.Types.Routing
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/routing/1.3")]
    public class DynamicRoutingStatus
    {
        [XmlElement(Order = 0)]
        public string DynamicValue { get; set; }

        [XmlElement(Order = 1)]
        public RoutingStatusCodeType RoutingStatusCode { get; set; }
    }
}
