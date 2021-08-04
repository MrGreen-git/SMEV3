using SMEV3v12.Types;
using System.ComponentModel;
using System.ServiceModel;

namespace SMEV3v12.MessageContract
{
    /// <summary>
    /// Возвращаемая структура метода "получить сообщение из моей входящей очереди запросов, если очередь не пуста"
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(WrapperName = "GetRequestResponse", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", IsWrapped = true)]
    public class GetRequestResponseContract
    {
        /// <summary/>
        protected GetRequestResponseContract() { }

        public GetRequestResponseContract(GetRequestResponseRequestMessage requestMessage)
        {
            RequestMessage = requestMessage;
        }

        /// <summary>
        /// Полученное сообщение. Если этот элемент отсутствует, это значит, что входящая очередь пуста
        /// </summary>
        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", Order = 0)]
        public GetRequestResponseRequestMessage RequestMessage;
    }
}
