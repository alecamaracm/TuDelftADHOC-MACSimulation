using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkSimulatorUI
{
    public static class Simulation
    {
        public static object locker=new object();

        public static Dictionary<int,BaseNode> nodes=new Dictionary<int, BaseNode>();
        public static int lastUsedNodeID = -1;
        public static int lastUsedMessageID = -1;

        public static Dictionary<int,OngoingMessage> messages = new Dictionary<int,OngoingMessage>();        
    }

    public class OngoingMessage
    {
        public int id;

        public byte[] data;
        public PointF origin;
        public float bytesSent=0;
        public float frontTravelledDistance=0;
        public float backTravelledDistance=0;

        public float originalPowerW = 0;

        public bool finished = false;

        public bool HasFinishedSending { get { return bytesSent >= data.Length || stopSending; } }

        public bool stopSending = false;

        public void StopSending()
        {
            stopSending = true;//This will force the message to stop sending (it will still propagate)
        }

        public float getPowerAt(float distance)
        {
            if (distance < 1) return originalPowerW;
            return (float)(originalPowerW * (1 / Math.Pow(distance ,2))); //Free space loss model
        }

        public float getDistanceFromNode(BaseNode node)
        {
            return (float)Math.Sqrt(Math.Pow(origin.X - node.location.X, 2) + Math.Pow(origin.Y - node.location.Y, 2));
        }

        public bool IsDetectedByNode(BaseNode node)
        {
            float distance = getDistanceFromNode(node);
            bool isWithinRange = distance > backTravelledDistance && distance < frontTravelledDistance;
            return isWithinRange;
        }
    }


    public abstract class BaseNode
    {
        public int id;
        public PointF location;

        public float drawTickTimeLeft = 0;
        public float drawErrorTimeLeft = 0;

        public List<int> messagesFailedToReceive = new List<int>();
        public List<int> messagesAlreadyReceived = new List<int>(); //To avoid receiving a message more than once
        public List<OngoingMessage> messagesBeingReceived = new List<OngoingMessage>();


        public List<OngoingMessage> currentlyBeingSentMessages = new List<OngoingMessage>();


        public void SimulateTick(List<OngoingMessage> receivingMessages,float messageSuccessProbability,float timeElapsed)
        {
            drawErrorTimeLeft -= timeElapsed;
            drawTickTimeLeft -= timeElapsed;

            foreach(var message in currentlyBeingSentMessages.ToList())
            {
                if (message.HasFinishedSending) currentlyBeingSentMessages.Remove(message);
            }

            if (receivingMessages.Count > 1)  //If there has been a collission mark those messages as not able to be received (because there has been a collision)
            {
                foreach (var message in receivingMessages)
                {
                    if (messagesFailedToReceive.Contains(message.id) == false)
                    {
                        drawErrorTimeLeft = 1;
                        messagesFailedToReceive.Add(message.id);
                    }
                }
                   
            }
            else
            {
                foreach (var message in receivingMessages)
                {
                    if (!messagesBeingReceived.Contains(message))
                    {
                        messagesBeingReceived.Add(message);
                    }
                }
            }


            foreach(var messageBeingReceived in messagesBeingReceived.ToList())
            {
                if (receivingMessages.Contains(messageBeingReceived) == false)
                {
                    messagesBeingReceived.Remove(messageBeingReceived);
                    if(messagesFailedToReceive.Contains(messageBeingReceived.id)==false && messagesAlreadyReceived.Contains(messageBeingReceived.id) == false)
                    {
                        if (Form1.random.NextDouble() < messageSuccessProbability)
                        {
                            MessageReceived(messageBeingReceived);                            
                            drawTickTimeLeft = 1;
                        }
                        else
                        {
                            drawErrorTimeLeft = 1;
                        }
                    }
                    messagesFailedToReceive.Remove(messageBeingReceived.id);
                    messagesAlreadyReceived.Add(messageBeingReceived.id);
                }
            }


            SimulateTickInternal(receivingMessages.Count > 0);
        }

        protected abstract void SimulateTickInternal(bool otherMessagesBeingReceived);
        protected abstract void MessageReceived(OngoingMessage message);
        public abstract void SendMessage(byte[] dataToSend);

        protected OngoingMessage SendRawMessage(byte[] dataToSend)
        {
            lock (Simulation.locker)
            {
                Simulation.lastUsedMessageID++;
                var message = new OngoingMessage()
                {
                    backTravelledDistance = 0,
                    frontTravelledDistance = 0,
                    bytesSent = 0,
                    data = dataToSend,
                    origin = location,
                    originalPowerW = 1,
                    id = Simulation.lastUsedMessageID
                };
                Simulation.messages.Add(Simulation.lastUsedMessageID, message);
                currentlyBeingSentMessages.Add(message);
                return message;
            }
           
        }
    }
}
