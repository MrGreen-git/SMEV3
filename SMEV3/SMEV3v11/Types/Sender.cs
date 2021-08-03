using System;
using System.Xml.Serialization;

namespace SMEV3v11.Types
{
    /// <summary>
    /// Информация об отправителе сообщения.
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1")]
    public class Sender
    {
        /// <summary>
        /// Мнемоника отправителя. Для машинной обработки. Вычисляется на основании данных сетрификата.
        /// </summary>
        [XmlElement(Order = 0)]
        public string Mnemonic { get; set; }

        /// <summary>
        /// Наименование отправителя в форме, удобной для восприятия человеком.
        /// Вычисляется на основании данных сертификата.
        /// Не обязано полностью совпадать с официальным названием организации или органа власти.
        /// </summary>
        [XmlElement(Order = 1)]
        public string HumanReadableName { get; set; }
    }
}
