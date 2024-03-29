﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkSimulatorUI.Protocols
{
    public class AlohaNode:BaseNode
    {        
        public List<(DateTime whenToSend, byte[] dataToResend)> messagesToSendLater = new List<(DateTime whenToSend, byte[] dataToResend)>();

        protected override void SendMessageInternal(byte[] dataToSend) //This will be called whenever a message needs to be sent (Ex. a sensor has new data)
        {
            SendRawMessage(dataToSend);
        }

        protected override void SimulateTickInternal(bool otherMessagesBeingReceived, float timeScale)
        {  
            if (otherMessagesBeingReceived) //Interference incoming from other nodes, so stop sending
            {
                foreach (var message in currentlyBeingSentMessages)
                {
                    Simulation.failedCount++;
                    message.StopSending();
                    messagesToSendLater.Add((DateTime.Now.AddMilliseconds(Form1.random.Next(500,3000)/ timeScale), message.data)); //Schedure message to be sent later
                    Console.WriteLine($"Detected interference in ALOHA node {id}. Sending message {message.id} later...");
                }
            }

            foreach (var messageToSendLater in messagesToSendLater.ToList()) //Send messages scheduled to be send later if neccessary
            {
                if (DateTime.Now >= messageToSendLater.whenToSend)
                {
                    messagesToSendLater.Remove(messageToSendLater);
                    SendMessageInternal(messageToSendLater.dataToResend);
                    Console.WriteLine($"Resending ALOHA message as scheduled.");
                    Simulation.resendCount++;
                }
            }
        }

        protected override void MessageReceived(OngoingMessage message)
        {
            Console.WriteLine($"Received message {message.id} from {message.origin} with {message.data.Length} bytes of data on a ALOHA node.");
        }
    }
}
