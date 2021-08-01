using SMEV3v11.Types.Basic;
using System;
using System.Xml.Serialization;

namespace SMEV3v11.Types
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1")]
    public class MessageMetadata
    {
        [XmlElement(Order = 0)]
        public string MessageId { get; set; }

        [XmlElement(Order = 1)]
        public MessageTypeType MessageType { get; set; }

        [XmlElement(Order = 2)]
        public MessageMetadataSender Sender { get; set; }

        [XmlElement(Order = 3)]
        public DateTime SendingTimestamp { get; set; }

        [XmlElement(Order = 4)]
        public string MessageBroker { get; set; }

        [XmlElement(Order = 5)]
        public string DestinationName { get; set; }

        [XmlElement(Order = 6)]
        public MessageMetadataRecipient Recipient { get; set; }

        [XmlElement(Order = 7)]
        public MessageMetadataSupplementaryData SupplementaryData { get; set; }

        [XmlElement(Order = 8)]
        public DateTime DeliveryTimestamp { get; set; }

        [XmlIgnore]
        public bool DeliveryTimestampSpecified { get; set; }

        [XmlElement(Order = 9)]
        public InteractionStatusType Status { get; set; }

        [XmlIgnore]
        public bool StatusSpecified { get; set; }

        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }
    }
}
