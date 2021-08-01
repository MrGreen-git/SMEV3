using SMEV3v11.Types;
using System.ComponentModel;
using System.ServiceModel;

namespace SMEV3v11.MessageContract
{
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(WrapperName = "GetRequestResponse", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1", IsWrapped = true)]
    public class GetRequestResponseContract
    {
        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1", Order = 0)]
        public GetRequestResponseRequestMessage RequestMessage;

        public GetRequestResponseContract(GetRequestResponseRequestMessage RequestMessage)
        {
            this.RequestMessage = RequestMessage;
        }
    }
}
