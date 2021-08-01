using System.ServiceModel;
using System.Xml.Serialization;
using System.Xml;
using SMEV3v11.Types;
using SMEV3v11.Types.Basic;

namespace SMEV3v11.MessageContract
{
    [MessageContract(WrapperName = "SendResponseRequest", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1", IsWrapped = true)]
    public class SendResponseRequestContract
    {
        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1", Order = 0)]
        public SenderProvidedResponseData SenderProvidedResponseData;

        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.1", Order = 1)]
        [XmlElement("AttachmentContentList", typeof(AttachmentContentList), Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.1")]
        public AttachmentContentType[] AttachmentContentList;

        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1", Order = 2)]
        public XmlElement CallerInformationSystemSignature;

        public SendResponseRequestContract(SenderProvidedResponseData SenderProvidedResponseData, AttachmentContentType[] AttachmentContentList, XmlElement CallerInformationSystemSignature)
        {
            this.SenderProvidedResponseData = SenderProvidedResponseData;
            this.AttachmentContentList = AttachmentContentList;
            this.CallerInformationSystemSignature = CallerInformationSystemSignature;
        }
    }
}
