using System;
using System.Xml.Serialization;

namespace SMEV3v12.Types.Basic
{
    /// <summary>
    /// Файл, приложенный к СМЭВ-сообщению.
    /// Имя файла не передаётся; вложения идентифицируются только идентификаторами внутри сообщения.
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2")]
    public class AttachmentHeaderType
    {
        /// <summary>
        /// Идентификатор вложения. Ссылка на соответствующий //AttachmentContent/@Id
        /// </summary>
        [XmlElement(Order = 0)]
        public string contentId { get; set; }

        /// <summary>
        /// Тип контента.
        /// </summary>
        [XmlElement(Order = 1)]
        public string MimeType { get; set; }

        /// <summary>
        /// ЭЦП в формате PKCS#7 detached. Подписывать ключом ЭП-СП.
        /// </summary>
        [XmlElement(DataType = "base64Binary", Order = 2)]
        public byte[] SignaturePKCS7 { get; set; }
    }
}
