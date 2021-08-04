using System.ComponentModel;
using System.ServiceModel;
using System.Xml.Serialization;
using System.Xml;
using SMEV3v11.Types.Basic;

namespace SMEV3v11.MessageContract
{
    /// <summary>
    /// Параметры метода "получить сообщение из моей входящей очереди запросов, если очередь не пуста".
    /// Какую входящую очередь смотреть - определаятся по владельцу сертификата, входящего в состав ЭЦП,
    /// и селектору типа запроса.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(WrapperName = "GetStatusRequest", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1", IsWrapped = true)]
    public class GetStatusRequestContract
    {
        /// <summary/>
        protected GetStatusRequestContract() { }

        public GetStatusRequestContract(Timestamp timestamp, XmlElement callerInformationSystemSignature)
        {
            Timestamp = timestamp;
            CallerInformationSystemSignature = callerInformationSystemSignature;
        }

        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.1", Order = 0)]
        [XmlElement(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.1")]
        public Timestamp Timestamp;

        /// <summary>
        /// ЭП-ОВ или ЭП-ПГУ. Подписан элемент //Id.
        /// </summary>
        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1", Order = 1)]
        public XmlElement CallerInformationSystemSignature;
    }
}
