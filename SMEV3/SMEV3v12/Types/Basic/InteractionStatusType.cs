using System;
using System.Xml.Serialization;

namespace SMEV3v12.Types.Basic
{
    [Serializable]
    [XmlType(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2")]
    public enum InteractionStatusType
    {
        /// <summary>
        /// Запрос с таким Id не найден в БД СМЭВ
        /// </summary>
        doesNotExist,

        /// <summary>
        /// Запрос находится в очереди на асинхронную валидацию
        /// </summary>
        requestIsQueued,

        /// <summary>
        /// Запрос доставляется поставщику
        /// </summary>
        requestIsAcceptedBySmev,

        /// <summary>
        /// Запрос не прошёл асинхронную валидацию
        /// </summary>
        requestIsRejectedBySmev,

        /// <summary>
        /// Обрабатывается поставщиком сервиса
        /// </summary>
        underProcessing,

        /// <summary>
        /// Запрос выполнен ответ находится в очереди СМЭВ
        /// </summary>
        responseIsAcceptedBySmev,

        /// <summary>
        /// Запрос не прошёл асинхронную валидацию
        /// </summary>
        responseIsRejectedBySmev,

        /// <summary>
        /// Запрос отменён сервисом
        /// </summary>
        cancelled,

        /// <summary>
        /// Сообщение переведено в архив
        /// </summary>
        messageIsArchived,

        /// <summary>
        /// Сообщение получено получателем
        /// </summary>
        messageIsDelivered,
    }
}
