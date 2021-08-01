using System.Runtime.Serialization;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Xml;

namespace SMEV3v12
{
    [XmlSchemaProvider("ExportSchema")]
    [XmlRoot(IsNullable = false)]
    public class InvalidContent : object, IXmlSerializable
    {
        private static XmlQualifiedName typeName = new XmlQualifiedName("InvalidContent", "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2");

        public XmlNode[] Nodes { get; set; }

        public void ReadXml(XmlReader reader)
        {
            Nodes = XmlSerializableServices.ReadNodes(reader);
        }

        public void WriteXml(XmlWriter writer)
        {
            XmlSerializableServices.WriteNodes(writer, this.Nodes);
        }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public static XmlQualifiedName ExportSchema(XmlSchemaSet schemas)
        {
            XmlSerializableServices.AddDefaultSchema(schemas, typeName);
            return typeName;
        }
    }
}
