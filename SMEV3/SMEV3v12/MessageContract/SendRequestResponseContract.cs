using SMEV3v12.Types;
using System.ServiceModel;
using System.Xml;

namespace SMEV3v12.MessageContract
{
    [MessageContract(WrapperName = "SendRequestResponse", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", IsWrapped = true)]
    public class SendRequestResponseContract
    {
        public SendRequestResponseContract(MessageMetadata messageMetadata, XmlElement SMEVSignature)
        {
            MessageMetadata = messageMetadata;
            this.SMEVSignature = SMEVSignature;
        }

        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", Order = 0)]
        public MessageMetadata MessageMetadata;

        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", Order = 1)]
        public XmlElement SMEVSignature;
    }
}
