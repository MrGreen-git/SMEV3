using System;
using System.Xml.Serialization;

namespace SMEV3v13.Types.Faults
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    public enum SignatureVerificationFaultSignatureVerificationFault
    {
        PoorSOAPEnvelopeFormat,

        NoSignatureFound,

        IncorrectSignatureTarget,

        SignatureIsInvalid,

        CertificateIsNotFound,

        CertificateIsExpired,
    }
}
