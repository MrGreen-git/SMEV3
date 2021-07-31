using System;
using System.Xml.Serialization;

namespace SMEV3v13.Types
{
    [Serializable]
    [XmlType(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3", IncludeInSchema = false)]
    public enum ItemsChoiceType
    {
        AsyncProcessingStatus,

        PersonalSignature,

        RequestRejected,

        RequestStatus,

        [XmlEnum("urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3:AttachmentHeaderList")]
        AttachmentHeaderList,

        [XmlEnum("urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3:MessagePrimaryContent")]
        MessagePrimaryContent,

        [XmlEnum("urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.3:RefAttachmentHeaderList")]
        RefAttachmentHeaderList,
    }
}
