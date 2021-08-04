using System;
using System.Net.Mail;
using System.Xml.Serialization;

namespace SMEV3v12.Types.Basic
{
    /// <summary>
    /// Содержимое вложенного файла.
    /// Значение атрибута attachmentId должно быть уникально среди всех элементов и атрибутов СМЭВ-сообщения, имеющих тип xs:ID.
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2")]
    public class AttachmentContentType
    {
        [XmlElement(DataType = "ID", Order = 0)]
        public string Id { get; set; }

        /// <summary>
        /// "base64Binary" "application/octet-stream"
        /// </summary>
        [XmlElement(DataType = "base64Binary", Order = 1)]
        public byte[] Content { get; set; }
    }
}
