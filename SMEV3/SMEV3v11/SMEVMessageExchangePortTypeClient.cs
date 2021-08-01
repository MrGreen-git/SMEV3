using SMEV3v11.MessageContract;
using SMEV3v11.Types;
using SMEV3v11.Types.Basic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ServiceModel;
using System.Text;
using System.Xml;

namespace SMEV3v11
{
    public class SMEVMessageExchangePortTypeClient : ClientBase<ISMEVMessageExchangePortType>, ISMEVMessageExchangePortTypeClient
    {
        public SMEVMessageExchangePortTypeClient() { }

        public SMEVMessageExchangePortTypeClient(string endpointConfigurationName) : base(endpointConfigurationName) { }
        
        public SMEVMessageExchangePortTypeClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress) { }

        public SMEVMessageExchangePortTypeClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress) { }
        
        public SMEVMessageExchangePortTypeClient(System.ServiceModel.Channels.Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress) { }
              

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

        SmevAsyncProcessingMessage ISMEVMessageExchangePortTypeClient.GetStatus(Timestamp timestamp, XmlElement callerInformationSystemSignature)
        {
            GetStatusRequestContract requestContract = new GetStatusRequestContract(
                timestamp,
                callerInformationSystemSignature
                );
            
            GetStatusResponseContract responseContract = Channel.GetStatus(requestContract);
            return responseContract.SmevAsyncProcessingMessage;
        }

        GetRequestResponseRequestMessage ISMEVMessageExchangePortTypeClient.GetRequest(MessageTypeSelector messageTypeSelector, XmlElement callerInformationSystemSignature)
        {
            GetRequestRequestContract requestContract = new GetRequestRequestContract(
                messageTypeSelector,
                callerInformationSystemSignature
                );
           
            GetRequestResponseContract responseContract = Channel.GetRequest(requestContract);
            return responseContract.RequestMessage;
        }

        GetResponseResponseResponseMessage ISMEVMessageExchangePortTypeClient.GetResponse(MessageTypeSelector messageTypeSelector, XmlElement callerInformationSystemSignature)
        {
            GetResponseRequestContract requestContract = new GetResponseRequestContract(
                messageTypeSelector,
                callerInformationSystemSignature
                );
            
            GetResponseResponseContract responseContract = Channel.GetResponse(requestContract);
            return responseContract.Item;
        }

        void ISMEVMessageExchangePortTypeClient.Ack(AckTargetMessage ackTargetMessage, XmlElement callerInformationSystemSignature)
        {
            AckRequestContract requestContract = new AckRequestContract(
                ackTargetMessage,
                callerInformationSystemSignature
                );
            
            AckResponseContract responseContract = Channel.Ack(requestContract);
        }

        public GetIncomingQueueStatisticsResponseQueueStatistics[] GetIncomingQueueStatistics(string nodeID, Timestamp timestamp, XmlElement callerInformationSystemSignature)
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
