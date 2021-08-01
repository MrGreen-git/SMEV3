using System.Runtime.Serialization;

namespace SMEV3v11.DataContract
{
    [DataContract(Name = "BusinessDataTypeIsNotSupported", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.1")]
    public class BusinessDataTypeIsNotSupported : SmevFault
    {
        [DataMember(IsRequired = true, EmitDefaultValue = false)]
        public string RootElementLocalName { get; set; }

        [DataMember(IsRequired = true, EmitDefaultValue = false)]
        public string RootElementNamespaceURI { get; set; }
    }
}
