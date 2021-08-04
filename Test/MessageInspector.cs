using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using System.ServiceModel;

namespace Test
{
    public class MessageInspector : IClientMessageInspector
    {
        public void AfterReceiveReply(ref Message reply, object correlationState)
        {

        }

        public object BeforeSendRequest(ref Message request, IClientChannel channel)
        {
            //var doc = new XmlDocument();
            //doc.InnerXml = request.ToString();
            //doc.Save("C:\\GitHub\\SMEV.xml");

            return null;
        }
    }
}
