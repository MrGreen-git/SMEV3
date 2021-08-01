using SMEV3v11.Types;
using System.ServiceModel;
using System.Xml;

namespace SMEV3v11.MessageContract
{
    [MessageContract(WrapperName = "SendResponseResponse", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1", IsWrapped = true)]
    public class SendResponseResponseContract
    {
        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1", Order = 0)]
        public MessageMetadata MessageMetadata;

        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1", Order = 1)]
        public XmlElement SMEVSignature;

        public SendResponseResponseContract(MessageMetadata MessageMetadata, XmlElement SMEVSignature)
        {
            this.MessageMetadata = MessageMetadata;
            this.SMEVSignature = SMEVSignature;
        }
    }
}
