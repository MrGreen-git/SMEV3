using System.Runtime.Serialization;

namespace SMEV3v13.DataContract
{
    [DataContract(Name = "SignatureVerificationFault", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    public class SignatureVerificationFault : SmevFault
{
        [DataMember(Name = "SignatureVerificationFault", IsRequired = true)]
        public SignatureVerificationFaultType SignatureVerificationFaultMember { get; set; }

        [DataContract(Name = "SignatureVerificationFault.SignatureVerificationFaultType", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
        public enum SignatureVerificationFaultType : int
        {
            [EnumMember]
            PoorSOAPEnvelopeFormat = 0,

            [EnumMember]
            NoSignatureFound = 1,

            [EnumMember]
            IncorrectSignatureTarget = 2,

            [EnumMember]
            SignatureIsInvalid = 3,

            [EnumMember]
            CertificateIsNotFound = 4,

            [EnumMember]
            CertificateIsExpired = 5,
        }
    }
}
