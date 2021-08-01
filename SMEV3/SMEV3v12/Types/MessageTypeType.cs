using System;
using System.Xml.Serialization;

namespace SMEV3v12.Types
{
    [Serializable]
    [XmlType(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2")]
    public enum MessageTypeType
    {
        REQUEST,

        BROADCAST,

        RESPONSE,
    }
}
