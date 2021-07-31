using SMEV3v13.Types.Basic;
using SMEV3v13.Types.Routing;
using SMEV3v13.Types;
using System.Xml;

namespace SMEV3v13
{
    public interface ISMEVMessageExchangePortTypeClient
    {
        MessageMetadata SendRequest(SenderProvidedRequestData SenderProvidedRequestData, AttachmentContentType[] AttachmentContentList, XmlElement CallerInformationSystemSignature, Routing Routing, out XmlElement SMEVSignature);

        MessageMetadata SendResponse(SenderProvidedResponseData SenderProvidedResponseData, AttachmentContentType[] AttachmentContentList, XmlElement CallerInformationSystemSignature, out XmlElement SMEVSignature);

        SmevAsyncProcessingMessage GetStatus(Timestamp Timestamp, XmlElement CallerInformationSystemSignature);

        GetRequestResponseRequestMessage GetRequest(MessageTypeSelector MessageTypeSelector, XmlElement CallerInformationSystemSignature);

        GetResponseResponseResponseMessage GetResponse(MessageTypeSelector MessageTypeSelector, XmlElement CallerInformationSystemSignature);

        void Ack(AckTargetMessage AckTargetMessage, XmlElement CallerInformationSystemSignature);
    }
}
