using System;
using System.Xml.Serialization;

namespace SMEV3v12.Types.Basic
{
    [Serializable]
    [XmlType(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2")]
    public class FSAuthInfo
    {
        /// <summary>
        /// Идентификатор файла. Ссылка на соответствующий файл.
        /// </summary>
        [XmlElement(Order = 0)]
        public string uuid { get; set; }

        /// <summary>
        /// Пользователь
        /// </summary>
        [XmlElement(Order = 1)]
        public string UserName { get; set; }

        /// <summary>
        /// Пароль
        /// </summary>
        [XmlElement(Order = 2)]
        public string Password { get; set; }

        /// <summary>
        /// Имя файла
        /// </summary>
        [XmlElement(Order = 3)]
        public string FileName { get; set; }
    }
}
