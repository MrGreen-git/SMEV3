using System;
using System.Xml.Serialization;

namespace SMEV3v11.Types.Basic
{
    [Serializable]
    [XmlType(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.1")]
    public class RefAttachmentHeaderType
    {
        [XmlElement(Order = 0)]
        public string uuid { get; set; }

        [XmlElement(Order = 1)]
        public string Hash { get; set; }

        [XmlElement(Order = 2)]
        public string MimeType { get; set; }

        [XmlElement(DataType = "base64Binary", Order = 3)]
        public byte[] SignaturePKCS7 { get; set; }
    }
}
