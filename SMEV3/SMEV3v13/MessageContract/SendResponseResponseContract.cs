using SMEV3v13.Types;
using System.ServiceModel;
using System.Xml;

namespace SMEV3v13.MessageContract
{
    [MessageContract(WrapperName = "SendResponseResponse", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3", IsWrapped = true)]
    public class SendResponseResponseContract
    {
        /// <summary/>
        protected SendResponseResponseContract() { }

        public SendResponseResponseContract(MessageMetadata messageMetadata, XmlElement SMEVSignature)
        {
            MessageMetadata = messageMetadata;
            this.SMEVSignature = SMEVSignature;
        }

        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3", Order = 0)]
        public MessageMetadata MessageMetadata;

        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3", Order = 1)]
        public XmlElement SMEVSignature;
    }
}
