using System;
using System.Xml.Serialization;

namespace SMEV3v13.Types.Basic
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3")]
    [XmlRoot(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3", IsNullable = false)]
    public class FSAttachmentsList
    {
        [XmlElement("FSAttachment")]
        public FSAuthInfo[] FSAttachment { get; set; }
    }
}
