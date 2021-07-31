using SMEV3v13.Types.Basic;
using System;
using System.Xml.Serialization;
using System.Xml;

namespace SMEV3v13.Types
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3")]
    public class GetResponseResponseResponseMessage
    {
        [XmlElement(Order = 0)]
        public Response Response { get; set; }

        [XmlElement(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3", Order = 1)]
        public AttachmentContentList AttachmentContentList { get; set; }

        [XmlElement(Order = 2)]
        public XmlElement SMEVSignature { get; set; }
    }
}
