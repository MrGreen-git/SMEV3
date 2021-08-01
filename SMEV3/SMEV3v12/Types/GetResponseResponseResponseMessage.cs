using System;
using System.Xml.Serialization;
using System.Xml;
using SMEV3v12.Types.Basic;

namespace SMEV3v12.Types
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2")]
    public class GetResponseResponseResponseMessage
    {
        [XmlElement(Order = 0)]
        public Response Response { get; set; }

        [XmlElement(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2", Order = 1)]
        public AttachmentContentList AttachmentContentList { get; set; }

        [XmlElement(Order = 2)]
        public XmlElement SMEVSignature { get; set; }
    }
}
