using System;
using System.Xml.Serialization;

namespace SMEV3.SMEV3v11.Types.Basic
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.1")]
    [XmlRoot(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.1", IsNullable = false)]
    public class FSAttachmentsList
    {
        [XmlElement("FSAttachment")]
        public FSAuthInfo[] FSAttachment { get; set; }
    }
}
