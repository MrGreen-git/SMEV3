using SMEV3v12.Types.Basic;
using System;
using System.Xml.Serialization;

namespace SMEV3v12.Types
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2")]
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
        public MessageMetadataRecipient Recipient { get; set; }

        [XmlElement(Order = 5)]
        public DateTime DeliveryTimestamp { get; set; }

        [XmlIgnore]
        public bool DeliveryTimestampSpecified { get; set; }

        [XmlElement(Order = 6)]
        public InteractionStatusType Status { get; set; }

        [XmlIgnore]
        public bool StatusSpecified { get; set; }

        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }
    }
}
