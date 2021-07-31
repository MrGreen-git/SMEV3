using System;
using System.Xml.Serialization;

namespace SMEV3v13.Types.Basic
{
    [Serializable]
    [XmlType(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3")]
    public class FileType
    {
        [XmlElement(Order = 0)]
        public string Name { get; set; }


        [XmlElement(Order = 1)]
        public string NamespaceUri { get; set; }
    }
}
