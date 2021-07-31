using SMEV3v13.Types.Basic;
using System;
using System.Xml.Serialization;
using System.Xml;

namespace SMEV3v13.Types
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3")]
    public class GetRequestResponseRequestMessage
    {
        [XmlElement("Request", typeof(Request), Order = 0)]
        [XmlElement("AttachmentContentList", typeof(AttachmentContentList), Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3", Order = 0)]
        public object[] Items { get; set; }

        [XmlElement(Order = 1)]
        public XmlElement SMEVSignature { get; set; }
    }
}
