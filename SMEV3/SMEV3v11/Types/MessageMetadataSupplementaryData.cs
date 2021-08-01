using SMEV3v11.Types.Basic;
using System;
using System.Xml.Serialization;

namespace SMEV3v11.Types
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1")]
    public class MessageMetadataSupplementaryData
    {
        [XmlElement(Order = 0)]
        public string DetectedContentTypeName { get; set; }

        [XmlElement(Order = 1)]
        public InteractionTypeType InteractionType { get; set; }
    }
}
