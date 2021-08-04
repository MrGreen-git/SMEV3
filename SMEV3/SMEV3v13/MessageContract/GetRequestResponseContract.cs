using SMEV3v13.Types;
using System.ComponentModel;
using System.ServiceModel;

namespace SMEV3v13.MessageContract
{
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(WrapperName = "GetRequestResponse", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3", IsWrapped = true)]
    public class GetRequestResponseContract
    {
        /// <summary/>
        protected GetRequestResponseContract() { }

        public GetRequestResponseContract(GetRequestResponseRequestMessage requestMessage)
        {
            RequestMessage = requestMessage;
        }

        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3", Order = 0)]
        public GetRequestResponseRequestMessage RequestMessage;
    }
}
