using SMEV3v11.Types.Basic;
using System;
using System.Xml.Serialization;

namespace SMEV3v11.Types.Faults
{
    /// <summary>
    /// Запрос с таким полным именем корневого элемента не поддерживается данной ИС.
    /// Вероятная причина: неверная настройка маршрутизации в СМЭВ.
    /// Действия СМЭВ: Сообщение будет направлено персоналу техподдержки СМЭВ для разбирательства.
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.1")]
    public class BusinessDataTypeIsNotSupported : SmevFault
    {
        /// <summary>
        /// Local name корневого элемента содержательной части запроса.
        /// </summary>
        [XmlElement(Order = 0)]
        public string RootElementLocalName { get; set; }

        /// <summary>
        /// Namespace URI корневого элемента содержательной части запроса.
        /// </summary>
        [XmlElement(Order = 1)]
        public string RootElementNamespaceURI { get; set; }
    }
}
