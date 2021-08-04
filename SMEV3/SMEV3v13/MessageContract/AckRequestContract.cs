using SMEV3v13.Types.Basic;
using System.ComponentModel;
using System.ServiceModel;
using System.Xml.Serialization;
using System.Xml;

namespace SMEV3v13.MessageContract
{
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(WrapperName = "AckRequest", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3", IsWrapped = true)]
    public class AckRequestContract
    {
        /// <summary/>
        protected AckRequestContract() { }

        public AckRequestContract(AckTargetMessage ackTargetMessage, XmlElement callerInformationSystemSignature)
        {
            AckTargetMessage = ackTargetMessage;
            CallerInformationSystemSignature = callerInformationSystemSignature;
        }

        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3", Order = 0)]
        [XmlElement(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3")]
        public AckTargetMessage AckTargetMessage { get; set; }

        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3", Order = 1)]
        public XmlElement CallerInformationSystemSignature { get; set; }
    }
}
