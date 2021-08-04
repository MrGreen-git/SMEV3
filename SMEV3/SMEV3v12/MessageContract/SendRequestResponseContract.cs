using SMEV3v12.Types;
using System.ServiceModel;
using System.Xml;

namespace SMEV3v12.MessageContract
{
    /// <summary>
    /// Возвращаемое значение метода "Послать запрос": запрос принят.
    /// Если запрос не может быть принят, информация о причине отказа передаётся через SOAP fault, см.WSDL-описание сервиса.
    /// </summary>
    [MessageContract(WrapperName = "SendRequestResponse", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", IsWrapped = true)]
    public class SendRequestResponseContract
    {
        /// <summary/>
        protected SendRequestResponseContract() { }

        public SendRequestResponseContract(MessageMetadata messageMetadata, XmlElement SMEVSignature)
        {
            MessageMetadata = messageMetadata;
            this.SMEVSignature = SMEVSignature;
        }

        /// <summary>
        /// анные о сообщении: ID, присвоенный СМЭВ, дата приёма по часам СМЭВ, результат маршрутизации, etc.
        /// </summary>
        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", Order = 0)]
        public MessageMetadata MessageMetadata;

        /// <summary>
        /// ЭП-СМЭВ. Подписан элемент //MessageMetadata.
        /// Подпись оставлена необязательной, чтобы клиентов можно было тестировать с упрощёнными эмуляторами СМЭВ.
        /// </summary>
        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", Order = 1)]
        public XmlElement SMEVSignature;
    }
}
