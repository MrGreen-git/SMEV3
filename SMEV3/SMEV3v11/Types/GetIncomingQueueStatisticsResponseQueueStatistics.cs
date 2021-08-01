using System;
using System.Xml.Serialization;

namespace SMEV3v11.Types
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1")]
    public class GetIncomingQueueStatisticsResponseQueueStatistics
    {
        [XmlAttribute]
        public string queueName { get; set; }

        [XmlAttribute]
        public long pendingMessageNumber { get; set; }

        [XmlIgnore]
        public bool pendingMessageNumberSpecified { get; set; }
    }
}
