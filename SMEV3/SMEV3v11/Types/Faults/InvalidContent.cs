using SMEV3v11.Types.Basic;
using System;
using System.Xml.Serialization;

namespace SMEV3v11.Types.Faults
{
    [Serializable]
    [XmlType(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.1")]
    public class InvalidContent : SmevFault
    {
        [XmlElement("ValidationError", Order = 0)]
        public InvalidContentValidationError[] ValidationError { get; set; }
    }
}
