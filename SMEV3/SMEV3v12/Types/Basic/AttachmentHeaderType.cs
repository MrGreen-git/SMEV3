using System;
using System.Xml.Serialization;

namespace SMEV3v12.Types.Basic
{
    [Serializable]
    [XmlType(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2")]
    public class AttachmentHeaderType
    {
        [XmlElement(Order = 0)]
        public string contentId { get; set; }

        [XmlElement(Order = 1)]
        public string MimeType { get; set; }

        [XmlElement(DataType = "base64Binary", Order = 2)]
        public byte[] SignaturePKCS7 { get; set; }
    }
}
