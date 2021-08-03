using SMEV3v11.Types.Basic;
using System;
using System.Xml.Serialization;

namespace SMEV3v11.Types.Faults
{
    /// <summary>
    /// Суммарный размер вложений превысил предел, установленный правилами СМЭВ.
    /// Действия СМЭВ: сообщение отброшено.
    /// Действия клиента: приложенные файлы должны быть уменьшены в размере (например, путём увеличения уровня сжатия JPEG).
    /// Должно быть сформировано новое сообщение, в котором суммарный размер вложений находится в допустимых пределах.
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.1")]
    public class AttachmentSizeLimitExceeded : SmevFault
    {
        /// <summary>
        /// Максимальный суммарный размер вложений, разрешённый для передачи в одном СМЭВ-сообщении, в байтах.
        /// </summary>
        [XmlElement(Order = 0)]
        public long PermittedTotalAttachmentSize { get; set; }

        /// <summary>
        /// Суммарные размер вложений, переданных в отвергнутом сообщении, в байтах.
        /// </summary>
        [XmlElement(Order = 1)]
        public long RealTotalAttachmentSize { get; set; }
    }
}
