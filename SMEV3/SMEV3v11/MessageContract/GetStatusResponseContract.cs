using SMEV3v11.Types;
using System.ComponentModel;
using System.ServiceModel;

namespace SMEV3v11.MessageContract
{
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(WrapperName = "GetStatusResponse", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1", IsWrapped = true)]
    public class GetStatusResponseContract
    {
        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1", Order = 0)]
        public SmevAsyncProcessingMessage SmevAsyncProcessingMessage;

        public GetStatusResponseContract(SmevAsyncProcessingMessage SmevAsyncProcessingMessage)
        {
            this.SmevAsyncProcessingMessage = SmevAsyncProcessingMessage;
        }
    }
}
