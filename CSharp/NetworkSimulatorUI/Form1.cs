using NetworkSimulatorUI.Protocols;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkSimulatorUI
{
    public partial class Form1 : Form
    {
        public bool fullRedraw = true;

        public readonly PointF zeroCoordinateLocation = new PointF(50, 40);

        public static Random random= new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;

            if (fullRedraw)
            {
                g.Clear(Color.White);
                DrawingMethods.DrawAxis(g, zeroCoordinateLocation);
                //fullRedraw = false;
            }

            lock (Simulation.locker)
            {
                Dictionary<int, List<OngoingMessage>> messagesBeingReceivedByID = Simulation.nodes.Values.Select(node => (node.id,
                    Simulation.messages.Where(p=>p.Value.IsDetectedByNode(node)).Select(p=>p.Value).ToList())).ToDictionary(item=>item.id,item=>item.Item2);

                foreach (var node in Simulation.nodes) DrawingMethods.DrawNode(node,messagesBeingReceivedByID[node.Key].Count,g, zeroCoordinateLocation);
                foreach (var message in Simulation.messages) DrawingMethods.DrawWave(message.Value, g, zeroCoordinateLocation);
            }           
        }

        private void checkBoxRenderEnabled_CheckedChanged(object sender, System.EventArgs e)
        {
            timerRender.Enabled= checkBoxRenderEnabled.Checked;
        }

        private void numericUpDownRenderInterval_ValueChanged(object sender, System.EventArgs e)
        {
            timerRender.Interval= (int)numericUpDownRenderInterval.Value;
        }

        private void timerRender_Tick(object sender, System.EventArgs e)
        {
            pictureBox1.Invalidate();
            labelFinalProbability.Text = Math.Round(Simulation.GetMessageSuccessProbability(),2).ToString();
            labelAverageNumberOfResends.Text = Math.Round(Simulation.GetAverageNumberOfResends(),2).ToString();
        }

        private void buttonRestartSimulation_Click(object sender, System.EventArgs e)
        {
            random = new Random((int)numericUpDownStartingSeed.Value);

            lock (Simulation.locker)
            {
                Simulation.messages.Clear();
                Simulation.nodes.Clear();
                Simulation.lastUsedMessageID = 0;
                Simulation.lastUsedNodeID = 0;

                Simulation.successCount = 0;
                Simulation.failedCount = 0;
                Simulation.resendCount = 0;
                Simulation.totalPaketsSent = 0;

                for(int i = 0; i < numericUpDownNodesToCreate.Value; i++)
                {
                    Simulation.lastUsedNodeID++;

                    BaseNode newNode;

                    if (radioButtonNONE.Checked)
                        newNode = new NormalNode();
                    else if (radioButtonALOHA.Checked)
                        newNode = new AlohaNode();
                    else if (radioButtonCSMA_CD.Checked)
                        newNode = new CSMA_CD();
                    else
                        throw new Exception("Node type not selected");

                    newNode.id = Simulation.lastUsedNodeID;
                    newNode.location = new PointF(random.Next(100, (int)numericUpDownWorldSizeX.Value - 100), random.Next(100, (int)numericUpDownWorldSizeY.Value - 100));

                    Simulation.nodes.Add(Simulation.lastUsedNodeID, newNode);
                }
            }


            if (checkBoxRandomMessages.Checked)
            {
                foreach(var node in Simulation.nodes)
                {
                    Task.Run(() => {

                        //Avoid all the nodes starting at the same time
                        Thread.Sleep(Form1.random.Next(1, (int)numericUpDownMaxInterval.Value/(int)numericUpDownTimeScale.Value));                      

                        while (true){
                            lock (Simulation.locker)
                            {
                                node.Value.SendMessage(new byte[(int)numericUpDownRandomSize.Value / (int)numericUpDownTimeScale.Value]);
                            }
                        
                            Thread.Sleep(Form1.random.Next((int)((float)numericUpDownMaxInterval.Value*0.5), (int)numericUpDownMaxInterval.Value));
                        }

                    });
                }
            }
            else
            {
                List<string> data = textBoxSimulationCommands.Lines.ToList();

                Task.Run(() => {

                    while (data.Count > 0)
                    {
                        string line = data[0].ToLower();
                        data.RemoveAt(0);
                        var tokens = line.Split(' ');

                        try
                        {


                            switch (tokens[0])
                            {
                                case "sleep":
                                    System.Threading.Thread.Sleep((int)(int.Parse(tokens[1])/(float)numericUpDownTimeScale.Value));
                                    break;
                                case "send":
                                    this.Invoke((MethodInvoker)delegate () {
                                        int sendingID = int.Parse(tokens[1]);
                                        int packetSize = int.Parse(tokens[2]);
                                        Simulation.nodes[sendingID].SendMessage(new byte[packetSize]);
                                    });
                                    break;
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("An error has ocurred on the simulation command loop! " + ex.Message);
                        }

                    }
                });
            }            
        }

        void UpdateWorker()
        {

        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            timerUpdate.Stop();
            if (checkBoxCPUkiller.Checked)
            {
                for (int i = 0; i < 10; i++) DoUpdateTick();
            }
            else
            {
                DoUpdateTick();
            }
            timerUpdate.Start();
        }

        private void DoUpdateTick()
        {
            try
            {
                float timeElapsed = ((float)timerUpdate.Interval / 1000) * (float)numericUpDownTimeScale.Value;
                lock (Simulation.locker)
                {
                    Dictionary<int, List<OngoingMessage>> messagesBeingReceivedByNodeID = Simulation.nodes.Values.Select(node => (node.id,
                       Simulation.messages.Where(p => p.Value.IsDetectedByNode(node)).Select(p => p.Value).ToList())).ToDictionary(item => item.id, item => item.Item2);

                    foreach (var node in Simulation.nodes)
                    {
                        node.Value.SimulateTick(messagesBeingReceivedByNodeID[node.Key], (float)numericUpDownTransmissionProbability.Value, timeElapsed, (float)numericUpDownTimeScale.Value*(checkBoxCPUkiller.Checked?10:1));
                    }

                    List<OngoingMessage> messagesToRemove = new List<OngoingMessage>();

                    foreach (var message in Simulation.messages.Values)
                    {
                        if (message.bytesSent < message.data.Length && !message.stopSending)
                        {
                            message.bytesSent += (float)numericUpDownTransmissionSpeed.Value * timeElapsed;
                        }
                        else
                        {
                            message.backTravelledDistance += (float)numericUpDownLightSpeed.Value * timeElapsed;
                        }
                        message.frontTravelledDistance += (float)numericUpDownLightSpeed.Value * timeElapsed;

                        if (message.getPowerAt(message.backTravelledDistance) <= (float)(numericUpDownBackgroundNoisemW.Value / 1000)) messagesToRemove.Add(message);
                    }

                    foreach (var messageToRemove in messagesToRemove)
                    {
                        Simulation.messages.Remove(messageToRemove.id);
                    }
                }
            }
            catch (Exception)
            {

            }
           
        }

        private void checkBoxSimulationEnabled_CheckedChanged(object sender, EventArgs e)
        {
            timerUpdate.Enabled=checkBoxSimulationEnabled.Checked;
        }

        private void buttonSendPacketSend_Click(object sender, EventArgs e)
        {
            lock (Simulation.locker)
            {
                if(Simulation.nodes.TryGetValue((int)numericUpDownSendPacketID.Value, out BaseNode node))
                {
                    node.SendMessage(new byte[(int)numericUpDownSendPacketSize.Value]);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.SetOut(new ControlWriter(textBoxLogOutput));
        }

        private void buttonClearLogs_Click(object sender, EventArgs e)
        {
            textBoxLogOutput.Clear();
        }

        private void labelFinalProbability_Click(object sender, EventArgs e)
        {

        }

        private void labelAverageNumberOfResends_Click(object sender, EventArgs e)
        {

        }
    }

    public class ControlWriter : TextWriter
    {
        private Control textbox;
        public ControlWriter(Control textbox)
        {
            this.textbox = textbox;
        }

        public override void Write(char value)
        {
            if (textbox.Text.Length > 1500) textbox.Text="";
            textbox.Text += value;
        }

        public override void Write(string value)
        {
            textbox.Text += value;
        }

        public override Encoding Encoding
        {
            get { return Encoding.ASCII; }
        }
    }
}
