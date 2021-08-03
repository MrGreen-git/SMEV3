using SMEV3v11.Types;
using System.ServiceModel;
using System.Xml;

namespace SMEV3v11.MessageContract
{
    /// <summary>
    /// Возвращаемое значение метода "Послать запрос": запрос принят.
    /// Если запрос не может быть принят, информация о причине отказа передаётся через SOAP fault, см.WSDL-описание сервиса.
    /// </summary>
    [MessageContract(WrapperName = "SendRequestResponse", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1", IsWrapped = true)]
    public class SendRequestResponseContract
    {
        public SendRequestResponseContract(MessageMetadata messageMetadata, XmlElement SMEVSignature)
        {
            MessageMetadata = messageMetadata;
            this.SMEVSignature = SMEVSignature;
        }

        /// <summary>
        /// Данные о сообщении: ID, присвоенный СМЭВ, дата приёма по часам СМЭВ, результат маршрутизации, etc.
        /// </summary>
        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1", Order = 0)]
        public MessageMetadata MessageMetadata;

        /// <summary>
        /// ЭП-СМЭВ. Подписан элемент //MessageMetadata.
        /// Подпись оставлена необязательной, чтобы клиентов можно было тестировать с упрощёнными эмуляторами СМЭВ.
        /// </summary>
        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1", Order = 1)]
        public XmlElement SMEVSignature;
    }
}
