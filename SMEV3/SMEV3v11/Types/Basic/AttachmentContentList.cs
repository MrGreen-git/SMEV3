using System;
using System.Xml.Serialization;

namespace SMEV3v11.Types.Basic
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.1")]
    public class AttachmentContentList
    {
        [XmlElement("AttachmentContent", Order = 0)]
        public AttachmentContentType[] AttachmentContent { get; set; }
    }
}
