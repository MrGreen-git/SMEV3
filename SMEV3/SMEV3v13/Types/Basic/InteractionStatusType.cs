using System;
using System.Xml.Serialization;

namespace SMEV3v13.Types.Basic
{
    [Serializable]
    [XmlType(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3")]
    public enum InteractionStatusType
    {
        doesNotExist,

        requestIsQueued,

        requestIsAcceptedBySmev,

        requestIsRejectedBySmev,

        requestIsProcessed,

        underProcessing,

        responseIsQueued,

        responseIsAcceptedBySmev,

        responseIsRejectedBySmev,

        responseIsProcessed,

        cancelled,

        messageIsArchived,

        messageIsDelivered,
    }
}
