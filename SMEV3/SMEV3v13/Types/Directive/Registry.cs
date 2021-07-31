using System;
using System.Xml.Serialization;

namespace SMEV3v13.Types.Directive
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/directive/1.3")]
    [XmlRoot(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/directive/1.3", IsNullable = false)]
    public class Registry
    {
        [XmlElement("RegistryRecord")]
        public RegistryRecord[] RegistryRecord { get; set; }
    }
}
