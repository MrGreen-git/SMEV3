using System;
using System.Xml.Serialization;

namespace SMEV3v12.Types.Basic
{
    /// <summary>
    /// Заголовки файлов, приложенных к СМЭВ-сообщению.
    /// Заголовки отделены от содержимого вложений.
    /// Это нужно потому, что заголовки должны попадать под ЭП-ОВ,
    /// а содержимое - должно не попадать(иначе не будет работать MTOM).
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2")]
    public class RefAttachmentHeaderList
    {
        [XmlElement("RefAttachmentHeader", Order = 0)]
        public RefAttachmentHeaderType[] RefAttachmentHeader { get; set; }
    }
}
