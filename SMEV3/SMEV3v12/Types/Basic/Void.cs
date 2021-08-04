using SMEV3v12.Types.Faults;
using System;
using System.Xml.Serialization;

namespace SMEV3v12.Types.Basic
{
    /// <summary>
    /// Тип элемента, который передаёт информацию фактом своего наличия
    /// </summary>
    [XmlInclude(typeof(SmevFault))]
    [XmlInclude(typeof(DestinationOverflow))]
    [XmlInclude(typeof(SignatureVerificationFault))]
    [XmlInclude(typeof(QuoteLimitExceeded))]
    [XmlInclude(typeof(AttachmentSizeLimitExceeded))]
    [XmlInclude(typeof(InvalidContent))]
    [XmlInclude(typeof(BusinessDataTypeIsNotSupported))]
    [Serializable]
    [XmlType(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2")]
    public class Void
    {
    }
}
