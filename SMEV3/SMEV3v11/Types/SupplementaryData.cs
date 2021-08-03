using SMEV3v11.Types.Basic;
using System;
using System.Xml.Serialization;

namespace SMEV3v11.Types
{
    /// <summary>
    /// Дополнительная информация о сообщении.
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1")]
    public class SupplementaryData
    {
        /// <summary>
        /// Тип сообщения. Вычисляется СМЭВ на основании полного имени (qualified name) корневого XML-элемента сообщения.
        /// Например, "Заявка на получение выписки из ЕГРИП".
        /// Для ответов на запросы этот элемент опускается.
        /// </summary>
        [XmlElement(Order = 0)]
        public string DetectedContentTypeName { get; set; }

        /// <summary>
        /// Тип взаимодействия, например, портал госуслуг - ОИВ.
        /// </summary>
        [XmlElement(Order = 1)]
        public InteractionTypeType InteractionType { get; set; }
    }
}
