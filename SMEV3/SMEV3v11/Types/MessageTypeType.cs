using System;
using System.Xml.Serialization;

namespace SMEV3v11.Types
{
    [Serializable]
    [XmlType(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1")]
    public enum MessageTypeType
    {
        REQUEST,

        BROADCAST,

        RESPONSE,

        CANCEL,
    }
}
