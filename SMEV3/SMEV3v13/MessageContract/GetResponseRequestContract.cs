using SMEV3v13.Types.Basic;
using System.ComponentModel;
using System.ServiceModel;
using System.Xml.Serialization;
using System.Xml;

namespace SMEV3v13.MessageContract
{
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(WrapperName = "GetResponseRequest", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3", IsWrapped = true)]
    public class GetResponseRequestContract
    {
        /// <summary/>
        protected GetResponseRequestContract() { }

        public GetResponseRequestContract(MessageTypeSelector messageTypeSelector, XmlElement callerInformationSystemSignature)
        {
            MessageTypeSelector = messageTypeSelector;
            CallerInformationSystemSignature = callerInformationSystemSignature;
        }

        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3", Order = 0)]
        [XmlElement(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3")]
        public MessageTypeSelector MessageTypeSelector;

        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3", Order = 1)]
        public XmlElement CallerInformationSystemSignature;
    }
}
