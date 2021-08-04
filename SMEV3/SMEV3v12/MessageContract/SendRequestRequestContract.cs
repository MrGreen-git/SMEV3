using System.ServiceModel;
using System.Xml.Serialization;
using System.Xml;
using SMEV3v12.Types;
using SMEV3v12.Types.Basic;

namespace SMEV3v12.MessageContract
{
    /// <summary>
    /// Параметры метода "Послать запрос"
    /// </summary>
    [MessageContract(WrapperName = "SendRequestRequest", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", IsWrapped = true)]
    public class SendRequestRequestContract
    {
        /// <summary/>
        protected SendRequestRequestContract() { }

        public SendRequestRequestContract(SenderProvidedRequestData senderProvidedRequestData, AttachmentContentType[] attachmentContentList, XmlElement callerInformationSystemSignature)
        {
            SenderProvidedRequestData = senderProvidedRequestData;
            AttachmentContentList = attachmentContentList;
            CallerInformationSystemSignature = callerInformationSystemSignature;
        }

        /// <summary>
        /// Содержательная часть запроса + служебные данные, заполняемые отправителем.
        /// </summary>
        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", Order = 0)]
        public SenderProvidedRequestData SenderProvidedRequestData { get; set; }

        /// <summary>
        /// Вложенные файлы - содержимое. Содержимое вынесено из-под ЭП-ОВ, чтобы не нарушать работу MTOM.
        /// </summary>
        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2", Order = 1)]
        [XmlElement("AttachmentContentType", typeof(AttachmentContentType), Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2")]
        public AttachmentContentType[] AttachmentContentList { get; set; }

        /// <summary>
        /// ЭП-ОВ или ЭП-ПГУ. Подписан элемент //SenderProvidedRequestData.
        /// Подпись оставлена необязательной, чтобы клиентов можно было тестировать с упрощёнными эмуляторами СМЭВ.
        /// Реальный СМЭВ отбивает сообщения без ЭП-ОВ или ЭП-ПГУ.
        /// </summary>
        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", Order = 2)]
        public XmlElement CallerInformationSystemSignature { get; set; }     
    }
}
