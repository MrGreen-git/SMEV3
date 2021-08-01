using SMEV3v12.Types.Basic;
using System;
using System.Xml.Serialization;

namespace SMEV3v12.Types.Faults
{
    [Serializable]
    [XmlType(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
    public class BusinessDataTypeIsNotSupported : SmevFault
    {
        [XmlElement(Order = 0)]
        public string RootElementLocalName { get; set; }

        [XmlElement(Order = 1)]
        public string RootElementNamespaceURI { get; set; }
    }
}
