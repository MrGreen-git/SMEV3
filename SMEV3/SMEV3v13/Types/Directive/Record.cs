using SMEV3v13.Types.Basic;
using System;
using System.Xml.Serialization;
using System.Xml;

namespace SMEV3v13.Types.Directive
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/directive/1.3")]
    [XmlRoot(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/directive/1.3", IsNullable = false)]
    public class Record
    {
        public RecordContent RecordContent { get; set; }

        [XmlArray(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3")]
        [XmlArrayItem("AttachmentHeader", IsNullable = false)]
        public AttachmentHeaderType[] AttachmentHeaderList { get; set; }

        [XmlArray(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3")]
        [XmlArrayItem("RefAttachmentHeader", IsNullable = false)]
        public RefAttachmentHeaderType[] RefAttachmentHeaderList { get; set; }

        [XmlElement("PersonalSignature")]
        public XmlElement[] PersonalSignature { get; set; }

        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }
    }
}
