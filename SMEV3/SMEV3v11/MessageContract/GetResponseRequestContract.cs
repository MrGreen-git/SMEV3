using System.ComponentModel;
using System.ServiceModel;
using System.Xml.Serialization;
using System.Xml;
using SMEV3v11.Types.Basic;

namespace SMEV3v11.MessageContract
{
    /// <summary>
    /// Параметры метода "получить сообщение из моей входящей очереди ответов, если очередь не пуста".
    /// Какую входящую очередь смотреть - определаятся по владельцу сертификата, входящего в состав ЭЦП,
    /// и селектору типа _ответа_.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(WrapperName = "GetResponseRequest", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1", IsWrapped = true)]
    public class GetResponseRequestContract
    {
        public GetResponseRequestContract(MessageTypeSelector messageTypeSelector, XmlElement callerInformationSystemSignature)
        {
            MessageTypeSelector = messageTypeSelector;
            CallerInformationSystemSignature = callerInformationSystemSignature;
        }

        /// <summary>
        /// См. описание {urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.1}MessageTypeSelector
        /// </summary>
        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.1", Order = 0)]
        [XmlElement(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.1")]
        public MessageTypeSelector MessageTypeSelector;

        /// <summary>
        /// ЭП-ОВ или ЭП-ПГУ. Подписан элемент //MessageTypeSelector
        /// </summary>
        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1", Order = 1)]
        public XmlElement CallerInformationSystemSignature;
    }
}
