using System.ComponentModel;
using System.ServiceModel;
using System.Xml.Serialization;
using System.Xml;
using SMEV3v11.Types.Basic;

namespace SMEV3v11.MessageContract
{
    /// <summary>
    /// Параметры метода "Подтверждение получения сообщения".
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(WrapperName = "AckRequest", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1", IsWrapped = true)]
    public class AckRequestContract
    {
        public AckRequestContract(AckTargetMessage ackTargetMessage, XmlElement callerInformationSystemSignature)
        {
            AckTargetMessage = ackTargetMessage;
            CallerInformationSystemSignature = callerInformationSystemSignature;
        }

        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.1", Order = 0)]
        [XmlElement(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.1")]
        public AckTargetMessage AckTargetMessage;

        /// <summary>
        /// ЭП-ОВ или ЭП-ПГУ. Подписан элемент preceding-sibling::basic:AckTargetMessage.
        /// </summary>
        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1", Order = 1)]
        public XmlElement CallerInformationSystemSignature; 
    }
}
