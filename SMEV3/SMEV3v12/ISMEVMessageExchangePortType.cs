using SMEV3v12.DataContract;
using SMEV3v12.MessageContract;
using System.ServiceModel;

namespace SMEV3v12
{
    [ServiceContract(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/1.2", ConfigurationName = "SMEV3v12.ISMEVMessageExchangePortType")]
    public interface ISMEVMessageExchangePortType
    {
        [OperationContract(Action = "urn:SendRequest", ReplyAction = "*")]
        [FaultContract(typeof(BusinessDataTypeIsNotSupported), Action = "urn:SendRequest", Name = "BusinessDataTypeIsNotSupported", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
        [FaultContract(typeof(SmevFault), Action = "urn:SendRequest", Name = "TransactionCodeInvalid", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
        [FaultContract(typeof(SignatureVerificationFault), Action = "urn:SendRequest", Name = "SignatureVerificationFault", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
        [FaultContract(typeof(InvalidContent), Action = "urn:SendRequest", Name = "InvalidContent", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
        [FaultContract(typeof(Void), Action = "urn:SendRequest", Name = "AttachmentContentMiscoordination", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
        [FaultContract(typeof(AttachmentSizeLimitExceeded), Action = "urn:SendRequest", Name = "AttachmentSizeLimitExceeded", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
        [FaultContract(typeof(QuoteLimitExceeded), Action = "urn:SendRequest", Name = "QuoteLimitExceeded", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
        [FaultContract(typeof(Void), Action = "urn:SendRequest", Name = "AccessDenied", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
        [FaultContract(typeof(Void), Action = "urn:SendRequest", Name = "SenderIsNotRegistered", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
        [FaultContract(typeof(Void), Action = "urn:SendRequest", Name = "RecipientIsNotFound", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
        [FaultContract(typeof(DestinationOverflow), Action = "urn:SendRequest", Name = "DestinationOverflow", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
        [FaultContract(typeof(Void), Action = "urn:SendRequest", Name = "SMEVFailure", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
        [FaultContract(typeof(Void), Action = "urn:SendRequest", Name = "MessageIsAlreadySent", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
        [FaultContract(typeof(Void), Action = "urn:SendRequest", Name = "InvalidMessageIdFormat", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
        [FaultContract(typeof(Void), Action = "urn:SendRequest", Name = "StaleMessageId", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
        [FaultContract(typeof(Void), Action = "urn:SendRequest", Name = "EndOfLifeReached", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
        [XmlSerializerFormat]
        SendRequestResponseContract SendRequest(SendRequestRequestContract requestContract);


        [OperationContract(Action = "urn:SendResponse", ReplyAction = "*")]
        [FaultContract(typeof(BusinessDataTypeIsNotSupported), Action = "urn:SendResponse", Name = "BusinessDataTypeIsNotSupported", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
        [FaultContract(typeof(SignatureVerificationFault), Action = "urn:SendResponse", Name = "SignatureVerificationFault", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
        [FaultContract(typeof(Void), Action = "urn:SendResponse", Name = "SMEVFailure", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
        [FaultContract(typeof(InvalidContent), Action = "urn:SendResponse", Name = "InvalidContent", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
        [FaultContract(typeof(Void), Action = "urn:SendResponse", Name = "AttachmentContentMiscoordination", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
        [FaultContract(typeof(AttachmentSizeLimitExceeded), Action = "urn:SendResponse", Name = "AttachmentSizeLimitExceeded", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
        [FaultContract(typeof(QuoteLimitExceeded), Action = "urn:SendResponse", Name = "QuoteLimitExceeded", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
        [FaultContract(typeof(Void), Action = "urn:SendResponse", Name = "IncorrectResponseContentType", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
        [FaultContract(typeof(Void), Action = "urn:SendResponse", Name = "SenderIsNotRegistered", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
        [FaultContract(typeof(Void), Action = "urn:SendResponse", Name = "RecipientIsNotFound", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
        [FaultContract(typeof(DestinationOverflow), Action = "urn:SendResponse", Name = "DestinationOverflow", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
        [FaultContract(typeof(Void), Action = "urn:SendResponse", Name = "MessageIsAlreadySent", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
        [FaultContract(typeof(Void), Action = "urn:SendResponse", Name = "InvalidMessageIdFormat", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
        [FaultContract(typeof(Void), Action = "urn:SendResponse", Name = "StaleMessageId", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
        [XmlSerializerFormat]
        SendResponseResponseContract SendResponse(SendResponseRequestContract requestContract);

        
        [OperationContract(Action = "urn:GetStatus", ReplyAction = "*")]
        [FaultContract(typeof(InvalidContent), Action = "urn:GetStatus", Name = "InvalidContent", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
        [FaultContract(typeof(SignatureVerificationFault), Action = "urn:GetStatus", Name = "SignatureVerificationFault", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
        [FaultContract(typeof(Void), Action = "urn:GetStatus", Name = "SenderIsNotRegistered", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
        [FaultContract(typeof(Void), Action = "urn:GetStatus", Name = "UnknownMessageType", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
        [FaultContract(typeof(Void), Action = "urn:GetStatus", Name = "SMEVFailure", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
        [XmlSerializerFormat]
        GetStatusResponseContract GetStatus(GetStatusRequestContract requestContract);

        
        [OperationContract(Action = "urn:GetRequest", ReplyAction = "*")]
        [FaultContract(typeof(InvalidContent), Action = "urn:GetRequest", Name = "InvalidContent", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
        [FaultContract(typeof(SignatureVerificationFault), Action = "urn:GetRequest", Name = "SignatureVerificationFault", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
        [FaultContract(typeof(Void), Action = "urn:GetRequest", Name = "SenderIsNotRegistered", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
        [FaultContract(typeof(Void), Action = "urn:GetRequest", Name = "UnknownMessageType", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
        [FaultContract(typeof(Void), Action = "urn:GetRequest", Name = "SMEVFailure", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
        [XmlSerializerFormat]
        GetRequestResponseContract GetRequest(GetRequestRequestContract requestContract);

        
        [OperationContract(Action = "urn:GetResponse", ReplyAction = "*")]
        [FaultContract(typeof(InvalidContent), Action = "urn:GetResponse", Name = "InvalidContent", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
        [FaultContract(typeof(SignatureVerificationFault), Action = "urn:GetResponse", Name = "SignatureVerificationFault", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
        [FaultContract(typeof(Void), Action = "urn:GetResponse", Name = "SenderIsNotRegistered", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
        [FaultContract(typeof(Void), Action = "urn:GetResponse", Name = "UnknownMessageType", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
        [FaultContract(typeof(Void), Action = "urn:GetResponse", Name = "SMEVFailure", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
        [XmlSerializerFormat]
        GetResponseResponseContract GetResponse(GetResponseRequestContract requestContract);

        
        [OperationContract(Action = "urn:Ack", ReplyAction = "*")]
        [FaultContract(typeof(InvalidContent), Action = "urn:Ack", Name = "InvalidContent", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
        [FaultContract(typeof(SignatureVerificationFault), Action = "urn:Ack", Name = "SignatureVerificationFault", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
        [FaultContract(typeof(Void), Action = "urn:Ack", Name = "SenderIsNotRegistered", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
        [FaultContract(typeof(Void), Action = "urn:Ack", Name = "SMEVFailure", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
        [FaultContract(typeof(Void), Action = "urn:Ack", Name = "TargetMessageIsNotFound", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
        [XmlSerializerFormat]
        AckResponseContract Ack(AckRequestContract requestContract);      
    }
}
