using SMEV3v12.Types.Basic;
using System;
using System.Xml.Serialization;

namespace SMEV3v12.Types.Faults
{
    [Serializable]
    [XmlType(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
    public class InvalidContent : SmevFault
    {
        /// <summary>
        /// Содержательная часть сообщения (например, в случае запроса - //AcceptRequestRequest/PrimaryContent/element())
        /// не прошла валидацию по XSD, заявленной для типа запроса.
        /// Действия СМЭВ: Сообщение будет направлено персоналу техподдержки для разбирательства.
        /// N.B.Сообщения могут отвергаться этим способом<b> только</b> по результатам валидации по XML-схеме.
        /// </summary>
        [XmlElement("ValidationError", Order = 0)]
        public ValidationError[] ValidationError { get; set; }
    }
}
