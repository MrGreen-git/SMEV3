using System;
using System.Xml.Serialization;
using System.Xml;
using SMEV3v12.Types.Basic;

namespace SMEV3v12.Types
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2")]
    public class GetRequestResponseRequestMessage
    {
        [XmlElement("Request", typeof(Request), Order = 0)]
        [XmlElement("AttachmentContentType", typeof(AttachmentContentType), Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2", Order = 0)]
        public object[] Items { get; set; }

        [XmlElement(Order = 1)]
        public XmlElement SMEVSignature { get; set; }
    }
}
