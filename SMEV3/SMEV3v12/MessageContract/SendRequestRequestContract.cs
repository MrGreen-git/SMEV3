using System.ServiceModel;
using System.Xml.Serialization;
using System.Xml;
using SMEV3v12.Types;
using SMEV3v12.Types.Basic;

namespace SMEV3v12.MessageContract
{
    [MessageContract(WrapperName = "SendRequestRequest", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", IsWrapped = true)]
    public class SendRequestRequestContract
    {
        public SendRequestRequestContract(SenderProvidedRequestData senderProvidedRequestData, AttachmentContentType[] attachmentContentList, XmlElement callerInformationSystemSignature)
        {
            SenderProvidedRequestData = senderProvidedRequestData;
            AttachmentContentList = attachmentContentList;
            CallerInformationSystemSignature = callerInformationSystemSignature;
        }

        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", Order = 0)]
        public SenderProvidedRequestData SenderProvidedRequestData { get; set; }

        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2", Order = 1)]
        [XmlElement("AttachmentContentList", typeof(AttachmentContentList), Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2")]
        public AttachmentContentType[] AttachmentContentList { get; set; }

        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", Order = 2)]
        public XmlElement CallerInformationSystemSignature { get; set; }     
    }
}
