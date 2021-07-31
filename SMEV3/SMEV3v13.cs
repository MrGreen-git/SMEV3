using System.ServiceModel;
using System;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using SMEV3v13.Types;
using SMEV3v13.Types.Basic;

[assembly: ContractNamespace("urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3", ClrNamespace="xartefactssmevgovru.services.messageexchange.types.basic._1._31")]
[assembly: ContractNamespace("urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3", ClrNamespace="xartefactssmevgovru.services.messageexchange.types.faults._1._31")]



[ServiceContract(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/1.3", ConfigurationName="SMEVMessageExchangePortType")]
public interface SMEVMessageExchangePortType
{
    
    [OperationContract(Action="urn:SendRequest", ReplyAction="*")]
    [FaultContract(typeof(xartefactssmevgovru.services.messageexchange.types.faults._1._31.BusinessDataTypeIsNotSupported), Action="urn:SendRequest", Name="BusinessDataTypeIsNotSupported", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    [FaultContract(typeof(xartefactssmevgovru.services.messageexchange.types.basic._1._31.SmevFault), Action="urn:SendRequest", Name="TransactionCodeInvalid", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    [FaultContract(typeof(xartefactssmevgovru.services.messageexchange.types.faults._1._31.SignatureVerificationFault), Action="urn:SendRequest", Name="SignatureVerificationFault", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    [FaultContract(typeof(xartefactssmevgovru.services.messageexchange.types.faults._1._31.InvalidContent), Action="urn:SendRequest", Name="InvalidContent", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    [FaultContract(typeof(xartefactssmevgovru.services.messageexchange.types.basic._1._31.Void), Action="urn:SendRequest", Name="AttachmentContentMiscoordination", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    [FaultContract(typeof(xartefactssmevgovru.services.messageexchange.types.faults._1._31.AttachmentSizeLimitExceeded), Action="urn:SendRequest", Name="AttachmentSizeLimitExceeded", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    [FaultContract(typeof(xartefactssmevgovru.services.messageexchange.types.faults._1._31.QuoteLimitExceeded), Action="urn:SendRequest", Name="QuoteLimitExceeded", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    [FaultContract(typeof(xartefactssmevgovru.services.messageexchange.types.basic._1._31.Void), Action="urn:SendRequest", Name="AccessDenied", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    [FaultContract(typeof(xartefactssmevgovru.services.messageexchange.types.basic._1._31.SmevFault), Action="urn:SendRequest", Name="PersonalAccessDenied", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    [FaultContract(typeof(xartefactssmevgovru.services.messageexchange.types.basic._1._31.Void), Action="urn:SendRequest", Name="SenderIsNotRegistered", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    [FaultContract(typeof(xartefactssmevgovru.services.messageexchange.types.basic._1._31.Void), Action="urn:SendRequest", Name="RecipientIsNotFound", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    [FaultContract(typeof(xartefactssmevgovru.services.messageexchange.types.faults._1._31.DestinationOverflow), Action="urn:SendRequest", Name="DestinationOverflow", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    [FaultContract(typeof(xartefactssmevgovru.services.messageexchange.types.basic._1._31.Void), Action="urn:SendRequest", Name="SMEVFailure", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    [FaultContract(typeof(xartefactssmevgovru.services.messageexchange.types.basic._1._31.Void), Action="urn:SendRequest", Name="MessageIsAlreadySent", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    [FaultContract(typeof(xartefactssmevgovru.services.messageexchange.types.basic._1._31.Void), Action="urn:SendRequest", Name="InvalidMessageIdFormat", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    [FaultContract(typeof(xartefactssmevgovru.services.messageexchange.types.basic._1._31.Void), Action="urn:SendRequest", Name="StaleMessageId", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    [FaultContract(typeof(xartefactssmevgovru.services.messageexchange.types.basic._1._31.SmevFault), Action="urn:SendRequest", Name="EndOfLifeReached", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    [XmlSerializerFormat()]
    SendRequestResponse SendRequest(SendRequestRequest request);
    
    // CODEGEN: Идет формирование контракта на сообщение, так как операция может иметь много возвращаемых значений.
    [OperationContract(Action="urn:SendRequest", ReplyAction="*")]
    System.Threading.Tasks.Task<SendRequestResponse> SendRequestAsync(SendRequestRequest request);
    
    [OperationContract(Action="urn:SendResponse", ReplyAction="*")]
    [FaultContract(typeof(xartefactssmevgovru.services.messageexchange.types.faults._1._31.BusinessDataTypeIsNotSupported), Action="urn:SendResponse", Name="BusinessDataTypeIsNotSupported", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    [FaultContract(typeof(xartefactssmevgovru.services.messageexchange.types.faults._1._31.SignatureVerificationFault), Action="urn:SendResponse", Name="SignatureVerificationFault", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    [FaultContract(typeof(xartefactssmevgovru.services.messageexchange.types.basic._1._31.Void), Action="urn:SendResponse", Name="SMEVFailure", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    [FaultContract(typeof(xartefactssmevgovru.services.messageexchange.types.faults._1._31.InvalidContent), Action="urn:SendResponse", Name="InvalidContent", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    [FaultContract(typeof(xartefactssmevgovru.services.messageexchange.types.basic._1._31.Void), Action="urn:SendResponse", Name="AttachmentContentMiscoordination", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    [FaultContract(typeof(xartefactssmevgovru.services.messageexchange.types.faults._1._31.AttachmentSizeLimitExceeded), Action="urn:SendResponse", Name="AttachmentSizeLimitExceeded", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    [FaultContract(typeof(xartefactssmevgovru.services.messageexchange.types.faults._1._31.QuoteLimitExceeded), Action="urn:SendResponse", Name="QuoteLimitExceeded", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    [FaultContract(typeof(xartefactssmevgovru.services.messageexchange.types.basic._1._31.Void), Action="urn:SendResponse", Name="IncorrectResponseContentType", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    [FaultContract(typeof(xartefactssmevgovru.services.messageexchange.types.basic._1._31.Void), Action="urn:SendResponse", Name="SenderIsNotRegistered", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    [FaultContract(typeof(xartefactssmevgovru.services.messageexchange.types.basic._1._31.Void), Action="urn:SendResponse", Name="RecipientIsNotFound", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    [FaultContract(typeof(xartefactssmevgovru.services.messageexchange.types.faults._1._31.DestinationOverflow), Action="urn:SendResponse", Name="DestinationOverflow", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    [FaultContract(typeof(xartefactssmevgovru.services.messageexchange.types.basic._1._31.Void), Action="urn:SendResponse", Name="MessageIsAlreadySent", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    [FaultContract(typeof(xartefactssmevgovru.services.messageexchange.types.basic._1._31.Void), Action="urn:SendResponse", Name="InvalidMessageIdFormat", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    [FaultContract(typeof(xartefactssmevgovru.services.messageexchange.types.basic._1._31.Void), Action="urn:SendResponse", Name="StaleMessageId", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    [XmlSerializerFormat()]
    SendResponseResponse SendResponse(SendResponseRequest request);
    
    // CODEGEN: Идет формирование контракта на сообщение, так как операция может иметь много возвращаемых значений.
    [OperationContract(Action="urn:SendResponse", ReplyAction="*")]
    System.Threading.Tasks.Task<SendResponseResponse> SendResponseAsync(SendResponseRequest request);
    
    // CODEGEN: Контракт генерации сообщений с пространством имен упаковщика (urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3) сообщения GetStatusRequest не соответствует значению по умолчанию (urn://x-artefacts-smev-gov-ru/services/message-exchange/1.3).
    [OperationContract(Action="urn:GetStatus", ReplyAction="*")]
    [FaultContract(typeof(xartefactssmevgovru.services.messageexchange.types.faults._1._31.InvalidContent), Action="urn:GetStatus", Name="InvalidContent", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    [FaultContract(typeof(xartefactssmevgovru.services.messageexchange.types.faults._1._31.SignatureVerificationFault), Action="urn:GetStatus", Name="SignatureVerificationFault", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    [FaultContract(typeof(xartefactssmevgovru.services.messageexchange.types.basic._1._31.Void), Action="urn:GetStatus", Name="SenderIsNotRegistered", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    [FaultContract(typeof(xartefactssmevgovru.services.messageexchange.types.basic._1._31.Void), Action="urn:GetStatus", Name="UnknownMessageType", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    [FaultContract(typeof(xartefactssmevgovru.services.messageexchange.types.basic._1._31.Void), Action="urn:GetStatus", Name="SMEVFailure", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    [XmlSerializerFormat()]
    GetStatusResponse GetStatus(GetStatusRequest request);
    
    [OperationContract(Action="urn:GetStatus", ReplyAction="*")]
    System.Threading.Tasks.Task<GetStatusResponse> GetStatusAsync(GetStatusRequest request);
    
    // CODEGEN: Контракт генерации сообщений с пространством имен упаковщика (urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3) сообщения GetRequestRequest не соответствует значению по умолчанию (urn://x-artefacts-smev-gov-ru/services/message-exchange/1.3).
    [OperationContract(Action="urn:GetRequest", ReplyAction="*")]
    [FaultContract(typeof(xartefactssmevgovru.services.messageexchange.types.faults._1._31.InvalidContent), Action="urn:GetRequest", Name="InvalidContent", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    [FaultContract(typeof(xartefactssmevgovru.services.messageexchange.types.faults._1._31.SignatureVerificationFault), Action="urn:GetRequest", Name="SignatureVerificationFault", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    [FaultContract(typeof(xartefactssmevgovru.services.messageexchange.types.basic._1._31.Void), Action="urn:GetRequest", Name="SenderIsNotRegistered", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    [FaultContract(typeof(xartefactssmevgovru.services.messageexchange.types.basic._1._31.Void), Action="urn:GetRequest", Name="UnknownMessageType", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    [FaultContract(typeof(xartefactssmevgovru.services.messageexchange.types.basic._1._31.Void), Action="urn:GetRequest", Name="SMEVFailure", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    [XmlSerializerFormat()]
    GetRequestResponse GetRequest(GetRequestRequest request);
    
    [OperationContract(Action="urn:GetRequest", ReplyAction="*")]
    System.Threading.Tasks.Task<GetRequestResponse> GetRequestAsync(GetRequestRequest request);
    
    // CODEGEN: Контракт генерации сообщений с пространством имен упаковщика (urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3) сообщения GetResponseRequest не соответствует значению по умолчанию (urn://x-artefacts-smev-gov-ru/services/message-exchange/1.3).
    [OperationContract(Action="urn:GetResponse", ReplyAction="*")]
    [FaultContract(typeof(xartefactssmevgovru.services.messageexchange.types.faults._1._31.InvalidContent), Action="urn:GetResponse", Name="InvalidContent", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    [FaultContract(typeof(xartefactssmevgovru.services.messageexchange.types.faults._1._31.SignatureVerificationFault), Action="urn:GetResponse", Name="SignatureVerificationFault", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    [FaultContract(typeof(xartefactssmevgovru.services.messageexchange.types.basic._1._31.Void), Action="urn:GetResponse", Name="SenderIsNotRegistered", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    [FaultContract(typeof(xartefactssmevgovru.services.messageexchange.types.basic._1._31.Void), Action="urn:GetResponse", Name="UnknownMessageType", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    [FaultContract(typeof(xartefactssmevgovru.services.messageexchange.types.basic._1._31.Void), Action="urn:GetResponse", Name="SMEVFailure", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    [XmlSerializerFormat()]
    GetResponseResponse GetResponse(GetResponseRequest request);
    
    [OperationContract(Action="urn:GetResponse", ReplyAction="*")]
    System.Threading.Tasks.Task<GetResponseResponse> GetResponseAsync(GetResponseRequest request);
    
    // CODEGEN: Контракт генерации сообщений с пространством имен упаковщика (urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3) сообщения AckRequest не соответствует значению по умолчанию (urn://x-artefacts-smev-gov-ru/services/message-exchange/1.3).
    [OperationContract(Action="urn:Ack", ReplyAction="*")]
    [FaultContract(typeof(xartefactssmevgovru.services.messageexchange.types.faults._1._31.InvalidContent), Action="urn:Ack", Name="InvalidContent", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    [FaultContract(typeof(xartefactssmevgovru.services.messageexchange.types.faults._1._31.SignatureVerificationFault), Action="urn:Ack", Name="SignatureVerificationFault", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    [FaultContract(typeof(xartefactssmevgovru.services.messageexchange.types.basic._1._31.Void), Action="urn:Ack", Name="SenderIsNotRegistered", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    [FaultContract(typeof(xartefactssmevgovru.services.messageexchange.types.basic._1._31.Void), Action="urn:Ack", Name="SMEVFailure", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    [FaultContract(typeof(xartefactssmevgovru.services.messageexchange.types.basic._1._31.Void), Action="urn:Ack", Name="TargetMessageIsNotFound", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    [XmlSerializerFormat()]
    AckResponse Ack(AckRequest request);
    
    [OperationContract(Action="urn:Ack", ReplyAction="*")]
    System.Threading.Tasks.Task<AckResponse> AckAsync(AckRequest request);
}



 




 



 
[Serializable]
[XmlType(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3")]
public class RefAttachmentHeaderType
{
    [XmlElement(Order = 0)]
    public string uuid { get; set; }

    [XmlElement(Order = 1)]
    public string FileName { get; set; }

    [XmlElement(Order = 2)]
    public string NamespaceUri { get; set; }

    [XmlElement(Order = 3)]
    public string Hash { get; set; }

    [XmlElement(Order = 4)]
    public string MimeType { get; set; }

    [XmlElement(DataType = "base64Binary", Order = 5)]
    public byte[] SignaturePKCS7 { get; set; }

    [XmlArray(Order = 6)]
    [XmlArrayItem("File", IsNullable = false)]
    public FileType[] Archive { get; set; }
}

[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3")]
public class RefAttachmentHeaderList
{
    
    private RefAttachmentHeaderType[] refAttachmentHeaderField;
    
    
    [XmlElement("RefAttachmentHeader", Order=0)]
    public RefAttachmentHeaderType[] RefAttachmentHeader
    {
        get
        {
            return this.refAttachmentHeaderField;
        }
        set
        {
            this.refAttachmentHeaderField = value;
        }
    }
}


 
[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3")]
public class SenderProvidedRequestDataBusinessProcessMetadata
{
    
    private System.Xml.XmlElement[] anyField;
    
    
    [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
    public System.Xml.XmlElement[] Any
    {
        get
        {
            return this.anyField;
        }
        set
        {
            this.anyField = value;
        }
    }
}


 
[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3")]
public class AttachmentContentList
{
    
    private AttachmentContentType[] attachmentContentField;
    
    
    [XmlElement("AttachmentContent", Order=0)]
    public AttachmentContentType[] AttachmentContent
    {
        get
        {
            return this.attachmentContentField;
        }
        set
        {
            this.attachmentContentField = value;
        }
    }
}


 
[Serializable]
[XmlType(AnonymousType=true, Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/routing/1.3")]
public class Routing
{
    
    private RoutingInformation routingInformationField;
    
    private System.Xml.XmlElement routingSignatureField;
    
    
    [XmlElement(Order=0)]
    public RoutingInformation RoutingInformation
    {
        get
        {
            return this.routingInformationField;
        }
        set
        {
            this.routingInformationField = value;
        }
    }
    
    
    [XmlElement(Order=1)]
    public System.Xml.XmlElement RoutingSignature
    {
        get
        {
            return this.routingSignatureField;
        }
        set
        {
            this.routingSignatureField = value;
        }
    }
}


 
[Serializable]


[XmlType(AnonymousType=true, Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/routing/1.3")]
public class RoutingInformation
{
    
    private string messageIDField;
    
    private string[] dynamicRoutingField;
    
    private string[] identifierRoutingField;
    
    private RegistryRecordRouting[] registryRoutingField;
    
    private string idField;
    
    
    [XmlElement(Order=0)]
    public string MessageID
    {
        get
        {
            return this.messageIDField;
        }
        set
        {
            this.messageIDField = value;
        }
    }
    
    
    [System.Xml.Serialization.XmlArrayAttribute(Order=1)]
    [System.Xml.Serialization.XmlArrayItemAttribute("DynamicValue", IsNullable=false)]
    public string[] DynamicRouting
    {
        get
        {
            return this.dynamicRoutingField;
        }
        set
        {
            this.dynamicRoutingField = value;
        }
    }
    
    
    [System.Xml.Serialization.XmlArrayAttribute(Order=2)]
    [System.Xml.Serialization.XmlArrayItemAttribute("IdentifierValue", IsNullable=false)]
    public string[] IdentifierRouting
    {
        get
        {
            return this.identifierRoutingField;
        }
        set
        {
            this.identifierRoutingField = value;
        }
    }
    
    
    [System.Xml.Serialization.XmlArrayAttribute(Order=3)]
    [System.Xml.Serialization.XmlArrayItemAttribute("RegistryRecordRouting", IsNullable=false)]
    public RegistryRecordRouting[] RegistryRouting
    {
        get
        {
            return this.registryRoutingField;
        }
        set
        {
            this.registryRoutingField = value;
        }
    }
    
    
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
    public string Id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}


 
[Serializable]


[XmlType(AnonymousType=true, Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/routing/1.3")]
public class RegistryRecordRouting
{
    
    private int recordIdField;
    
    private bool useGeneralRoutingField;
    
    private string[] dynamicRoutingField;
    
    private string[] identifierRoutingField;
    
    
    [XmlElement(Order=0)]
    public int RecordId
    {
        get
        {
            return this.recordIdField;
        }
        set
        {
            this.recordIdField = value;
        }
    }
    
    
    [XmlElement(Order=1)]
    public bool UseGeneralRouting
    {
        get
        {
            return this.useGeneralRoutingField;
        }
        set
        {
            this.useGeneralRoutingField = value;
        }
    }
    
    
    [System.Xml.Serialization.XmlArrayAttribute(Order=2)]
    [System.Xml.Serialization.XmlArrayItemAttribute("DynamicValue", IsNullable=false)]
    public string[] DynamicRouting
    {
        get
        {
            return this.dynamicRoutingField;
        }
        set
        {
            this.dynamicRoutingField = value;
        }
    }
    
    
    [System.Xml.Serialization.XmlArrayAttribute(Order=3)]
    [System.Xml.Serialization.XmlArrayItemAttribute("IdentifierValue", IsNullable=false)]
    public string[] IdentifierRouting
    {
        get
        {
            return this.identifierRoutingField;
        }
        set
        {
            this.identifierRoutingField = value;
        }
    }
}


 
[Serializable]


[XmlType(AnonymousType=true, Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3")]
public class MessageMetadata
{
    
    private string messageIdField;
    
    private MessageTypeType messageTypeField;
    
    private MessageMetadataSender senderField;
    
    private System.DateTime sendingTimestampField;
    
    private MessageMetadataRecipient recipientField;
    
    private System.DateTime deliveryTimestampField;
    
    private bool deliveryTimestampFieldSpecified;
    
    private InteractionStatusType statusField;
    
    private bool statusFieldSpecified;
    
    private string idField;
    
    
    [XmlElement(Order=0)]
    public string MessageId
    {
        get
        {
            return this.messageIdField;
        }
        set
        {
            this.messageIdField = value;
        }
    }
    
    
    [XmlElement(Order=1)]
    public MessageTypeType MessageType
    {
        get
        {
            return this.messageTypeField;
        }
        set
        {
            this.messageTypeField = value;
        }
    }
    
    
    [XmlElement(Order=2)]
    public MessageMetadataSender Sender
    {
        get
        {
            return this.senderField;
        }
        set
        {
            this.senderField = value;
        }
    }
    
    
    [XmlElement(Order=3)]
    public System.DateTime SendingTimestamp
    {
        get
        {
            return this.sendingTimestampField;
        }
        set
        {
            this.sendingTimestampField = value;
        }
    }
    
    
    [XmlElement(Order=4)]
    public MessageMetadataRecipient Recipient
    {
        get
        {
            return this.recipientField;
        }
        set
        {
            this.recipientField = value;
        }
    }
    
    
    [XmlElement(Order=5)]
    public System.DateTime DeliveryTimestamp
    {
        get
        {
            return this.deliveryTimestampField;
        }
        set
        {
            this.deliveryTimestampField = value;
        }
    }
    
    
    [XmlIgnore]
    public bool DeliveryTimestampSpecified
    {
        get
        {
            return this.deliveryTimestampFieldSpecified;
        }
        set
        {
            this.deliveryTimestampFieldSpecified = value;
        }
    }
    
    
    [XmlElement(Order=6)]
    public InteractionStatusType Status
    {
        get
        {
            return this.statusField;
        }
        set
        {
            this.statusField = value;
        }
    }
    
    
    [XmlIgnore]
    public bool StatusSpecified
    {
        get
        {
            return this.statusFieldSpecified;
        }
        set
        {
            this.statusFieldSpecified = value;
        }
    }
    
    
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
    public string Id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}


 
[Serializable]
[XmlType(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3")]
public enum MessageTypeType
{
    
    
    REQUEST,
    
    
    BROADCAST,
    
    
    RESPONSE,
}


 
[Serializable]


[XmlType(AnonymousType=true, Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3")]
public class MessageMetadataSender
{
    
    private string mnemonicField;
    
    private string humanReadableNameField;
    
    
    [XmlElement(Order=0)]
    public string Mnemonic
    {
        get
        {
            return this.mnemonicField;
        }
        set
        {
            this.mnemonicField = value;
        }
    }
    
    
    [XmlElement(Order=1)]
    public string HumanReadableName
    {
        get
        {
            return this.humanReadableNameField;
        }
        set
        {
            this.humanReadableNameField = value;
        }
    }
}


 
[Serializable]


[XmlType(AnonymousType=true, Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3")]
public class MessageMetadataRecipient
{
    
    private string mnemonicField;
    
    private string humanReadableNameField;
    
    
    [XmlElement(Order=0)]
    public string Mnemonic
    {
        get
        {
            return this.mnemonicField;
        }
        set
        {
            this.mnemonicField = value;
        }
    }
    
    
    [XmlElement(Order=1)]
    public string HumanReadableName
    {
        get
        {
            return this.humanReadableNameField;
        }
        set
        {
            this.humanReadableNameField = value;
        }
    }
}


 
[Serializable]
[XmlType(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3")]
public enum InteractionStatusType
{
    
    
    doesNotExist,
    
    
    requestIsQueued,
    
    
    requestIsAcceptedBySmev,
    
    
    requestIsRejectedBySmev,
    
    
    requestIsProcessed,
    
    
    underProcessing,
    
    
    responseIsQueued,
    
    
    responseIsAcceptedBySmev,
    
    
    responseIsRejectedBySmev,
    
    
    responseIsProcessed,
    
    
    cancelled,
    
    
    messageIsArchived,
    
    
    messageIsDelivered,
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.MessageContractAttribute(WrapperName="SendRequestRequest", WrapperNamespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3", IsWrapped=true)]
public class SendRequestRequest
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3", Order=0)]
    public SenderProvidedRequestData SenderProvidedRequestData;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3", Order=1)]
    [XmlElement("AttachmentContentList", typeof(AttachmentContentList), Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3")]
    public AttachmentContentType[] AttachmentContentList;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3", Order=2)]
    public System.Xml.XmlElement CallerInformationSystemSignature;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/routing/1.3", Order=3)]
    [XmlElement(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/routing/1.3")]
    public Routing Routing;
    
    public SendRequestRequest()
    {
    }
    
    public SendRequestRequest(SenderProvidedRequestData SenderProvidedRequestData, AttachmentContentType[] AttachmentContentList, System.Xml.XmlElement CallerInformationSystemSignature, Routing Routing)
    {
        this.SenderProvidedRequestData = SenderProvidedRequestData;
        this.AttachmentContentList = AttachmentContentList;
        this.CallerInformationSystemSignature = CallerInformationSystemSignature;
        this.Routing = Routing;
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.MessageContractAttribute(WrapperName="SendRequestResponse", WrapperNamespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3", IsWrapped=true)]
public class SendRequestResponse
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3", Order=0)]
    public MessageMetadata MessageMetadata;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3", Order=1)]
    public System.Xml.XmlElement SMEVSignature;
    
    public SendRequestResponse()
    {
    }
    
    public SendRequestResponse(MessageMetadata MessageMetadata, System.Xml.XmlElement SMEVSignature)
    {
        this.MessageMetadata = MessageMetadata;
        this.SMEVSignature = SMEVSignature;
    }
}


 
[Serializable]


[XmlType(AnonymousType=true, Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3")]
public class SenderProvidedResponseData
{
    
    private string messageIDField;
    
    private string toField;
    
    private object[] itemsField;
    
    private ItemsChoiceType[] itemsElementNameField;
    
    private string idField;
    
    
    [XmlElement(Order=0)]
    public string MessageID
    {
        get
        {
            return this.messageIDField;
        }
        set
        {
            this.messageIDField = value;
        }
    }
    
    
    [XmlElement(Order=1)]
    public string To
    {
        get
        {
            return this.toField;
        }
        set
        {
            this.toField = value;
        }
    }
    
    
    [XmlElement("AsyncProcessingStatus", typeof(AsyncProcessingStatus), Order=2)]
    [XmlElement("PersonalSignature", typeof(System.Xml.XmlElement), Order=2)]
    [XmlElement("RequestRejected", typeof(SenderProvidedResponseDataRequestRejected), Order=2)]
    [XmlElement("RequestStatus", typeof(SenderProvidedResponseDataRequestStatus), Order=2)]
    [XmlElement("AttachmentHeaderList", typeof(AttachmentHeaderList), Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3", Order=2)]
    [XmlElement("MessagePrimaryContent", typeof(System.Xml.XmlElement), Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3", Order=2)]
    [XmlElement("RefAttachmentHeaderList", typeof(RefAttachmentHeaderList), Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3", Order=2)]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
    public object[] Items
    {
        get
        {
            return this.itemsField;
        }
        set
        {
            this.itemsField = value;
        }
    }
    
    
    [XmlElement("ItemsElementName", Order=3)]
    [XmlIgnore]
    public ItemsChoiceType[] ItemsElementName
    {
        get
        {
            return this.itemsElementNameField;
        }
        set
        {
            this.itemsElementNameField = value;
        }
    }
    
    
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
    public string Id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}


 
[Serializable]


[XmlType(AnonymousType=true, Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3")]
public class AsyncProcessingStatus
{
    
    private string originalMessageIdField;
    
    private InteractionStatusType statusCategoryField;
    
    private string statusDetailsField;
    
    private RoutingStatus routingStatusField;
    
    private SmevFault smevFaultField;
    
    
    [XmlElement(Order=0)]
    public string OriginalMessageId
    {
        get
        {
            return this.originalMessageIdField;
        }
        set
        {
            this.originalMessageIdField = value;
        }
    }
    
    
    [XmlElement(Order=1)]
    public InteractionStatusType StatusCategory
    {
        get
        {
            return this.statusCategoryField;
        }
        set
        {
            this.statusCategoryField = value;
        }
    }
    
    
    [XmlElement(Order=2)]
    public string StatusDetails
    {
        get
        {
            return this.statusDetailsField;
        }
        set
        {
            this.statusDetailsField = value;
        }
    }
    
    
    [XmlElement(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/routing/1.3", Order=3)]
    public RoutingStatus RoutingStatus
    {
        get
        {
            return this.routingStatusField;
        }
        set
        {
            this.routingStatusField = value;
        }
    }
    
    
    [XmlElement(Order=4)]
    public SmevFault SmevFault
    {
        get
        {
            return this.smevFaultField;
        }
        set
        {
            this.smevFaultField = value;
        }
    }
}


 
[Serializable]


[XmlType(AnonymousType=true, Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/routing/1.3")]
public class RoutingStatus
{
    
    private DynamicRoutingStatus[] dynamicRoutingStatusField;
    
    private IdentifierRoutingStatus[] identifierRoutingStatusField;
    
    private RegistryRoutingStatus[] registryRoutingStatusField;
    
    
    [XmlElement("DynamicRoutingStatus", Order=0)]
    public DynamicRoutingStatus[] DynamicRoutingStatus
    {
        get
        {
            return this.dynamicRoutingStatusField;
        }
        set
        {
            this.dynamicRoutingStatusField = value;
        }
    }
    
    
    [XmlElement("IdentifierRoutingStatus", Order=1)]
    public IdentifierRoutingStatus[] IdentifierRoutingStatus
    {
        get
        {
            return this.identifierRoutingStatusField;
        }
        set
        {
            this.identifierRoutingStatusField = value;
        }
    }
    
    
    [XmlElement("RegistryRoutingStatus", Order=2)]
    public RegistryRoutingStatus[] RegistryRoutingStatus
    {
        get
        {
            return this.registryRoutingStatusField;
        }
        set
        {
            this.registryRoutingStatusField = value;
        }
    }
}


 
[Serializable]


[XmlType(AnonymousType=true, Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/routing/1.3")]
public class DynamicRoutingStatus
{
    
    private string dynamicValueField;
    
    private RoutingStatusCodeType routingStatusCodeField;
    
    
    [XmlElement(Order=0)]
    public string DynamicValue
    {
        get
        {
            return this.dynamicValueField;
        }
        set
        {
            this.dynamicValueField = value;
        }
    }
    
    
    [XmlElement(Order=1)]
    public RoutingStatusCodeType RoutingStatusCode
    {
        get
        {
            return this.routingStatusCodeField;
        }
        set
        {
            this.routingStatusCodeField = value;
        }
    }
}


 
[Serializable]
[XmlType(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/routing/1.3")]
public enum RoutingStatusCodeType
{
    
    
    success,
    
    
    recipientNotFound,
    
    
    invalidRegistryRecordId,
    
    
    certificateInvalid,
    
    
    signatureInvalid,
    
    
    generalRoutingNotFound,
    
    
    personalAccessDenied,
}


 
[Serializable]


[XmlType(AnonymousType=true, Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/routing/1.3")]
public class IdentifierRoutingStatus
{
    
    private string identifierValueField;
    
    private RoutingStatusCodeType routingStatusCodeField;
    
    
    [XmlElement(Order=0)]
    public string IdentifierValue
    {
        get
        {
            return this.identifierValueField;
        }
        set
        {
            this.identifierValueField = value;
        }
    }
    
    
    [XmlElement(Order=1)]
    public RoutingStatusCodeType RoutingStatusCode
    {
        get
        {
            return this.routingStatusCodeField;
        }
        set
        {
            this.routingStatusCodeField = value;
        }
    }
}


 
[Serializable]


[XmlType(AnonymousType=true, Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/routing/1.3")]
public class RegistryRoutingStatus
{
    
    private int recordIdField;
    
    private RoutingStatusCodeType routingStatusCodeField;
    
    private DynamicRoutingStatus[] dynamicRoutingStatusField;
    
    private IdentifierRoutingStatus[] identifierRoutingStatusField;
    
    
    [XmlElement(Order=0)]
    public int RecordId
    {
        get
        {
            return this.recordIdField;
        }
        set
        {
            this.recordIdField = value;
        }
    }
    
    
    [XmlElement(Order=1)]
    public RoutingStatusCodeType RoutingStatusCode
    {
        get
        {
            return this.routingStatusCodeField;
        }
        set
        {
            this.routingStatusCodeField = value;
        }
    }
    
    
    [XmlElement("DynamicRoutingStatus", Order=2)]
    public DynamicRoutingStatus[] DynamicRoutingStatus
    {
        get
        {
            return this.dynamicRoutingStatusField;
        }
        set
        {
            this.dynamicRoutingStatusField = value;
        }
    }
    
    
    [XmlElement("IdentifierRoutingStatus", Order=3)]
    public IdentifierRoutingStatus[] IdentifierRoutingStatus
    {
        get
        {
            return this.identifierRoutingStatusField;
        }
        set
        {
            this.identifierRoutingStatusField = value;
        }
    }
}


 
[Serializable]


[XmlType(AnonymousType=true, Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3")]
public class SenderProvidedResponseDataRequestRejected
{
    
    private RejectCode rejectionReasonCodeField;
    
    private string rejectionReasonDescriptionField;
    
    
    [XmlElement(Order=0)]
    public RejectCode RejectionReasonCode
    {
        get
        {
            return this.rejectionReasonCodeField;
        }
        set
        {
            this.rejectionReasonCodeField = value;
        }
    }
    
    
    [XmlElement(Order=1)]
    public string RejectionReasonDescription
    {
        get
        {
            return this.rejectionReasonDescriptionField;
        }
        set
        {
            this.rejectionReasonDescriptionField = value;
        }
    }
}


 
[Serializable]
[XmlType(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3")]
public enum RejectCode
{
    
    
    ACCESS_DENIED,
    
    
    NO_DATA,
    
    
    UNKNOWN_REQUEST_DESCRIPTION,
    
    
    FAILURE,
}


 
[Serializable]


[XmlType(AnonymousType=true, Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3")]
public class SenderProvidedResponseDataRequestStatus
{
    
    private int statusCodeField;
    
    private SenderProvidedResponseDataRequestStatusStatusParameter[] statusParameterField;
    
    private string statusDescriptionField;
    
    
    [XmlElement(Order=0)]
    public int StatusCode
    {
        get
        {
            return this.statusCodeField;
        }
        set
        {
            this.statusCodeField = value;
        }
    }
    
    
    [XmlElement("StatusParameter", Order=1)]
    public SenderProvidedResponseDataRequestStatusStatusParameter[] StatusParameter
    {
        get
        {
            return this.statusParameterField;
        }
        set
        {
            this.statusParameterField = value;
        }
    }
    
    
    [XmlElement(Order=2)]
    public string StatusDescription
    {
        get
        {
            return this.statusDescriptionField;
        }
        set
        {
            this.statusDescriptionField = value;
        }
    }
}


 
[Serializable]


[XmlType(AnonymousType=true, Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3")]
public class SenderProvidedResponseDataRequestStatusStatusParameter
{
    
    private string keyField;
    
    private string valueField;
    
    
    [XmlElement(Order=0)]
    public string Key
    {
        get
        {
            return this.keyField;
        }
        set
        {
            this.keyField = value;
        }
    }
    
    
    [XmlElement(Order=1)]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}


 
[Serializable]
[XmlType(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3", IncludeInSchema=false)]
public enum ItemsChoiceType
{
    
    
    AsyncProcessingStatus,
    
    
    PersonalSignature,
    
    
    RequestRejected,
    
    
    RequestStatus,
    
    
    [System.Xml.Serialization.XmlEnumAttribute("urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3:Attachmen" +
        "tHeaderList")]
    AttachmentHeaderList,
    
    
    [System.Xml.Serialization.XmlEnumAttribute("urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3:MessagePr" +
        "imaryContent")]
    MessagePrimaryContent,
    
    
    [System.Xml.Serialization.XmlEnumAttribute("urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3:RefAttach" +
        "mentHeaderList")]
    RefAttachmentHeaderList,
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.MessageContractAttribute(WrapperName="SendResponseRequest", WrapperNamespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3", IsWrapped=true)]
public class SendResponseRequest
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3", Order=0)]
    public SenderProvidedResponseData SenderProvidedResponseData;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3", Order=1)]
    [XmlElement("AttachmentContentList", typeof(AttachmentContentList), Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3")]
    public AttachmentContentType[] AttachmentContentList;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3", Order=2)]
    public System.Xml.XmlElement CallerInformationSystemSignature;
    
    public SendResponseRequest()
    {
    }
    
    public SendResponseRequest(SenderProvidedResponseData SenderProvidedResponseData, AttachmentContentType[] AttachmentContentList, System.Xml.XmlElement CallerInformationSystemSignature)
    {
        this.SenderProvidedResponseData = SenderProvidedResponseData;
        this.AttachmentContentList = AttachmentContentList;
        this.CallerInformationSystemSignature = CallerInformationSystemSignature;
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.MessageContractAttribute(WrapperName="SendResponseResponse", WrapperNamespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3", IsWrapped=true)]
public class SendResponseResponse
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3", Order=0)]
    public MessageMetadata MessageMetadata;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3", Order=1)]
    public System.Xml.XmlElement SMEVSignature;
    
    public SendResponseResponse()
    {
    }
    
    public SendResponseResponse(MessageMetadata MessageMetadata, System.Xml.XmlElement SMEVSignature)
    {
        this.MessageMetadata = MessageMetadata;
        this.SMEVSignature = SMEVSignature;
    }
}


 
[Serializable]


[XmlType(AnonymousType=true, Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3")]
public class Timestamp
{
    
    private string idField;
    
    private System.DateTime valueField;
    
    
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
    public string Id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
    
    
    [XmlText]
    public System.DateTime Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}


 
[Serializable]


[XmlType(AnonymousType=true, Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3")]
public class SmevAsyncProcessingMessage
{
    
    private AsyncProcessingStatusData itemField;
    
    private System.Xml.XmlElement sMEVSignatureField;
    
    
    [XmlElement("AsyncProcessingStatusData", Order=0)]
    public AsyncProcessingStatusData Item
    {
        get
        {
            return this.itemField;
        }
        set
        {
            this.itemField = value;
        }
    }
    
    
    [XmlElement(Order=1)]
    public System.Xml.XmlElement SMEVSignature
    {
        get
        {
            return this.sMEVSignatureField;
        }
        set
        {
            this.sMEVSignatureField = value;
        }
    }
}


 
[Serializable]


[XmlType(AnonymousType=true, Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3")]
public class AsyncProcessingStatusData
{
    
    private AsyncProcessingStatus asyncProcessingStatusField;
    
    private string idField;
    
    
    [XmlElement(Order=0)]
    public AsyncProcessingStatus AsyncProcessingStatus
    {
        get
        {
            return this.asyncProcessingStatusField;
        }
        set
        {
            this.asyncProcessingStatusField = value;
        }
    }
    
    
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
    public string Id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="GetStatusRequest", WrapperNamespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3", IsWrapped=true)]
public class GetStatusRequest
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3", Order=0)]
    [XmlElement(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3")]
    public Timestamp Timestamp;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3", Order=1)]
    public System.Xml.XmlElement CallerInformationSystemSignature;
    
    public GetStatusRequest()
    {
    }
    
    public GetStatusRequest(Timestamp Timestamp, System.Xml.XmlElement CallerInformationSystemSignature)
    {
        this.Timestamp = Timestamp;
        this.CallerInformationSystemSignature = CallerInformationSystemSignature;
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="GetStatusResponse", WrapperNamespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3", IsWrapped=true)]
public class GetStatusResponse
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3", Order=0)]
    public SmevAsyncProcessingMessage SmevAsyncProcessingMessage;
    
    public GetStatusResponse()
    {
    }
    
    public GetStatusResponse(SmevAsyncProcessingMessage SmevAsyncProcessingMessage)
    {
        this.SmevAsyncProcessingMessage = SmevAsyncProcessingMessage;
    }
}


 
[Serializable]


[XmlType(AnonymousType=true, Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3")]
public class MessageTypeSelector
{
    
    private string namespaceURIField;
    
    private string rootElementLocalNameField;
    
    private System.DateTime timestampField;
    
    private string nodeIDField;
    
    private string idField;
    
    
    [XmlElement(DataType="anyURI", Order=0)]
    public string NamespaceURI
    {
        get
        {
            return this.namespaceURIField;
        }
        set
        {
            this.namespaceURIField = value;
        }
    }
    
    
    [XmlElement(DataType="NCName", Order=1)]
    public string RootElementLocalName
    {
        get
        {
            return this.rootElementLocalNameField;
        }
        set
        {
            this.rootElementLocalNameField = value;
        }
    }
    
    
    [XmlElement(Order=2)]
    public System.DateTime Timestamp
    {
        get
        {
            return this.timestampField;
        }
        set
        {
            this.timestampField = value;
        }
    }
    
    
    [XmlElement(Order=3)]
    public string NodeID
    {
        get
        {
            return this.nodeIDField;
        }
        set
        {
            this.nodeIDField = value;
        }
    }
    
    
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
    public string Id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}


 
[Serializable]


[XmlType(AnonymousType=true, Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3")]
public class GetRequestResponseRequestMessage
{
    
    private object[] itemsField;
    
    private System.Xml.XmlElement sMEVSignatureField;
    
    
    [XmlElement("Request", typeof(Request), Order=0)]
    [XmlElement("AttachmentContentList", typeof(AttachmentContentList), Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3", Order=0)]
    public object[] Items
    {
        get
        {
            return this.itemsField;
        }
        set
        {
            this.itemsField = value;
        }
    }
    
    
    [XmlElement(Order=1)]
    public System.Xml.XmlElement SMEVSignature
    {
        get
        {
            return this.sMEVSignatureField;
        }
        set
        {
            this.sMEVSignatureField = value;
        }
    }
}


 
[Serializable]


[XmlType(AnonymousType=true, Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3")]
public class Request
{
    
    private SenderProvidedRequestData senderProvidedRequestDataField;
    
    private MessageMetadata messageMetadataField;
    
    private FSAuthInfo[] fSAttachmentsListField;
    
    private string replyToField;
    
    private System.Xml.XmlElement senderInformationSystemSignatureField;
    
    private string idField;
    
    
    [XmlElement(Order=0)]
    public SenderProvidedRequestData SenderProvidedRequestData
    {
        get
        {
            return this.senderProvidedRequestDataField;
        }
        set
        {
            this.senderProvidedRequestDataField = value;
        }
    }
    
    
    [XmlElement(Order=1)]
    public MessageMetadata MessageMetadata
    {
        get
        {
            return this.messageMetadataField;
        }
        set
        {
            this.messageMetadataField = value;
        }
    }
    
    
    [System.Xml.Serialization.XmlArrayAttribute(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3", Order=2)]
    [System.Xml.Serialization.XmlArrayItemAttribute("FSAttachment", IsNullable=false)]
    public FSAuthInfo[] FSAttachmentsList
    {
        get
        {
            return this.fSAttachmentsListField;
        }
        set
        {
            this.fSAttachmentsListField = value;
        }
    }
    
    
    [XmlElement(Order=3)]
    public string ReplyTo
    {
        get
        {
            return this.replyToField;
        }
        set
        {
            this.replyToField = value;
        }
    }
    
    
    [XmlElement(Order=4)]
    public System.Xml.XmlElement SenderInformationSystemSignature
    {
        get
        {
            return this.senderInformationSystemSignatureField;
        }
        set
        {
            this.senderInformationSystemSignatureField = value;
        }
    }
    
    
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
    public string Id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="GetRequestRequest", WrapperNamespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3", IsWrapped=true)]
public class GetRequestRequest
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3", Order=0)]
    [XmlElement(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3")]
    public MessageTypeSelector MessageTypeSelector;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3", Order=1)]
    public System.Xml.XmlElement CallerInformationSystemSignature;
    
    public GetRequestRequest()
    {
    }
    
    public GetRequestRequest(MessageTypeSelector MessageTypeSelector, System.Xml.XmlElement CallerInformationSystemSignature)
    {
        this.MessageTypeSelector = MessageTypeSelector;
        this.CallerInformationSystemSignature = CallerInformationSystemSignature;
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="GetRequestResponse", WrapperNamespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3", IsWrapped=true)]
public class GetRequestResponse
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3", Order=0)]
    public GetRequestResponseRequestMessage RequestMessage;
    
    public GetRequestResponse()
    {
    }
    
    public GetRequestResponse(GetRequestResponseRequestMessage RequestMessage)
    {
        this.RequestMessage = RequestMessage;
    }
}


 
[Serializable]


[XmlType(AnonymousType=true, Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3")]
public class GetResponseResponseResponseMessage
{
    
    private Response responseField;
    
    private AttachmentContentList attachmentContentListField;
    
    private System.Xml.XmlElement sMEVSignatureField;
    
    
    [XmlElement(Order=0)]
    public Response Response
    {
        get
        {
            return this.responseField;
        }
        set
        {
            this.responseField = value;
        }
    }
    
    
    [XmlElement(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3", Order=1)]
    public AttachmentContentList AttachmentContentList
    {
        get
        {
            return this.attachmentContentListField;
        }
        set
        {
            this.attachmentContentListField = value;
        }
    }
    
    
    [XmlElement(Order=2)]
    public System.Xml.XmlElement SMEVSignature
    {
        get
        {
            return this.sMEVSignatureField;
        }
        set
        {
            this.sMEVSignatureField = value;
        }
    }
}


 
[Serializable]


[XmlType(AnonymousType=true, Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3")]
public class Response
{
    
    private string originalMessageIdField;
    
    private string originalTransactionCodeField;
    
    private string referenceMessageIDField;
    
    private SenderProvidedResponseData senderProvidedResponseDataField;
    
    private MessageMetadata messageMetadataField;
    
    private FSAuthInfo[] fSAttachmentsListField;
    
    private System.Xml.XmlElement senderInformationSystemSignatureField;
    
    private string idField;
    
    
    [XmlElement(Order=0)]
    public string OriginalMessageId
    {
        get
        {
            return this.originalMessageIdField;
        }
        set
        {
            this.originalMessageIdField = value;
        }
    }
    
    
    [XmlElement(Order=1)]
    public string OriginalTransactionCode
    {
        get
        {
            return this.originalTransactionCodeField;
        }
        set
        {
            this.originalTransactionCodeField = value;
        }
    }
    
    
    [XmlElement(Order=2)]
    public string ReferenceMessageID
    {
        get
        {
            return this.referenceMessageIDField;
        }
        set
        {
            this.referenceMessageIDField = value;
        }
    }
    
    
    [XmlElement(Order=3)]
    public SenderProvidedResponseData SenderProvidedResponseData
    {
        get
        {
            return this.senderProvidedResponseDataField;
        }
        set
        {
            this.senderProvidedResponseDataField = value;
        }
    }
    
    
    [XmlElement(Order=4)]
    public MessageMetadata MessageMetadata
    {
        get
        {
            return this.messageMetadataField;
        }
        set
        {
            this.messageMetadataField = value;
        }
    }
    
    
    [System.Xml.Serialization.XmlArrayAttribute(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3", Order=5)]
    [System.Xml.Serialization.XmlArrayItemAttribute("FSAttachment", IsNullable=false)]
    public FSAuthInfo[] FSAttachmentsList
    {
        get
        {
            return this.fSAttachmentsListField;
        }
        set
        {
            this.fSAttachmentsListField = value;
        }
    }
    
    
    [XmlElement(Order=6)]
    public System.Xml.XmlElement SenderInformationSystemSignature
    {
        get
        {
            return this.senderInformationSystemSignatureField;
        }
        set
        {
            this.senderInformationSystemSignatureField = value;
        }
    }
    
    
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
    public string Id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="GetResponseRequest", WrapperNamespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3", IsWrapped=true)]
public class GetResponseRequest
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3", Order=0)]
    [XmlElement(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3")]
    public MessageTypeSelector MessageTypeSelector;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3", Order=1)]
    public System.Xml.XmlElement CallerInformationSystemSignature;
    
    public GetResponseRequest()
    {
    }
    
    public GetResponseRequest(MessageTypeSelector MessageTypeSelector, System.Xml.XmlElement CallerInformationSystemSignature)
    {
        this.MessageTypeSelector = MessageTypeSelector;
        this.CallerInformationSystemSignature = CallerInformationSystemSignature;
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="GetResponseResponse", WrapperNamespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3", IsWrapped=true)]
public class GetResponseResponse
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3", Order=0)]
    [XmlElement("ResponseMessage")]
    public GetResponseResponseResponseMessage Item;
    
    public GetResponseResponse()
    {
    }
    
    public GetResponseResponse(GetResponseResponseResponseMessage Item)
    {
        this.Item = Item;
    }
}


 
//[Serializable]


[XmlType(AnonymousType=true, Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3")]
public class AckTargetMessage
{
    [XmlAttribute(DataType = "ID")]
    public string Id { get; set; }


    [XmlAttribute]
    public bool accepted { get; set; }


    [XmlIgnore]
    public bool acceptedSpecified { get; set; }


    [XmlText]
    public string Value { get; set; }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="AckRequest", WrapperNamespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3", IsWrapped=true)]
public class AckRequest
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3", Order=0)]
    [XmlElement(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3")]
    public AckTargetMessage AckTargetMessage;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3", Order=1)]
    public System.Xml.XmlElement CallerInformationSystemSignature;
    
    public AckRequest()
    {
    }
    
    public AckRequest(AckTargetMessage AckTargetMessage, System.Xml.XmlElement CallerInformationSystemSignature)
    {
        this.AckTargetMessage = AckTargetMessage;
        this.CallerInformationSystemSignature = CallerInformationSystemSignature;
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="AckResponse", WrapperNamespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3", IsWrapped=true)]
public class AckResponse
{
    
    public AckResponse()
    {
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface SMEVMessageExchangePortTypeChannel : SMEVMessageExchangePortType, System.ServiceModel.IClientChannel
{
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public class SMEVMessageExchangePortTypeClient : System.ServiceModel.ClientBase<SMEVMessageExchangePortType>, SMEVMessageExchangePortType
{
    
    public SMEVMessageExchangePortTypeClient()
    {
    }
    
    public SMEVMessageExchangePortTypeClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public SMEVMessageExchangePortTypeClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public SMEVMessageExchangePortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public SMEVMessageExchangePortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    SendRequestResponse SMEVMessageExchangePortType.SendRequest(SendRequestRequest request)
    {
        return base.Channel.SendRequest(request);
    }
    
    public MessageMetadata SendRequest(SenderProvidedRequestData SenderProvidedRequestData, AttachmentContentType[] AttachmentContentList, System.Xml.XmlElement CallerInformationSystemSignature, Routing Routing, out System.Xml.XmlElement SMEVSignature)
    {
        SendRequestRequest inValue = new SendRequestRequest();
        inValue.SenderProvidedRequestData = SenderProvidedRequestData;
        inValue.AttachmentContentList = AttachmentContentList;
        inValue.CallerInformationSystemSignature = CallerInformationSystemSignature;
        inValue.Routing = Routing;
        SendRequestResponse retVal = ((SMEVMessageExchangePortType)(this)).SendRequest(inValue);
        SMEVSignature = retVal.SMEVSignature;
        return retVal.MessageMetadata;
    }
    
    public System.Threading.Tasks.Task<SendRequestResponse> SendRequestAsync(SendRequestRequest request)
    {
        return base.Channel.SendRequestAsync(request);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    SendResponseResponse SMEVMessageExchangePortType.SendResponse(SendResponseRequest request)
    {
        return base.Channel.SendResponse(request);
    }
    
    public MessageMetadata SendResponse(SenderProvidedResponseData SenderProvidedResponseData, AttachmentContentType[] AttachmentContentList, System.Xml.XmlElement CallerInformationSystemSignature, out System.Xml.XmlElement SMEVSignature)
    {
        SendResponseRequest inValue = new SendResponseRequest();
        inValue.SenderProvidedResponseData = SenderProvidedResponseData;
        inValue.AttachmentContentList = AttachmentContentList;
        inValue.CallerInformationSystemSignature = CallerInformationSystemSignature;
        SendResponseResponse retVal = ((SMEVMessageExchangePortType)(this)).SendResponse(inValue);
        SMEVSignature = retVal.SMEVSignature;
        return retVal.MessageMetadata;
    }
    
    public System.Threading.Tasks.Task<SendResponseResponse> SendResponseAsync(SendResponseRequest request)
    {
        return base.Channel.SendResponseAsync(request);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    GetStatusResponse SMEVMessageExchangePortType.GetStatus(GetStatusRequest request)
    {
        return base.Channel.GetStatus(request);
    }
    
    public SmevAsyncProcessingMessage GetStatus(Timestamp Timestamp, System.Xml.XmlElement CallerInformationSystemSignature)
    {
        GetStatusRequest inValue = new GetStatusRequest();
        inValue.Timestamp = Timestamp;
        inValue.CallerInformationSystemSignature = CallerInformationSystemSignature;
        GetStatusResponse retVal = ((SMEVMessageExchangePortType)(this)).GetStatus(inValue);
        return retVal.SmevAsyncProcessingMessage;
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<GetStatusResponse> SMEVMessageExchangePortType.GetStatusAsync(GetStatusRequest request)
    {
        return base.Channel.GetStatusAsync(request);
    }
    
    public System.Threading.Tasks.Task<GetStatusResponse> GetStatusAsync(Timestamp Timestamp, System.Xml.XmlElement CallerInformationSystemSignature)
    {
        GetStatusRequest inValue = new GetStatusRequest();
        inValue.Timestamp = Timestamp;
        inValue.CallerInformationSystemSignature = CallerInformationSystemSignature;
        return ((SMEVMessageExchangePortType)(this)).GetStatusAsync(inValue);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    GetRequestResponse SMEVMessageExchangePortType.GetRequest(GetRequestRequest request)
    {
        return base.Channel.GetRequest(request);
    }
    
    public GetRequestResponseRequestMessage GetRequest(MessageTypeSelector MessageTypeSelector, System.Xml.XmlElement CallerInformationSystemSignature)
    {
        GetRequestRequest inValue = new GetRequestRequest();
        inValue.MessageTypeSelector = MessageTypeSelector;
        inValue.CallerInformationSystemSignature = CallerInformationSystemSignature;
        GetRequestResponse retVal = ((SMEVMessageExchangePortType)(this)).GetRequest(inValue);
        return retVal.RequestMessage;
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<GetRequestResponse> SMEVMessageExchangePortType.GetRequestAsync(GetRequestRequest request)
    {
        return base.Channel.GetRequestAsync(request);
    }
    
    public System.Threading.Tasks.Task<GetRequestResponse> GetRequestAsync(MessageTypeSelector MessageTypeSelector, System.Xml.XmlElement CallerInformationSystemSignature)
    {
        GetRequestRequest inValue = new GetRequestRequest();
        inValue.MessageTypeSelector = MessageTypeSelector;
        inValue.CallerInformationSystemSignature = CallerInformationSystemSignature;
        return ((SMEVMessageExchangePortType)(this)).GetRequestAsync(inValue);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    GetResponseResponse SMEVMessageExchangePortType.GetResponse(GetResponseRequest request)
    {
        return base.Channel.GetResponse(request);
    }
    
    public GetResponseResponseResponseMessage GetResponse(MessageTypeSelector MessageTypeSelector, System.Xml.XmlElement CallerInformationSystemSignature)
    {
        GetResponseRequest inValue = new GetResponseRequest();
        inValue.MessageTypeSelector = MessageTypeSelector;
        inValue.CallerInformationSystemSignature = CallerInformationSystemSignature;
        GetResponseResponse retVal = ((SMEVMessageExchangePortType)(this)).GetResponse(inValue);
        return retVal.Item;
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<GetResponseResponse> SMEVMessageExchangePortType.GetResponseAsync(GetResponseRequest request)
    {
        return base.Channel.GetResponseAsync(request);
    }
    
    public System.Threading.Tasks.Task<GetResponseResponse> GetResponseAsync(MessageTypeSelector MessageTypeSelector, System.Xml.XmlElement CallerInformationSystemSignature)
    {
        GetResponseRequest inValue = new GetResponseRequest();
        inValue.MessageTypeSelector = MessageTypeSelector;
        inValue.CallerInformationSystemSignature = CallerInformationSystemSignature;
        return ((SMEVMessageExchangePortType)(this)).GetResponseAsync(inValue);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    AckResponse SMEVMessageExchangePortType.Ack(AckRequest request)
    {
        return base.Channel.Ack(request);
    }
    
    public void Ack(AckTargetMessage AckTargetMessage, System.Xml.XmlElement CallerInformationSystemSignature)
    {
        AckRequest inValue = new AckRequest();
        inValue.AckTargetMessage = AckTargetMessage;
        inValue.CallerInformationSystemSignature = CallerInformationSystemSignature;
        AckResponse retVal = ((SMEVMessageExchangePortType)(this)).Ack(inValue);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<AckResponse> SMEVMessageExchangePortType.AckAsync(AckRequest request)
    {
        return base.Channel.AckAsync(request);
    }
    
    public System.Threading.Tasks.Task<AckResponse> AckAsync(AckTargetMessage AckTargetMessage, System.Xml.XmlElement CallerInformationSystemSignature)
    {
        AckRequest inValue = new AckRequest();
        inValue.AckTargetMessage = AckTargetMessage;
        inValue.CallerInformationSystemSignature = CallerInformationSystemSignature;
        return ((SMEVMessageExchangePortType)(this)).AckAsync(inValue);
    }
}
namespace xartefactssmevgovru.services.messageexchange.types.basic._1._31
{
    using System.Runtime.Serialization;
    
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Void", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(xartefactssmevgovru.services.messageexchange.types.basic._1._31.SmevFault))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(xartefactssmevgovru.services.messageexchange.types.faults._1._31.AttachmentSizeLimitExceeded))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(xartefactssmevgovru.services.messageexchange.types.faults._1._31.QuoteLimitExceeded))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(xartefactssmevgovru.services.messageexchange.types.faults._1._31.SignatureVerificationFault))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(xartefactssmevgovru.services.messageexchange.types.faults._1._31.DestinationOverflow))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(xartefactssmevgovru.services.messageexchange.types.faults._1._31.BusinessDataTypeIsNotSupported))]
    public class Void : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
    }
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SmevFault", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(xartefactssmevgovru.services.messageexchange.types.faults._1._31.AttachmentSizeLimitExceeded))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(xartefactssmevgovru.services.messageexchange.types.faults._1._31.QuoteLimitExceeded))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(xartefactssmevgovru.services.messageexchange.types.faults._1._31.SignatureVerificationFault))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(xartefactssmevgovru.services.messageexchange.types.faults._1._31.DestinationOverflow))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(xartefactssmevgovru.services.messageexchange.types.faults._1._31.BusinessDataTypeIsNotSupported))]
    public class SmevFault : xartefactssmevgovru.services.messageexchange.types.basic._1._31.Void
    {
        
        private string CodeField;
        
        private string DescriptionField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Code
        {
            get
            {
                return this.CodeField;
            }
            set
            {
                this.CodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
    }
}
namespace xartefactssmevgovru.services.messageexchange.types.faults._1._31
{
    using System.Runtime.Serialization;
    
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AttachmentSizeLimitExceeded", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    public class AttachmentSizeLimitExceeded : xartefactssmevgovru.services.messageexchange.types.basic._1._31.SmevFault
    {
        
        private long PermittedTotalAttachmentSizeField;
        
        private long RealTotalAttachmentSizeField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public long PermittedTotalAttachmentSize
        {
            get
            {
                return this.PermittedTotalAttachmentSizeField;
            }
            set
            {
                this.PermittedTotalAttachmentSizeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public long RealTotalAttachmentSize
        {
            get
            {
                return this.RealTotalAttachmentSizeField;
            }
            set
            {
                this.RealTotalAttachmentSizeField = value;
            }
        }
    }
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="QuoteLimitExceeded", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    public class QuoteLimitExceeded : xartefactssmevgovru.services.messageexchange.types.basic._1._31.SmevFault
    {
        
        private long RemainedTotalQuoteSizeField;
        
        private long RealTotalAttachmentSizeField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public long RemainedTotalQuoteSize
        {
            get
            {
                return this.RemainedTotalQuoteSizeField;
            }
            set
            {
                this.RemainedTotalQuoteSizeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
        public long RealTotalAttachmentSize
        {
            get
            {
                return this.RealTotalAttachmentSizeField;
            }
            set
            {
                this.RealTotalAttachmentSizeField = value;
            }
        }
    }
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SignatureVerificationFault", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    public class SignatureVerificationFault : xartefactssmevgovru.services.messageexchange.types.basic._1._31.SmevFault
    {
        
        private xartefactssmevgovru.services.messageexchange.types.faults._1._31.SignatureVerificationFault.SignatureVerificationFaultType SignatureVerificationFaultMemberField;
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="SignatureVerificationFault", IsRequired=true)]
        public xartefactssmevgovru.services.messageexchange.types.faults._1._31.SignatureVerificationFault.SignatureVerificationFaultType SignatureVerificationFaultMember
        {
            get
            {
                return this.SignatureVerificationFaultMemberField;
            }
            set
            {
                this.SignatureVerificationFaultMemberField = value;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name="SignatureVerificationFault.SignatureVerificationFaultType", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
        public enum SignatureVerificationFaultType : int
        {
            
            [System.Runtime.Serialization.EnumMemberAttribute()]
            PoorSOAPEnvelopeFormat = 0,
            
            [System.Runtime.Serialization.EnumMemberAttribute()]
            NoSignatureFound = 1,
            
            [System.Runtime.Serialization.EnumMemberAttribute()]
            IncorrectSignatureTarget = 2,
            
            [System.Runtime.Serialization.EnumMemberAttribute()]
            SignatureIsInvalid = 3,
            
            [System.Runtime.Serialization.EnumMemberAttribute()]
            CertificateIsNotFound = 4,
            
            [System.Runtime.Serialization.EnumMemberAttribute()]
            CertificateIsExpired = 5,
        }
    }
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DestinationOverflow", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    public class DestinationOverflow : xartefactssmevgovru.services.messageexchange.types.basic._1._31.SmevFault
    {
        
        private string MessageBrokerAddressField;
        
        private string DestinationNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
        public string MessageBrokerAddress
        {
            get
            {
                return this.MessageBrokerAddressField;
            }
            set
            {
                this.MessageBrokerAddressField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false, Order=1)]
        public string DestinationName
        {
            get
            {
                return this.DestinationNameField;
            }
            set
            {
                this.DestinationNameField = value;
            }
        }
    }
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BusinessDataTypeIsNotSupported", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    public class BusinessDataTypeIsNotSupported : xartefactssmevgovru.services.messageexchange.types.basic._1._31.SmevFault
    {
        
        private string RootElementLocalNameField;
        
        private string RootElementNamespaceURIField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
        public string RootElementLocalName
        {
            get
            {
                return this.RootElementLocalNameField;
            }
            set
            {
                this.RootElementLocalNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
        public string RootElementNamespaceURI
        {
            get
            {
                return this.RootElementNamespaceURIField;
            }
            set
            {
                this.RootElementNamespaceURIField = value;
            }
        }
    }
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Xml.Serialization.XmlSchemaProviderAttribute("ExportSchema")]
    [System.Xml.Serialization.XmlRootAttribute(IsNullable=false)]
    public class InvalidContent : object, System.Xml.Serialization.IXmlSerializable
    {
        
        private System.Xml.XmlNode[] nodesField;
        
        private static System.Xml.XmlQualifiedName typeName = new System.Xml.XmlQualifiedName("InvalidContent", "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3");
        
        public System.Xml.XmlNode[] Nodes
        {
            get
            {
                return this.nodesField;
            }
            set
            {
                this.nodesField = value;
            }
        }
        
        public void ReadXml(System.Xml.XmlReader reader)
        {
            this.nodesField = System.Runtime.Serialization.XmlSerializableServices.ReadNodes(reader);
        }
        
        public void WriteXml(System.Xml.XmlWriter writer)
        {
            System.Runtime.Serialization.XmlSerializableServices.WriteNodes(writer, this.Nodes);
        }
        
        public System.Xml.Schema.XmlSchema GetSchema()
        {
            return null;
        }
        
        public static System.Xml.XmlQualifiedName ExportSchema(System.Xml.Schema.XmlSchemaSet schemas)
        {
            System.Runtime.Serialization.XmlSerializableServices.AddDefaultSchema(schemas, typeName);
            return typeName;
        }
    }
}
