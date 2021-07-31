using SMEV3v13.Types.Basic;
using SMEV3v13.Types.Routing;
using SMEV3v13.Types;
using System.ServiceModel;
using System.Xml.Serialization;
using System.Xml;

namespace SMEV3v13.MessageContract
{
    [MessageContract(WrapperName = "SendRequestRequest", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3", IsWrapped = true)]
    public class SendRequestRequestContract
    {
        public SendRequestRequestContract(SenderProvidedRequestData senderProvidedRequestData, AttachmentContentType[] attachmentContentList, XmlElement callerInformationSystemSignature, Routing routing)
        {
            SenderProvidedRequestData = senderProvidedRequestData;
            AttachmentContentList = attachmentContentList;
            CallerInformationSystemSignature = callerInformationSystemSignature;
            Routing = routing;
        }

        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3", Order = 0)]
        public SenderProvidedRequestData SenderProvidedRequestData;

        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3", Order = 1)]
        [XmlElement("AttachmentContentList", typeof(AttachmentContentList), Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3")]
        public AttachmentContentType[] AttachmentContentList;

        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3", Order = 2)]
        public XmlElement CallerInformationSystemSignature;

        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/routing/1.3", Order = 3)]
        [XmlElement(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/routing/1.3")]
        public Routing Routing;
    }
}
