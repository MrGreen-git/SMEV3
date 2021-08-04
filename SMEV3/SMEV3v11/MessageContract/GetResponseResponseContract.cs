using SMEV3v11.Types;
using System.ComponentModel;
using System.ServiceModel;
using System.Xml.Serialization;

namespace SMEV3v11.MessageContract
{
    /// <summary>
    /// Возвращаемая структура метода "получить сообщение из моей входящей очереди, если очередь не пуста".
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(WrapperName = "GetResponseResponse", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1", IsWrapped = true)]
    public class GetResponseResponseContract
    {
        /// <summary/>
        protected GetResponseResponseContract() { }

        public GetResponseResponseContract(GetResponseResponseResponseMessage item)
        {
            Item = item;
        }

        /// <summary>
        /// Ответ, присланный поставщиком данных.
        /// </summary>
        [MessageBodyMember(Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1", Order = 0)]
        [XmlElement("ResponseMessage")]
        public GetResponseResponseResponseMessage Item; 
    }
}
