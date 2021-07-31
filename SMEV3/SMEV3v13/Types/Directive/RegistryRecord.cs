using System;
using System.Xml.Serialization;
using System.Xml;

namespace SMEV3v13.Types.Directive
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/directive/1.3")]
    [XmlRoot(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/directive/1.3", IsNullable = false)]
    public class RegistryRecord
    {
        public int RecordId { get; set; }

        public Record Record { get; set; }

        public XmlElement RecordSignature { get; set; }
    }
}
