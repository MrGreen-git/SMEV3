using SMEV3v11.Types.Basic;
using System;
using System.Xml.Serialization;

namespace SMEV3v11.Types.Faults
{
    /// <summary>
    /// Содержательная часть сообщения (например, в случае запроса - //AcceptRequestRequest/PrimaryContent/element())
    /// не прошла валидацию по XSD, заявленной для типа запроса.
    /// Действия СМЭВ: Сообщение будет направлено персоналу техподдержки для разбирательства.
    /// N.B.Сообщения могут отвергаться этим способом<b> только</b> по результатам валидации по XML-схеме.
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.1")]
    public class InvalidContent : SmevFault
    {
        /// <summary>
        /// Сообщение об ошибке валидации. Текстовое содержимое элемента должно содержать сообщение об ошибке, возвращённое валидатором.
        /// </summary>
        [XmlElement("ValidationError", Order = 0)]
        public ValidationError[] ValidationError { get; set; }
    }
}
