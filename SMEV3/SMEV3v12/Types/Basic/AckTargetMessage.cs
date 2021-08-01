using System;
using System.Xml.Serialization;

namespace SMEV3v12.Types.Basic
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2")]
    public class AckTargetMessage
    {
        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }

        [XmlAttribute()]
        public bool accepted { get; set; }

        [XmlIgnore]
        public bool acceptedSpecified { get; set; }

        [XmlText()]
        public string Value { get; set; }
    }
}
