using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkSimulatorUI.Protocols
{
    public class NormalNode : BaseNode
    {
        protected override void SendMessageInternal(byte[] dataToSend)
        {
            SendRawMessage(dataToSend);
        }

        protected override void MessageReceived(OngoingMessage message)
        {
            Console.WriteLine($"Received message {message.id} from {message.origin} with {message.data.Length} bytes of data on a NORMAL node.");
        }


        protected override void SimulateTickInternal(bool otherMessagesBeingReceived, float timeScale)
        {
        }
    }
}
