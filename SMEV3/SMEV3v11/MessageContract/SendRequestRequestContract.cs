using System.ServiceModel;
using System.Xml.Serialization;
using System.Xml;
using SMEV3v11.Types;
using SMEV3v11.Types.Basic;

namespace SMEV3v11.MessageContract
{
    /// <summary>
    /// Параметры метода "Послать запрос"
    /// </summary>
    [MessageContract(WrapperName = "SendRequestRequest", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1", IsWrapped = true)]
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
        /// Содержательная часть запроса + служебные данные, заполняемые отправителем
        /// </summary>
        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1", Order = 0)]
        public SenderProvidedRequestData SenderProvidedRequestData;

        /// <summary>
        /// Вложенные файлы - содержимое. Содержимое вынесено из-под ЭП-ОВ, чтобы не нарушать работу MTOM
        /// </summary>
        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.1", Order = 1)]
        [XmlElement("AttachmentContentList", typeof(AttachmentContentList), Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.1")]
        public AttachmentContentType[] AttachmentContentList;

        /// <summary>
        /// ЭП-ОВ или ЭП-ПГУ. Подписан элемент //SenderProvidedRequestData.
        /// Подпись оставлена необязательной, чтобы клиентов можно было тестировать с упрощёнными эмуляторами СМЭВ.
        /// Реальный СМЭВ отбивает сообщения без ЭП-ОВ или ЭП-ПГУ
        /// </summary>
        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1", Order = 2)]
        public XmlElement CallerInformationSystemSignature;
    }
}
