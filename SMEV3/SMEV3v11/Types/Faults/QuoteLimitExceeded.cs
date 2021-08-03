using SMEV3v11.Types.Basic;
using System;
using System.Xml.Serialization;

namespace SMEV3v11.Types.Faults
{
    /// <summary>
    /// Суммарный размер вложений превысил размер оставшейся квоты, установленный правилами СМЭВ.
    /// Действия СМЭВ: сообщение отброшено.
    /// Действия клиента: Освобождение квоты.
    /// После освобождения квоты должно быть переотправлено новое сообщение, в котором суммарный размер вложений находится в допустимых для квоты пределах.
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.1")]
    public class QuoteLimitExceeded : SmevFault
    {
        /// <summary>
        /// Текущее значение оставшейся квоты для СМЭВ-сообщении, в байтах.
        /// </summary>
        [XmlElement(Order = 0)]
        public long RemainedTotalQuoteSize { get; set; }

        /// <summary>
        /// Суммарные размер вложений, переданных в отвергнутом сообщении, в байтах.
        /// </summary>
        [XmlElement(Order = 1)]
        public long RealTotalAttachmentSize { get; set; }
    }
}
