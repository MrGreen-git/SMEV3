using System.ComponentModel;
using System.ServiceModel;
using System.Xml.Serialization;
using System.Xml;
using SMEV3v12.Types.Basic;

namespace SMEV3v12.MessageContract
{
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(WrapperName = "AckRequest", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", IsWrapped = true)]
    public class AckRequestContract
    {
        protected AckRequestContract() { }

        public AckRequestContract(AckTargetMessage ackTargetMessage, XmlElement callerInformationSystemSignature)
        {
            AckTargetMessage = ackTargetMessage;
            CallerInformationSystemSignature = callerInformationSystemSignature;
        }

        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2", Order = 0)]
        [XmlElement(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2")]
        public AckTargetMessage AckTargetMessage;

        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", Order = 1)]
        public XmlElement CallerInformationSystemSignature;
    }
}
