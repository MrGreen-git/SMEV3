using SMEV3v11.Types.Basic;
using System;
using System.Xml.Serialization;

namespace SMEV3v11.Types.Faults
{
    /// <summary>
    /// Входящая очередь получателя переполнена.
    /// Обратиться в службу техподдержки СМЭВ, продолжать посылать сообщение.
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.1")]
    public class DestinationOverflow : SmevFault
    {
        [XmlElement(Order = 0)]
        public string MessageBrokerAddress { get; set; }

        [XmlElement(Order = 1)]
        public string DestinationName { get; set; }
    }
}
