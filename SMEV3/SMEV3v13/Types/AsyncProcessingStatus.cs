using SMEV3v13.Types.Basic;
using SMEV3v13.Types.Routing;
using System;
using System.Xml.Serialization;

namespace SMEV3v13.Types
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3")]
    public class AsyncProcessingStatus
    {
        [XmlElement(Order = 0)]
        public string OriginalMessageId { get; set; }

        [XmlElement(Order = 1)]
        public InteractionStatusType StatusCategory { get; set; }

        [XmlElement(Order = 2)]
        public string StatusDetails { get; set; }

        [XmlElement(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/routing/1.3", Order = 3)]
        public RoutingStatus RoutingStatus { get; set; }

        [XmlElement(Order = 4)]
        public SmevFault SmevFault { get; set; }
    }
}
