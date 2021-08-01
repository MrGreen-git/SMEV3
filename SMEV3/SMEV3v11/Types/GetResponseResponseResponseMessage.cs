using System;
using System.Xml.Serialization;
using System.Xml;
using SMEV3v11.Types.Basic;

namespace SMEV3v11.Types
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1")]
    public class GetResponseResponseResponseMessage
    {
        [XmlElement(Order = 0)]
        public Response Response { get; set; }

        [XmlElement(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.1", Order = 1)]
        public AttachmentContentList AttachmentContentList { get; set; }

        [XmlElement(Order = 2)]
        public XmlElement SMEVSignature { get; set; }
    }
}
