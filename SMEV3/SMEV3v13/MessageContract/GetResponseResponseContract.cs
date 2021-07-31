using SMEV3v13.Types;
using System.ComponentModel;
using System.ServiceModel;
using System.Xml.Serialization;

namespace SMEV3v13.MessageContract
{
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(WrapperName = "GetResponseResponse", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3", IsWrapped = true)]
    public class GetResponseResponseContract
    {
        public GetResponseResponseContract(GetResponseResponseResponseMessage item)
        {
            Item = item;
        }

        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3", Order = 0)]
        [XmlElement("ResponseMessage")]
        public GetResponseResponseResponseMessage Item;
    }
}
