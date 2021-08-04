using System;
using System.Xml.Serialization;

namespace SMEV3v12.Types
{
    /// <summary>
    /// Получатель сообщения (вычислен маршрутизатором). Для широковещательных сообщений не заполняется.
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2")]
    public class Recipient
    {
        /// <summary>
        /// Мнемоника. Для машинной обработки.
        /// </summary>
        [XmlElement(Order = 0)]
        public string Mnemonic { get; set; }
    }
}
