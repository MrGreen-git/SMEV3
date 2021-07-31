using System;
using System.Xml.Serialization;

namespace SMEV3v13.Types
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3")]
    public class MessageMetadataRecipient
    {
        [XmlElement(Order = 0)]
        public string Mnemonic { get; set; }

        [XmlElement(Order = 1)]
        public string HumanReadableName { get; set; }
    }
}
