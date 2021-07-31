using SMEV3v13.MessageContract;
using SMEV3v13.Types.Basic;
using SMEV3v13.Types.Routing;
using SMEV3v13.Types;
using System.ServiceModel;
using System.Xml;
using System.ServiceModel.Channels;

namespace SMEV3v13
{
    public class SMEVMessageExchangePortTypeClient : ClientBase<ISMEVMessageExchangePortType>, ISMEVMessageExchangePortTypeClient
    {
        public SMEVMessageExchangePortTypeClient() { }

        public SMEVMessageExchangePortTypeClient(string endpointConfigurationName) : base(endpointConfigurationName) { }

        public SMEVMessageExchangePortTypeClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress) { }

        public SMEVMessageExchangePortTypeClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress) { }

        public SMEVMessageExchangePortTypeClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress) { }
        
        MessageMetadata ISMEVMessageExchangePortTypeClient.SendRequest(SenderProvidedRequestData senderProvidedRequestData, AttachmentContentType[] attachmentContentList, XmlElement callerInformationSystemSignature, Routing routing, out XmlElement SMEVSignature)
        {
            SendRequestRequestContract requestContract = new SendRequestRequestContract(
                senderProvidedRequestData,
                attachmentContentList,
                callerInformationSystemSignature,
                routing
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

            Channel.Ack(requestContract);
        }
    }
}
