using SMEV3v11.Types.Basic;
using System;
using System.Xml.Serialization;

namespace SMEV3v11.Types.Faults
{
    /// <summary>
    /// ЭП-ОВ не прошла проверку.
    /// Действия клиента зависят от кода ошибки верификации.
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.1")]
    public class SignatureVerificationFault : SmevFault
    {
        [XmlElement("SignatureVerificationFault", Order = 0)]
        public SignatureVerificationFaultEnum SignatureVerificationFault1 { get; set; }
    }
}
