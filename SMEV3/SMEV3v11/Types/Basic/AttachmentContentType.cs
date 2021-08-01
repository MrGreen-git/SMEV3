using System;
using System.Xml.Serialization;

namespace SMEV3v11.Types.Basic
{
    [Serializable]
    [XmlType(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.1")]
    public class AttachmentContentType
    {
        [XmlElement(DataType = "ID", Order = 0)]
        public string Id { get; set; }

        [XmlElement(DataType = "base64Binary", Order = 1)]
        public byte[] Content { get; set; }
    }
}
