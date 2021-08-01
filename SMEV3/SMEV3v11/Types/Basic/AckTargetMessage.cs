using System;
using System.Xml.Serialization;

namespace SMEV3v11.Types.Basic
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.1")]
    public class AckTargetMessage
    {
        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }

        [XmlAttribute]
        public bool accepted { get; set; }

        [XmlText]
        public string Value { get; set; }
    }
}
