using System;
using System.Xml.Serialization;

namespace SMEV3v13.Types.Basic
{
    [Serializable]
    [XmlType(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3")]
    public class RefAttachmentHeaderType
    {
        [XmlElement(Order = 0)]
        public string uuid { get; set; }

        [XmlElement(Order = 1)]
        public string FileName { get; set; }

        [XmlElement(Order = 2)]
        public string NamespaceUri { get; set; }

        [XmlElement(Order = 3)]
        public string Hash { get; set; }

        [XmlElement(Order = 4)]
        public string MimeType { get; set; }

        [XmlElement(DataType = "base64Binary", Order = 5)]
        public byte[] SignaturePKCS7 { get; set; }

        [XmlArray(Order = 6)]
        [XmlArrayItem("File", IsNullable = false)]
        public FileType[] Archive { get; set; }
    }
}
