using System;
using System.Xml.Serialization;

namespace SMEV3v12.Types.Basic
{
    /// <summary>
    /// Ссылка на файл, приложенный к СМЭВ-сообщению.
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2")]
    public class RefAttachmentHeaderType
    {
        /// <summary>
        /// Идентификатор файла. Ссылка на соответствующий файл.
        /// </summary>
        [XmlElement(Order = 0)]
        public string uuid { get; set; }

        /// <summary>
        /// Хэш файла
        /// </summary>
        [XmlElement(Order = 1)]
        public string Hash { get; set; }

        /// <summary>
        /// Тип контента
        /// </summary>
        [XmlElement(Order = 2)]
        public string MimeType { get; set; }

        /// <summary>
        /// ЭЦП в формате PKCS#7 detached. Подписывать ключом ЭП-СП
        /// </summary>
        [XmlElement(DataType = "base64Binary", Order = 3)]
        public byte[] SignaturePKCS7 { get; set; }
    }
}
