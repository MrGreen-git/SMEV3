using System;
using System.Xml.Serialization;

namespace SMEV3v12.Types
{
    [Serializable]
    [XmlType(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", IncludeInSchema = false)]
    public enum ItemsChoiceType
    {
        AsyncProcessingStatus,

        PersonalSignature,

        RequestRejected,

        RequestStatus,

        [XmlEnum("urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2:AttachmentHeaderList")]
        AttachmentHeaderList,

        [XmlEnum("urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2:MessagePrimaryContent")]
        MessagePrimaryContent,

        [XmlEnum("urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2:RefAttachmentHeaderList")]
        RefAttachmentHeaderList,
    }
}
