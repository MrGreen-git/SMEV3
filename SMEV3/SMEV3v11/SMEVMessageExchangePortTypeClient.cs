using SMEV3v11.MessageContract;
using SMEV3v11.Types;
using SMEV3v11.Types.Basic;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Xml;

namespace SMEV3v11
{
    public class SMEVMessageExchangePortTypeClient : ClientBase<ISMEVMessageExchangePortType>, ISMEVMessageExchangePortTypeClient
    {
        public SMEVMessageExchangePortTypeClient() { }

        public SMEVMessageExchangePortTypeClient(string endpointConfigurationName) : base(endpointConfigurationName) { }
        
        public SMEVMessageExchangePortTypeClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress) { }

        public SMEVMessageExchangePortTypeClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress) { }
        
        public SMEVMessageExchangePortTypeClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress) { }

        /// <summary>
        ///  Послать запрос.
        /// Факт прихода запроса говорит о том, что СМЭВ удостоверился в том, что отправитель
        /// имеет право на получение данных по этому типу запросов.
        /// Дополнительный контроль доступа в ИС-поставщике данных запрещён.
        /// Тип запроса идентифицируется полным именем (qualified name) элемента //SendRequestRequest/PrimaryContent/element().
        /// </summary>
        /// <param name="senderProvidedRequestData"></param>
        /// <param name="attachmentContentList"></param>
        /// <param name="callerInformationSystemSignature"></param>
        /// <param name="SMEVSignature"></param>
        /// <returns></returns>
        MessageMetadata ISMEVMessageExchangePortTypeClient.SendRequest(SenderProvidedRequestData senderProvidedRequestData, AttachmentContentType[] attachmentContentList, XmlElement callerInformationSystemSignature, out XmlElement SMEVSignature)
        {
            SendRequestRequestContract requestContract = new SendRequestRequestContract(
                senderProvidedRequestData,
                attachmentContentList,
                callerInformationSystemSignature
                );
           
            SendRequestResponseContract responseContract = Channel.SendRequest(requestContract);
            SMEVSignature = responseContract.SMEVSignature;
            return responseContract.MessageMetadata;
        }

        /// <summary>
        /// Дай сообщение из моей входящей очереди, если она не пуста.
        /// </summary>
        /// <param name="senderProvidedResponseData"></param>
        /// <param name="attachmentContentList"></param>
        /// <param name="callerInformationSystemSignature"></param>
        /// <param name="SMEVSignature"></param>
        /// <returns></returns>
        MessageMetadata ISMEVMessageExchangePortTypeClient.SendResponse(SenderProvidedResponseData senderProvidedResponseData, AttachmentContentType[] attachmentContentList, XmlElement callerInformationSystemSignature, out XmlElement SMEVSignature)
        {
            SendResponseRequestContract requestContract = new SendResponseRequestContract(
                senderProvidedResponseData,
                attachmentContentList,
                callerInformationSystemSignature
                );
            
            SendResponseResponseContract responseContract = Channel.SendResponse(requestContract);
            SMEVSignature = responseContract.SMEVSignature;
            return responseContract.MessageMetadata;
        }

        /// <summary>
        /// Дай сообщение из моей входящей очереди _запросов_, если она не пуста.
        /// </summary>
        /// <param name="timestamp"></param>
        /// <param name="callerInformationSystemSignature"></param>
        /// <returns></returns>
        SmevAsyncProcessingMessage ISMEVMessageExchangePortTypeClient.GetStatus(Timestamp timestamp, XmlElement callerInformationSystemSignature)
        {
            GetStatusRequestContract requestContract = new GetStatusRequestContract(
                timestamp,
                callerInformationSystemSignature
                );
            
            GetStatusResponseContract responseContract = Channel.GetStatus(requestContract);
            return responseContract.SmevAsyncProcessingMessage;
        }

        /// <summary>
        /// Дай сообщение из моей входящей очереди _запросов_, если она не пуста.
        /// </summary>
        /// <param name="messageTypeSelector"></param>
        /// <param name="callerInformationSystemSignature"></param>
        /// <returns></returns>
        GetRequestResponseRequestMessage ISMEVMessageExchangePortTypeClient.GetRequest(MessageTypeSelector messageTypeSelector, XmlElement callerInformationSystemSignature)
        {
            GetRequestRequestContract requestContract = new GetRequestRequestContract(
                messageTypeSelector,
                callerInformationSystemSignature
                );
           
            GetRequestResponseContract responseContract = Channel.GetRequest(requestContract);
            return responseContract.RequestMessage;
        }

        /// <summary>
        /// Дай сообщение из моей входящей очереди _ответов_, если она не пуста.
        /// </summary>
        /// <param name="messageTypeSelector"></param>
        /// <param name="callerInformationSystemSignature"></param>
        /// <returns></returns>
        GetResponseResponseResponseMessage ISMEVMessageExchangePortTypeClient.GetResponse(MessageTypeSelector messageTypeSelector, XmlElement callerInformationSystemSignature)
        {
            GetResponseRequestContract requestContract = new GetResponseRequestContract(
                messageTypeSelector,
                callerInformationSystemSignature
                );
            
            GetResponseResponseContract responseContract = Channel.GetResponse(requestContract);
            return responseContract.Item;
        }

        /// <summary>
        /// Подтверждение получения сообщения из очереди.
        /// Должен вызваться после получения сообщения методами GetRequest или GetResponse.
        /// </summary>
        /// <param name="ackTargetMessage"></param>
        /// <param name="callerInformationSystemSignature"></param>
        void ISMEVMessageExchangePortTypeClient.Ack(AckTargetMessage ackTargetMessage, XmlElement callerInformationSystemSignature)
        {
            AckRequestContract requestContract = new AckRequestContract(
                ackTargetMessage,
                callerInformationSystemSignature
                );
            
            AckResponseContract responseContract = Channel.Ack(requestContract);
        }

        /// <summary>
        /// Получение статистики входящих очередей.
        /// </summary>
        /// <param name="nodeID"></param>
        /// <param name="timestamp"></param>
        /// <param name="callerInformationSystemSignature"></param>
        /// <returns></returns>
        QueueStatistics[] ISMEVMessageExchangePortTypeClient.GetIncomingQueueStatistics(string nodeID, Timestamp timestamp, XmlElement callerInformationSystemSignature)
        {
            GetIncomingQueueStatisticsRequestContract requestContract = new GetIncomingQueueStatisticsRequestContract(
                    nodeID,
                    timestamp,
                    callerInformationSystemSignature
                );

            GetIncomingQueueStatisticsResponseContract responseContract = Channel.GetIncomingQueueStatistics(requestContract);
            return responseContract.QueueStatistics;
        }
    }
}
