using System.ServiceModel;
using System.Xml.Serialization;
using System.Xml;
using SMEV3v12.Types;
using SMEV3v12.Types.Basic;

namespace SMEV3v12.MessageContract
{
    [MessageContract(WrapperName = "SendResponseRequest", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", IsWrapped = true)]
    public class SendResponseRequestContract
    {
        protected SendResponseRequestContract() { }

        public SendResponseRequestContract(SenderProvidedResponseData senderProvidedResponseData, AttachmentContentType[] attachmentContentList, XmlElement callerInformationSystemSignature)
        {
            SenderProvidedResponseData = senderProvidedResponseData;
            AttachmentContentList = attachmentContentList;
            CallerInformationSystemSignature = callerInformationSystemSignature;
        }

        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", Order = 0)]
        public SenderProvidedResponseData SenderProvidedResponseData;

        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2", Order = 1)]
        [XmlElement("AttachmentContentType", typeof(AttachmentContentType), Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2")]
        public AttachmentContentType[] AttachmentContentList;

        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", Order = 2)]
        public XmlElement CallerInformationSystemSignature;
    }
}
