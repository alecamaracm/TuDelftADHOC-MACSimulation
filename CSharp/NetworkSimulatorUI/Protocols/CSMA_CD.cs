using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkSimulatorUI.Protocols
{
    public class CSMA_CD:BaseNode
    {
        public List<byte[]> frameReadyToBeSent = new List<byte[]>();


        public (DateTime whenToSend, byte[] dataToResend) messageToSendLater;
        public bool meessageSheduledToBeSentLater = false;

        public int retransmissionCount = 0;

        public OngoingMessage messageBeingSent = null;

        protected override void SendMessageInternal(byte[] dataToSend) //This will be called whenever a message needs to be sent (Ex. a sensor has new data)
        {
            frameReadyToBeSent.Add(dataToSend);           
        }

        protected override void SimulateTickInternal(bool otherMessagesBeingReceived, float timeScale)
        {
            if (messageBeingSent != null && messageBeingSent.HasFinishedSending) messageBeingSent = null;

            if(otherMessagesBeingReceived == false && messageBeingSent==null && meessageSheduledToBeSentLater==false) //No intereference and no other message being sent
            {
                if(frameReadyToBeSent.Count> 0)
                {

                    retransmissionCount = 0;
                    messageBeingSent = SendRawMessage(frameReadyToBeSent[0]); //Send the packet
                    Console.WriteLine("Starting to send CSMA_CD message");
                    frameReadyToBeSent.RemoveAt(0);

                }        
            }



            if (otherMessagesBeingReceived && messageBeingSent!=null) //Interference incoming from other nodes, so stop sending the current message
            {
                Simulation.failedCount++;
                messageBeingSent.StopSending();
                retransmissionCount++;
                messageToSendLater=(DateTime.Now.AddMilliseconds((600*retransmissionCount)*timeScale), messageBeingSent.data); //Schedule message to be sent later
                meessageSheduledToBeSentLater = true;
                Simulation.resendCount++;
                Console.WriteLine($"Detected interference in CSMA_CD node {id}. Sending message {5 * retransmissionCount} seconds later...");
                messageBeingSent = null;

            }

            if (!otherMessagesBeingReceived && meessageSheduledToBeSentLater && DateTime.Now >= messageToSendLater.whenToSend)
            {
                meessageSheduledToBeSentLater = false;
                messageBeingSent = SendRawMessage(messageToSendLater.dataToResend);
                Console.WriteLine($"Resending CSMA_CD message as scheduled.");
                
            }   
        }

        protected override void MessageReceived(OngoingMessage message)
        {
            Console.WriteLine($"Received message {message.id} from {message.origin} with {message.data.Length} bytes of data on a ALOHA node.");
        }
    }
}
