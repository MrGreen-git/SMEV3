using System.ComponentModel;
using System.ServiceModel;
using System.Xml.Serialization;
using System.Xml;
using SMEV3v12.Types.Basic;

namespace SMEV3v12.MessageContract
{
    /// <summary>
    /// Параметры метода "получить сообщение из моей входящей очереди запросов, если очередь не пуста".
    /// Какую входящую очередь смотреть - определаятся по владельцу сертификата, входящего в состав ЭЦП,
    /// и селектору типа запроса.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(WrapperName = "GetRequestRequest", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", IsWrapped = true)]
    public class GetRequestRequestContract
    {
        /// <summary/>
        protected GetRequestRequestContract() { }

        public GetRequestRequestContract(MessageTypeSelector messageTypeSelector, XmlElement callerInformationSystemSignature)
        {
            MessageTypeSelector = messageTypeSelector;
            CallerInformationSystemSignature = callerInformationSystemSignature;
        }

        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2", Order = 0)]
        [XmlElement(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2")]
        public MessageTypeSelector MessageTypeSelector;

        /// <summary>
        /// ЭП-ОВ или ЭП-ПГУ. Подписан элемент //MessageTypeSelector
        /// </summary>
        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", Order = 1)]
        public XmlElement CallerInformationSystemSignature;
    }
}
