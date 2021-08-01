using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Xml;

namespace SMEV3v11.DataContract
{
    [XmlSchemaProvider("ExportSchema")]
    [XmlRoot(IsNullable = false)]
    public class InvalidContent : object, IXmlSerializable
    {
        private static XmlQualifiedName typeName = new XmlQualifiedName("InvalidContent", "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.1");

        public XmlNode[] Nodes { get; set; }

        public void ReadXml(XmlReader reader)
        {
            Nodes = XmlSerializableServices.ReadNodes(reader);
        }

        public void WriteXml(XmlWriter writer)
        {
            XmlSerializableServices.WriteNodes(writer, Nodes);
        }

        public System.Xml.Schema.XmlSchema GetSchema()
        {
            return null;
        }

        public static XmlQualifiedName ExportSchema(System.Xml.Schema.XmlSchemaSet schemas)
        {
            XmlSerializableServices.AddDefaultSchema(schemas, typeName);
            return typeName;
        }
    }
}
