using System;
using System.Xml.Serialization;

namespace SMEV3v13.Types.Basic
{
    [Serializable]
    [XmlType(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3")]
    public class AttachmentHeaderType
    {
        [XmlElement(Order = 0)]
        public string contentId { get; set; }


        [XmlElement(Order = 1)]
        public string NamespaceUri { get; set; }


        [XmlElement(Order = 2)]
        public string MimeType { get; set; }


        [XmlElement(DataType = "base64Binary", Order = 3)]
        public byte[] SignaturePKCS7 { get; set; }


        [XmlArray(Order = 4)]
        [XmlArrayItem("File", IsNullable = false)]
        public FileType[] Archive { get; set; }
    }
}
