using System;
using System.Xml.Serialization;

namespace SMEV3v13.Types.Routing
{
    [Serializable]
    [XmlType(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/routing/1.3")]
    public enum RoutingStatusCodeType
    {
        success,

        recipientNotFound,

        invalidRegistryRecordId,

        certificateInvalid,

        signatureInvalid,

        generalRoutingNotFound,

        personalAccessDenied,
    }
}
