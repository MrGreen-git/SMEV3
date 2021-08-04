using System.ComponentModel;
using System.ServiceModel;
using System.Xml.Serialization;
using System.Xml;
using SMEV3v11.Types.Basic;

namespace SMEV3v11.MessageContract
{
    /// <summary>
    /// Параметры метода "получить статистику входящей очереди".
    /// Какую входящую очередь смотреть - определаятся по владельцу сертификата, входящего в состав ЭЦП.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(WrapperName = "GetIncomingQueueStatisticsRequest", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1", IsWrapped = true)]
    public class GetIncomingQueueStatisticsRequestContract
    {
        /// <summary/>
        protected GetIncomingQueueStatisticsRequestContract() { }

        public GetIncomingQueueStatisticsRequestContract(string nodeID, Timestamp timestamp, XmlElement callerInformationSystemSignature)
        {
            NodeID = nodeID;
            Timestamp = timestamp;
            CallerInformationSystemSignature = callerInformationSystemSignature;
        }

        /// <summary>
        /// Идентификатор нода.
        /// </summary>
        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1", Order = 0)]
        public string NodeID;

        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.1", Order = 1)]
        [XmlElement(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.1")]
        public Timestamp Timestamp;

        /// <summary>
        /// ЭП-ОВ или ЭП-ПГУ. Подписан элемент //СurrentTimestamp.
        /// </summary>
        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1", Order = 2)]
        public XmlElement CallerInformationSystemSignature;
    }
}
