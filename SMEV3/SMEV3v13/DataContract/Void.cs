using System.Runtime.Serialization;

namespace SMEV3v13.DataContract
{
    [DataContract(Name = "Void", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3")]
    [KnownType(typeof(SmevFault))]
    [KnownType(typeof(AttachmentSizeLimitExceeded))]
    [KnownType(typeof(QuoteLimitExceeded))]
    [KnownType(typeof(SignatureVerificationFault))]
    [KnownType(typeof(DestinationOverflow))]
    [KnownType(typeof(BusinessDataTypeIsNotSupported))]
    public class Void : object, IExtensibleDataObject
    {
        public ExtensionDataObject ExtensionData { get; set; }
    }
}
