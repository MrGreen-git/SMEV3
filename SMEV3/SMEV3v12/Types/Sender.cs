using System;
using System.Xml.Serialization;

namespace SMEV3v12.Types
{
    /// <summary>
    /// Информация об отправителе сообщения.
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2")]
    public class Sender
    {
        /// <summary>
        /// Мнемоника отправителя. Для машинной обработки. Вычисляется на основании данных сетрификата.
        /// </summary>
        [XmlElement(Order = 0)]
        public string Mnemonic { get; set; }
    }
}
