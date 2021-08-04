using SMEV3v12.Types;
using System.ComponentModel;
using System.ServiceModel;

namespace SMEV3v12.MessageContract
{
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(WrapperName = "GetRequestResponse", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", IsWrapped = true)]
    public class GetRequestResponseContract
    {
        protected GetRequestResponseContract() { }

        public GetRequestResponseContract(GetRequestResponseRequestMessage requestMessage)
        {
            RequestMessage = requestMessage;
        }

        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", Order = 0)]
        public GetRequestResponseRequestMessage RequestMessage;
    }
}
