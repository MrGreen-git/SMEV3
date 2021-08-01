using SMEV3v12.Types;
using System.ComponentModel;
using System.ServiceModel;
using System.Xml.Serialization;

namespace SMEV3v12.MessageContract
{
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(WrapperName = "GetResponseResponse", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", IsWrapped = true)]
    public class GetResponseResponseContract
    {
        public GetResponseResponseContract(GetResponseResponseResponseMessage item)
        {
            Item = item;
        }

        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", Order = 0)]
        [XmlElement("ResponseMessage")]
        public GetResponseResponseResponseMessage Item;
    }
}
