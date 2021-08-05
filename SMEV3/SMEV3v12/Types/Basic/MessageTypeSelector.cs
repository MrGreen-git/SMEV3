using System;
using System.Xml.Serialization;

namespace SMEV3v12.Types.Basic
{
    /// <summary>
    /// Селектор, с помощью которого при приёме запроса или ответа
    /// можно задать фильтр по типу запроса(ответа).
    /// Поскольку тип запроса или ответа однозначно определяется полным именем
    /// корневого XML-элемента его бизнес-данных,
    /// селектор представляет из себя структуру для задания этого имени.
    /// Если селектор пуст, это значит, что нужно принять запрос(ответ)
    /// без фильтрации по типам.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2")]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2")]
    public class MessageTypeSelector
    {
        [XmlElement(DataType = "anyURI", Order = 0)]
        public string NamespaceURI { get; set; }

        [XmlElement(DataType = "NCName", Order = 1)]
        public string RootElementLocalName { get; set; }

        /// <summary>
        /// Текущая дата и время
        /// </summary>
        [XmlElement(Order = 2)]
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Идентификатор нода
        /// </summary>
        [XmlElement(Order = 3)]
        public string NodeID { get; set; }

        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }
    }
}
