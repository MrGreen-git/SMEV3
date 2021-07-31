using SMEV3v13.Types.Basic;
using SMEV3v13.Types;
using System.ServiceModel;
using System.Xml.Serialization;
using System.Xml;

namespace SMEV3v13.MessageContract
{
    [MessageContract(WrapperName = "SendResponseRequest", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3", IsWrapped = true)]
    public class SendResponseRequestContract
    {
        public SendResponseRequestContract(SenderProvidedResponseData senderProvidedResponseData, AttachmentContentType[] attachmentContentList, XmlElement callerInformationSystemSignature)
        {
            SenderProvidedResponseData = senderProvidedResponseData;
            AttachmentContentList = attachmentContentList;
            CallerInformationSystemSignature = callerInformationSystemSignature;
        }

        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3", Order = 0)]
        public SenderProvidedResponseData SenderProvidedResponseData;

        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3", Order = 1)]
        [XmlElement("AttachmentContentList", typeof(AttachmentContentList), Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3")]
        public AttachmentContentType[] AttachmentContentList;

        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3", Order = 2)]
        public XmlElement CallerInformationSystemSignature; 
    }
}
