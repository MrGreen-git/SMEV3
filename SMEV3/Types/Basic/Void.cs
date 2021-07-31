﻿using System;
using System.Xml.Serialization;

namespace SMEV3v13.Types.Basic
{
    [XmlInclude(typeof(SmevFault))]
    [XmlInclude(typeof(DestinationOverflow))]
    [XmlInclude(typeof(SignatureVerificationFault))]
    [XmlInclude(typeof(QuoteLimitExceeded))]
    [XmlInclude(typeof(AttachmentSizeLimitExceeded))]
    [XmlInclude(typeof(InvalidContent))]
    [XmlInclude(typeof(BusinessDataTypeIsNotSupported))]
    [Serializable]
    [XmlType(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3")]
    public class Void
    {
    }
}
