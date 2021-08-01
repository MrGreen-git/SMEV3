using System;
using System.Xml.Serialization;

namespace SMEV3v12.Types.Faults
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
    public class InvalidContentValidationError
    {
        [XmlAttribute()]
        public int errorPosition { get; set; }

        [XmlText()]
        public string Value { get; set; }
    }
}
