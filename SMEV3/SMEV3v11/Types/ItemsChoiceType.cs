using System;
using System.Xml.Serialization;

namespace SMEV3v11.Types
{
    [Serializable]
    [XmlType(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1", IncludeInSchema = false)]
    public enum ItemsChoiceType
    {
        AsyncProcessingStatus,

        PersonalSignature,

        RequestRejected,

        RequestStatus,

        [XmlEnum("urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.1:AttachmentHeaderList")]
        AttachmentHeaderList,

        [XmlEnum("urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.1:MessagePrimaryContent")]
        MessagePrimaryContent,

        [XmlEnum("urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.1:RefAttachmentHeaderList")]
        RefAttachmentHeaderList,
    }
}
