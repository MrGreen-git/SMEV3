using SMEV3v13.Types.Faults;
using System;
using System.Xml.Serialization;

namespace SMEV3v13.Types.Basic
{
    [XmlInclude(typeof(DestinationOverflow))]
    [XmlInclude(typeof(SignatureVerificationFault))]
    [XmlInclude(typeof(QuoteLimitExceeded))]
    [XmlInclude(typeof(AttachmentSizeLimitExceeded))]
    [XmlInclude(typeof(InvalidContent))]
    [XmlInclude(typeof(BusinessDataTypeIsNotSupported))]
    [Serializable]
    [XmlType(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3")]
    public class SmevFault : Void
    {
        [XmlElement(Order = 0)]
        public string Code { get; set; }

        [XmlElement(Order = 1)]
        public string Description { get; set; }
    }
}
