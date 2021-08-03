using SMEV3v11.Types;
using SMEV3v11.Types.Basic;
using System.Xml;

namespace SMEV3v11
{
    public interface ISMEVMessageExchangePortTypeClient
    {
        MessageMetadata SendRequest(SenderProvidedRequestData SenderProvidedRequestData, AttachmentContentType[] AttachmentContentList, XmlElement CallerInformationSystemSignature, out XmlElement SMEVSignature);

        MessageMetadata SendResponse(SenderProvidedResponseData SenderProvidedResponseData, AttachmentContentType[] AttachmentContentList, XmlElement CallerInformationSystemSignature, out XmlElement SMEVSignature);

        SmevAsyncProcessingMessage GetStatus(Timestamp Timestamp, XmlElement CallerInformationSystemSignature);

        GetRequestResponseRequestMessage GetRequest(MessageTypeSelector MessageTypeSelector, XmlElement CallerInformationSystemSignature);

        GetResponseResponseResponseMessage GetResponse(MessageTypeSelector MessageTypeSelector, XmlElement CallerInformationSystemSignature);

        void Ack(AckTargetMessage AckTargetMessage, XmlElement CallerInformationSystemSignature);

        QueueStatistics[] GetIncomingQueueStatistics(string NodeID, Timestamp Timestamp, XmlElement CallerInformationSystemSignature);
    }
}
