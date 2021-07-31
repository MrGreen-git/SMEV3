using System.Runtime.Serialization;

namespace SMEV3v13.DataContract
{
    [DataContract(Name = "DestinationOverflow", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    public class DestinationOverflow : SmevFault
    {
        [DataMember(IsRequired = true, EmitDefaultValue = false)]
        public string MessageBrokerAddress { get; set; }

        [DataMember(IsRequired = true, EmitDefaultValue = false, Order = 1)]
        public string DestinationName { get; set; }
    }
}
