using System;
using System.Xml.Serialization;

namespace SMEV3v11.Types.Faults
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.1")]
    public enum SignatureVerificationFaultEnum
    {
        /// <summary>
        /// Недопустимый формат SOAP-конверта: отсутствует soap:Header.
        /// Действия клиента: исправить ошибки в коде своей ИС.
        /// </summary>
        PoorSOAPEnvelopeFormat,

        /// <summary>
        /// ЭП-ОВ не найдена в документе.
        /// Действия клиента: исправить ошибки в коде своей ИС.
        /// </summary>
        NoSignatureFound,

        /// <summary>
        /// ЭП-ОВ подписывает не ту часть СМЭВ-сообщения, которую требуется подписать по спецификации СМЭВ.
        /// Действия клиента: исправить ошибки в коде своей ИС.
        /// </summary>
        IncorrectSignatureTarget,

        /// <summary>
        /// Некорректная структура XMLDSig, либо подписанный фрагмент XML-фрагмент не соответствует значению ЭП-ОВ.
        /// Действия клиента: исправить ошибки в коде своей ИС.
        /// </summary>
        SignatureIsInvalid,

        /// <summary>
        /// Не удалось найти сертификат клиента в ЕСИА.
        /// Действия клиента: обратиться в службу поддержки оператора СМЭВ.
        /// </summary>
        CertificateIsNotFound,

        /// <summary>
        /// Срок действия сертификата клиента истёк.
        /// Действия клиента: обратиться в удостоверяющий центр за новым сертификатом.
        /// </summary>
        CertificateIsExpired,
    }
}
