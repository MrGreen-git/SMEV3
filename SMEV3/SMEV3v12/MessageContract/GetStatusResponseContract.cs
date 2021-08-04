using SMEV3v12.Types;
using System.ComponentModel;
using System.ServiceModel;

namespace SMEV3v12.MessageContract
{
    /// <summary>
    /// Возвращаемая структура метода "получить сообщение из моей входящей очереди запросов, если очередь не пуста"
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(WrapperName = "GetStatusResponse", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", IsWrapped = true)]
    public class GetStatusResponseContract
    {
        /// <summary/>
        protected GetStatusResponseContract() { }

        public GetStatusResponseContract(SmevAsyncProcessingMessage smevAsyncProcessingMessage)
        {
            SmevAsyncProcessingMessage = smevAsyncProcessingMessage;
        }

        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", Order = 0)]
        public SmevAsyncProcessingMessage SmevAsyncProcessingMessage;
    }
}
