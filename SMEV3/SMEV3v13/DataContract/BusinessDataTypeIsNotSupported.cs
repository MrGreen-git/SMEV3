using System.Runtime.Serialization;

namespace SMEV3v13.DataContract
{
    [DataContract(Name = "BusinessDataTypeIsNotSupported", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    public class BusinessDataTypeIsNotSupported : SmevFault
    {
        [DataMember(IsRequired = true, EmitDefaultValue = false)]
        public string RootElementLocalName { get; set; }

        [DataMember(IsRequired = true, EmitDefaultValue = false)]
        public string RootElementNamespaceURI { get; set; }
    }
}
