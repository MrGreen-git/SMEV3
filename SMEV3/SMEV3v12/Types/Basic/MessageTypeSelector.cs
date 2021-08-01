using System;
using System.Xml.Serialization;

namespace SMEV3v12.Types.Basic
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2")]
    public class MessageTypeSelector
    {
        [XmlElement(DataType = "anyURI", Order = 0)]
        public string NamespaceURI { get; set; }

        [XmlElement(DataType = "NCName", Order = 1)]
        public string RootElementLocalName { get; set; }

        [XmlElement(Order = 2)]
        public DateTime Timestamp { get; set; }

        [XmlElement(Order = 3)]
        public string NodeID { get; set; }

        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }
    }
}
