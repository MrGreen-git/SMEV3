using System;
using System.Xml.Serialization;

namespace SMEV3v12.Types
{
    [Serializable]
    [XmlType(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", IncludeInSchema = false)]
    public enum ItemsChoiceType
    {
        AsyncProcessingStatus,

        /// <summary>
        /// ЭП-СП содержательной части ответа. Подписывается элемент, находящийся сразу под MessagePrimaryContent
        /// </summary>
        PersonalSignature,

        RequestRejected,

        RequestStatus,

        /// <summary>
        /// Заголовки вложенных файлов.
        /// </summary>
        [XmlEnum("urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2:AttachmentHeaderType")]
        AttachmentHeaderType,

        /// <summary>
        /// Содержательная часть ответа, XML-документ
        /// </summary>
        [XmlEnum("urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2:MessagePrimaryContent")]
        MessagePrimaryContent,

        /// <summary>
        /// Заголовки файлов по ссылке
        /// </summary>
        [XmlEnum("urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2:RefAttachmentHeaderType")]
        RefAttachmentHeaderType,
    }
}
