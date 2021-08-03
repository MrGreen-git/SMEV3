using SMEV3v11.Types;
using System.ComponentModel;
using System.ServiceModel;

namespace SMEV3v11.MessageContract
{
    /// <summary>
    /// Возвращаемая структура метода "получить сообщение из моей входящей очереди запросов, если очередь не пуста"
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(WrapperName = "GetRequestResponse", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1", IsWrapped = true)]
    public class GetRequestResponseContract
    {
        public GetRequestResponseContract(GetRequestResponseRequestMessage requestMessage)
        {
            RequestMessage = requestMessage;
        }

        /// <summary>
        /// Полученное сообщение. Если этот элемент отсутствует, это значит, что входящая очередь пуста.
        /// </summary>
        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1", Order = 0)]
        public GetRequestResponseRequestMessage RequestMessage;
    }
}
