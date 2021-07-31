using System;
using System.Xml.Serialization;

namespace SMEV3v13.Types.Routing
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/routing/1.3")]
    public class RegistryRecordRouting
    {
        [XmlElement(Order = 0)]
        public int RecordId { get; set; }

        [XmlElement(Order = 1)]
        public bool UseGeneralRouting { get; set; }

        [XmlArray(Order = 2)]
        [XmlArrayItem("DynamicValue", IsNullable = false)]
        public string[] DynamicRouting { get; set; }

        [XmlArray(Order = 3)]
        [XmlArrayItem("IdentifierValue", IsNullable = false)]
        public string[] IdentifierRouting { get; set; }
    }
}
