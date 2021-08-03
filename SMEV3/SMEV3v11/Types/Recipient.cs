using System;
using System.Xml.Serialization;

namespace SMEV3v11.Types
{
    /// <summary>
    /// Получатель сообщения (вычислен маршрутизатором).
    /// Для широковещательных сообщений не заполняется.
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1")]
    public class Recipient
    {
        /// <summary>
        /// Мнемоника. Для машинной обработки.
        /// </summary>
        [XmlElement(Order = 0)]
        public string Mnemonic { get; set; }

        /// <summary>
        /// Наименование в форме, удобной для восприятия человеком.
        /// </summary>
        [XmlElement(Order = 1)]
        public string HumanReadableName { get; set; }
    }
}
