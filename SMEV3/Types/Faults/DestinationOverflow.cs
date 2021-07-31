using System;
using System.Xml.Serialization;

namespace SMEV3v13.Types.Faults
{
    [Serializable]
    [XmlType(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    public class DestinationOverflow : SmevFault
    {
        [XmlElement(Order = 0)]
        public string MessageBrokerAddress { get; set; }

        [XmlElement(Order = 1)]
        public string DestinationName { get; set; }
    }
}
