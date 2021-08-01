using System.ServiceModel;
using System.Xml.Serialization;
using System.Xml;
using SMEV3v11.Types;
using SMEV3v11.Types.Basic;

namespace SMEV3v11.MessageContract
{
    [MessageContract(WrapperName = "SendRequestRequest", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1", IsWrapped = true)]
    public class SendRequestRequestContract
    {

        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1", Order = 0)]
        public SenderProvidedRequestData SenderProvidedRequestData;

        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.1", Order = 1)]
        [XmlElement("AttachmentContentList", typeof(AttachmentContentList), Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.1")]
        public AttachmentContentType[] AttachmentContentList;

        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1", Order = 2)]
        public XmlElement CallerInformationSystemSignature;

        public SendRequestRequestContract(SenderProvidedRequestData SenderProvidedRequestData, AttachmentContentType[] AttachmentContentList, XmlElement CallerInformationSystemSignature)
        {
            this.SenderProvidedRequestData = SenderProvidedRequestData;
            this.AttachmentContentList = AttachmentContentList;
            this.CallerInformationSystemSignature = CallerInformationSystemSignature;
        }
    }
}
