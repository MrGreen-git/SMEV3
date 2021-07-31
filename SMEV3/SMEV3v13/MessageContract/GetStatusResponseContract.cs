using SMEV3v13.Types;
using System.ComponentModel;
using System.ServiceModel;

namespace SMEV3v13.MessageContract
{
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(WrapperName = "GetStatusResponse", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3", IsWrapped = true)]
    public class GetStatusResponseContract
    {
        public GetStatusResponseContract(SmevAsyncProcessingMessage smevAsyncProcessingMessage)
        {
            SmevAsyncProcessingMessage = smevAsyncProcessingMessage;
        }

        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.3", Order = 0)]
        public SmevAsyncProcessingMessage SmevAsyncProcessingMessage;
    }
}
