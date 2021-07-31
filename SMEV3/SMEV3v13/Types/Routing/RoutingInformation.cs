using System;
using System.Xml.Serialization;

namespace SMEV3v13.Types.Routing
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/routing/1.3")]
    public class RoutingInformation
    {
        [XmlElement(Order = 0)]
        public string MessageID { get; set; }

        [XmlArray(Order = 1)]
        [XmlArrayItem("DynamicValue", IsNullable = false)]
        public string[] DynamicRouting { get; set; }

        [XmlArray(Order = 2)]
        [XmlArrayItem("IdentifierValue", IsNullable = false)]
        public string[] IdentifierRouting { get; set; }
        
        [XmlArray(Order = 3)]
        [XmlArrayItem("RegistryRecordRouting", IsNullable = false)]
        public RegistryRecordRouting[] RegistryRouting { get; set; }

        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }
    }
}
