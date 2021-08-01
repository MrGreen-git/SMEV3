using System;
using System.Xml.Serialization;

namespace SMEV3v11.Types.Basic
{
    [Serializable]
    [XmlType(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.1")]
    public class FSAuthInfo
    {
        [XmlElement(Order = 0)]
        public string uuid { get; set; }

        [XmlElement(Order = 1)]
        public string UserName { get; set; }

        [XmlElement(Order = 2)]
        public string Password { get; set; }

        [XmlElement(Order = 3)]
        public string FileName { get; set; }
    }
}
