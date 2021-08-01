using System;
using System.Xml.Serialization;

namespace SMEV3v11.Types.Basic
{
    [Serializable]
    [XmlType(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.1")]
    public enum InteractionTypeType
    {
        PGU2OIV,

        OIV2OIV,

        OIV2sameOIV,

        Charger2PaymentGate,

        PaymentGate2Treasury,

        OIV2Treasury,

        other,

        NotDetected,
    }
}
