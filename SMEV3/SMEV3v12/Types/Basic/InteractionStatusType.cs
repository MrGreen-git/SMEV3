using System;
using System.Xml.Serialization;

namespace SMEV3v12.Types.Basic
{
    [Serializable]
    [XmlType(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2")]
    public enum InteractionStatusType
    {
        doesNotExist,

        requestIsQueued,

        requestIsAcceptedBySmev,

        requestIsRejectedBySmev,

        underProcessing,

        responseIsAcceptedBySmev,

        responseIsRejectedBySmev,

        cancelled,

        messageIsArchived,

        messageIsDelivered,
    }
}
