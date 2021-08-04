using System;
using System.Xml.Serialization;

namespace SMEV3v12.Types.Basic
{
    /// <summary>
    /// Cодержимое вложенных файлов.
    /// У элемента списка, тип base64Binary и наличие атрибута expectedContentTypes - подсказка для frameworks типа JAX-WS передавать содержимое этого элемента по MTOM протоколу.
    /// Кроме того, значение expectedContentTypes = "application/octet-stream" - подсказка JAX-WS дать доступ к этому элементу через InputStream/OutputStream.
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2")]
    public class AttachmentContentList
    {
        [XmlElement("AttachmentContent", Order = 0)]
        public AttachmentContentType[] AttachmentContent { get; set; }
    }
}
