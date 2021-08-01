using System.Runtime.Serialization;

namespace SMEV3v12.DataContract
{
    [DataContract(Name = "SmevFault", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2")]
    [KnownType(typeof(AttachmentSizeLimitExceeded))]
    [KnownType(typeof(QuoteLimitExceeded))]
    [KnownType(typeof(SignatureVerificationFault))]
    [KnownType(typeof(DestinationOverflow))]
    [KnownType(typeof(BusinessDataTypeIsNotSupported))]
    public class SmevFault : Void
    {
        [DataMember(EmitDefaultValue = false)]
        public string Code { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Description { get; set; }
    }
}
