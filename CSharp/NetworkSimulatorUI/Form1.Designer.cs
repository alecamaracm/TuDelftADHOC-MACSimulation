namespace NetworkSimulatorUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownWorldSizeY = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDownLightSpeed = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownWorldSizeX = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonRestartSimulation = new System.Windows.Forms.Button();
            this.checkBoxRenderEnabled = new System.Windows.Forms.CheckBox();
            this.numericUpDownRenderInterval = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxSimulationEnabled = new System.Windows.Forms.CheckBox();
            this.numericUpDownTimeScale = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxSimulationCommands = new System.Windows.Forms.TextBox();
            this.radioButtonCSMA_CD = new System.Windows.Forms.RadioButton();
            this.radioButtonNONE = new System.Windows.Forms.RadioButton();
            this.radioButtonALOHA = new System.Windows.Forms.RadioButton();
            this.numericUpDownStartingSeed = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownNodesToCreate = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonClearLogs = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxLogOutput = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.numericUpDownSendPacketID = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDownSendPacketSize = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonSendPacketSend = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.numericUpDownTransmissionProbability = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDownTransmissionSpeed = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownBackgroundNoisemW = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.timerRender = new System.Windows.Forms.Timer(this.components);
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWorldSizeY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLightSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWorldSizeX)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRenderInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeScale)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartingSeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNodesToCreate)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSendPacketID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSendPacketSize)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTransmissionProbability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTransmissionSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBackgroundNoisemW)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(348, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1144, 527);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownWorldSizeY);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.numericUpDownLightSpeed);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDownWorldSizeX);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 142);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "World settings";
            // 
            // numericUpDownWorldSizeY
            // 
            this.numericUpDownWorldSizeY.Location = new System.Drawing.Point(218, 26);
            this.numericUpDownWorldSizeY.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownWorldSizeY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownWorldSizeY.Name = "numericUpDownWorldSizeY";
            this.numericUpDownWorldSizeY.Size = new System.Drawing.Size(62, 22);
            this.numericUpDownWorldSizeY.TabIndex = 6;
            this.numericUpDownWorldSizeY.Value = new decimal(new int[] {
            350,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(199, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 16);
            this.label11.TabIndex = 5;
            this.label11.Text = "x";
            // 
            // numericUpDownLightSpeed
            // 
            this.numericUpDownLightSpeed.Location = new System.Drawing.Point(165, 54);
            this.numericUpDownLightSpeed.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownLightSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLightSpeed.Name = "numericUpDownLightSpeed";
            this.numericUpDownLightSpeed.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownLightSpeed.TabIndex = 3;
            this.numericUpDownLightSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Speed of light (m/s):";
            // 
            // numericUpDownWorldSizeX
            // 
            this.numericUpDownWorldSizeX.Location = new System.Drawing.Point(135, 26);
            this.numericUpDownWorldSizeX.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownWorldSizeX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownWorldSizeX.Name = "numericUpDownWorldSizeX";
            this.numericUpDownWorldSizeX.Size = new System.Drawing.Size(62, 22);
            this.numericUpDownWorldSizeX.TabIndex = 2;
            this.numericUpDownWorldSizeX.Value = new decimal(new int[] {
            750,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "World size (m):";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.buttonRestartSimulation);
            this.groupBox2.Controls.Add(this.checkBoxRenderEnabled);
            this.groupBox2.Controls.Add(this.numericUpDownRenderInterval);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.checkBoxSimulationEnabled);
            this.groupBox2.Controls.Add(this.numericUpDownTimeScale);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 376);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 163);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Simulation controls";
            // 
            // buttonRestartSimulation
            // 
            this.buttonRestartSimulation.Font = new System.Drawing.Font("Segoe UI Semibold", 9.792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestartSimulation.Location = new System.Drawing.Point(75, 58);
            this.buttonRestartSimulation.Name = "buttonRestartSimulation";
            this.buttonRestartSimulation.Size = new System.Drawing.Size(167, 35);
            this.buttonRestartSimulation.TabIndex = 8;
            this.buttonRestartSimulation.Text = "(Re)Start";
            this.buttonRestartSimulation.UseVisualStyleBackColor = true;
            this.buttonRestartSimulation.Click += new System.EventHandler(this.buttonRestartSimulation_Click);
            // 
            // checkBoxRenderEnabled
            // 
            this.checkBoxRenderEnabled.AutoSize = true;
            this.checkBoxRenderEnabled.Checked = true;
            this.checkBoxRenderEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRenderEnabled.Location = new System.Drawing.Point(171, 102);
            this.checkBoxRenderEnabled.Name = "checkBoxRenderEnabled";
            this.checkBoxRenderEnabled.Size = new System.Drawing.Size(127, 20);
            this.checkBoxRenderEnabled.TabIndex = 9;
            this.checkBoxRenderEnabled.Text = "Render enabled";
            this.checkBoxRenderEnabled.UseVisualStyleBackColor = true;
            this.checkBoxRenderEnabled.CheckedChanged += new System.EventHandler(this.checkBoxRenderEnabled_CheckedChanged);
            // 
            // numericUpDownRenderInterval
            // 
            this.numericUpDownRenderInterval.Location = new System.Drawing.Point(160, 128);
            this.numericUpDownRenderInterval.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownRenderInterval.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericUpDownRenderInterval.Name = "numericUpDownRenderInterval";
            this.numericUpDownRenderInterval.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownRenderInterval.TabIndex = 7;
            this.numericUpDownRenderInterval.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownRenderInterval.ValueChanged += new System.EventHandler(this.numericUpDownRenderInterval_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Render interval (ms):";
            // 
            // checkBoxSimulationEnabled
            // 
            this.checkBoxSimulationEnabled.AutoSize = true;
            this.checkBoxSimulationEnabled.Checked = true;
            this.checkBoxSimulationEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSimulationEnabled.Location = new System.Drawing.Point(9, 102);
            this.checkBoxSimulationEnabled.Name = "checkBoxSimulationEnabled";
            this.checkBoxSimulationEnabled.Size = new System.Drawing.Size(144, 20);
            this.checkBoxSimulationEnabled.TabIndex = 6;
            this.checkBoxSimulationEnabled.Text = "Simulation enabled";
            this.checkBoxSimulationEnabled.UseVisualStyleBackColor = true;
            this.checkBoxSimulationEnabled.CheckedChanged += new System.EventHandler(this.checkBoxSimulationEnabled_CheckedChanged);
            // 
            // numericUpDownTimeScale
            // 
            this.numericUpDownTimeScale.DecimalPlaces = 2;
            this.numericUpDownTimeScale.Location = new System.Drawing.Point(110, 26);
            this.numericUpDownTimeScale.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownTimeScale.Name = "numericUpDownTimeScale";
            this.numericUpDownTimeScale.Size = new System.Drawing.Size(168, 22);
            this.numericUpDownTimeScale.TabIndex = 2;
            this.numericUpDownTimeScale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Time scale:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.textBoxSimulationCommands);
            this.groupBox3.Controls.Add(this.radioButtonCSMA_CD);
            this.groupBox3.Controls.Add(this.radioButtonNONE);
            this.groupBox3.Controls.Add(this.radioButtonALOHA);
            this.groupBox3.Controls.Add(this.numericUpDownStartingSeed);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.numericUpDownNodesToCreate);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(21, 710);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(715, 221);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Simulation input";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9.792F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(25, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(180, 23);
            this.label13.TabIndex = 15;
            this.label13.Text = "Simulation commands";
            // 
            // textBoxSimulationCommands
            // 
            this.textBoxSimulationCommands.Location = new System.Drawing.Point(28, 108);
            this.textBoxSimulationCommands.Multiline = true;
            this.textBoxSimulationCommands.Name = "textBoxSimulationCommands";
            this.textBoxSimulationCommands.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSimulationCommands.Size = new System.Drawing.Size(663, 104);
            this.textBoxSimulationCommands.TabIndex = 14;
            this.textBoxSimulationCommands.Text = "SEND 1 3\r\nSLEEP 1500\r\nSEND 3 3\r\nSLEEP 5000\r\nSEND 1 3";
            // 
            // radioButtonCSMA_CD
            // 
            this.radioButtonCSMA_CD.AutoSize = true;
            this.radioButtonCSMA_CD.Checked = true;
            this.radioButtonCSMA_CD.Location = new System.Drawing.Point(397, 64);
            this.radioButtonCSMA_CD.Name = "radioButtonCSMA_CD";
            this.radioButtonCSMA_CD.Size = new System.Drawing.Size(89, 20);
            this.radioButtonCSMA_CD.TabIndex = 13;
            this.radioButtonCSMA_CD.TabStop = true;
            this.radioButtonCSMA_CD.Text = "CSMA/CD";
            this.radioButtonCSMA_CD.UseVisualStyleBackColor = true;
            // 
            // radioButtonNONE
            // 
            this.radioButtonNONE.AutoSize = true;
            this.radioButtonNONE.Location = new System.Drawing.Point(236, 64);
            this.radioButtonNONE.Name = "radioButtonNONE";
            this.radioButtonNONE.Size = new System.Drawing.Size(67, 20);
            this.radioButtonNONE.TabIndex = 12;
            this.radioButtonNONE.Text = "NONE";
            this.radioButtonNONE.UseVisualStyleBackColor = true;
            // 
            // radioButtonALOHA
            // 
            this.radioButtonALOHA.AutoSize = true;
            this.radioButtonALOHA.Location = new System.Drawing.Point(318, 64);
            this.radioButtonALOHA.Name = "radioButtonALOHA";
            this.radioButtonALOHA.Size = new System.Drawing.Size(73, 20);
            this.radioButtonALOHA.TabIndex = 11;
            this.radioButtonALOHA.Text = "ALOHA";
            this.radioButtonALOHA.UseVisualStyleBackColor = true;
            // 
            // numericUpDownStartingSeed
            // 
            this.numericUpDownStartingSeed.Location = new System.Drawing.Point(621, 26);
            this.numericUpDownStartingSeed.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownStartingSeed.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDownStartingSeed.Name = "numericUpDownStartingSeed";
            this.numericUpDownStartingSeed.Size = new System.Drawing.Size(70, 22);
            this.numericUpDownStartingSeed.TabIndex = 9;
            this.numericUpDownStartingSeed.Value = new decimal(new int[] {
            54,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(515, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Random seed:\r\n";
            // 
            // numericUpDownNodesToCreate
            // 
            this.numericUpDownNodesToCreate.Location = new System.Drawing.Point(219, 26);
            this.numericUpDownNodesToCreate.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownNodesToCreate.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDownNodesToCreate.Name = "numericUpDownNodesToCreate";
            this.numericUpDownNodesToCreate.Size = new System.Drawing.Size(70, 22);
            this.numericUpDownNodesToCreate.TabIndex = 7;
            this.numericUpDownNodesToCreate.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Number of nodes to create:\r\n";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.buttonClearLogs);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.textBoxLogOutput);
            this.groupBox4.Location = new System.Drawing.Point(751, 710);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(741, 221);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Simulation  output";
            // 
            // buttonClearLogs
            // 
            this.buttonClearLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearLogs.Font = new System.Drawing.Font("Segoe UI", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearLogs.Location = new System.Drawing.Point(590, 14);
            this.buttonClearLogs.Name = "buttonClearLogs";
            this.buttonClearLogs.Size = new System.Drawing.Size(145, 34);
            this.buttonClearLogs.TabIndex = 10;
            this.buttonClearLogs.Text = "Clear logs";
            this.buttonClearLogs.UseVisualStyleBackColor = true;
            this.buttonClearLogs.Click += new System.EventHandler(this.buttonClearLogs_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 9.792F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 23);
            this.label14.TabIndex = 16;
            this.label14.Text = "Log output";
            // 
            // textBoxLogOutput
            // 
            this.textBoxLogOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLogOutput.Location = new System.Drawing.Point(6, 52);
            this.textBoxLogOutput.Multiline = true;
            this.textBoxLogOutput.Name = "textBoxLogOutput";
            this.textBoxLogOutput.ReadOnly = true;
            this.textBoxLogOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLogOutput.Size = new System.Drawing.Size(726, 160);
            this.textBoxLogOutput.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Location = new System.Drawing.Point(12, 545);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1471, 159);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Manual controls";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.numericUpDownSendPacketID);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.numericUpDownSendPacketSize);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.buttonSendPacketSend);
            this.groupBox7.Location = new System.Drawing.Point(12, 26);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(200, 122);
            this.groupBox7.TabIndex = 11;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Send packet";
            // 
            // numericUpDownSendPacketID
            // 
            this.numericUpDownSendPacketID.Location = new System.Drawing.Point(99, 24);
            this.numericUpDownSendPacketID.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownSendPacketID.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDownSendPacketID.Name = "numericUpDownSendPacketID";
            this.numericUpDownSendPacketID.Size = new System.Drawing.Size(70, 22);
            this.numericUpDownSendPacketID.TabIndex = 13;
            this.numericUpDownSendPacketID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "From (ID):";
            // 
            // numericUpDownSendPacketSize
            // 
            this.numericUpDownSendPacketSize.Location = new System.Drawing.Point(98, 51);
            this.numericUpDownSendPacketSize.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownSendPacketSize.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDownSendPacketSize.Name = "numericUpDownSendPacketSize";
            this.numericUpDownSendPacketSize.Size = new System.Drawing.Size(70, 22);
            this.numericUpDownSendPacketSize.TabIndex = 11;
            this.numericUpDownSendPacketSize.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Size (B):";
            // 
            // buttonSendPacketSend
            // 
            this.buttonSendPacketSend.Font = new System.Drawing.Font("Segoe UI Semibold", 9.792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSendPacketSend.Location = new System.Drawing.Point(18, 79);
            this.buttonSendPacketSend.Name = "buttonSendPacketSend";
            this.buttonSendPacketSend.Size = new System.Drawing.Size(167, 35);
            this.buttonSendPacketSend.TabIndex = 10;
            this.buttonSendPacketSend.Text = "Send";
            this.buttonSendPacketSend.UseVisualStyleBackColor = true;
            this.buttonSendPacketSend.Click += new System.EventHandler(this.buttonSendPacketSend_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox6.Controls.Add(this.numericUpDownTransmissionProbability);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.numericUpDownTransmissionSpeed);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.numericUpDownBackgroundNoisemW);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Location = new System.Drawing.Point(12, 166);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(312, 204);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Device (node) networking settings";
            // 
            // numericUpDownTransmissionProbability
            // 
            this.numericUpDownTransmissionProbability.DecimalPlaces = 3;
            this.numericUpDownTransmissionProbability.Location = new System.Drawing.Point(192, 82);
            this.numericUpDownTransmissionProbability.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownTransmissionProbability.Name = "numericUpDownTransmissionProbability";
            this.numericUpDownTransmissionProbability.Size = new System.Drawing.Size(94, 22);
            this.numericUpDownTransmissionProbability.TabIndex = 9;
            this.numericUpDownTransmissionProbability.Value = new decimal(new int[] {
            9,
            0,
            0,
            65536});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(157, 16);
            this.label12.TabIndex = 8;
            this.label12.Text = "Transmission probability:";
            // 
            // numericUpDownTransmissionSpeed
            // 
            this.numericUpDownTransmissionSpeed.Location = new System.Drawing.Point(192, 54);
            this.numericUpDownTransmissionSpeed.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownTransmissionSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTransmissionSpeed.Name = "numericUpDownTransmissionSpeed";
            this.numericUpDownTransmissionSpeed.Size = new System.Drawing.Size(94, 22);
            this.numericUpDownTransmissionSpeed.TabIndex = 5;
            this.numericUpDownTransmissionSpeed.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Transmission speed (B/s):";
            // 
            // numericUpDownBackgroundNoisemW
            // 
            this.numericUpDownBackgroundNoisemW.DecimalPlaces = 3;
            this.numericUpDownBackgroundNoisemW.Location = new System.Drawing.Point(192, 26);
            this.numericUpDownBackgroundNoisemW.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownBackgroundNoisemW.Name = "numericUpDownBackgroundNoisemW";
            this.numericUpDownBackgroundNoisemW.Size = new System.Drawing.Size(94, 22);
            this.numericUpDownBackgroundNoisemW.TabIndex = 5;
            this.numericUpDownBackgroundNoisemW.Value = new decimal(new int[] {
            15,
            0,
            0,
            196608});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "RF background noise (mW):";
            // 
            // timerRender
            // 
            this.timerRender.Enabled = true;
            this.timerRender.Interval = 50;
            this.timerRender.Tick += new System.EventHandler(this.timerRender_Tick);
            // 
            // timerUpdate
            // 
            this.timerUpdate.Enabled = true;
            this.timerUpdate.Interval = 50;
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1495, 943);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Ad-hoc networks network simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWorldSizeY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLightSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWorldSizeX)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRenderInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeScale)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartingSeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNodesToCreate)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSendPacketID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSendPacketSize)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTransmissionProbability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTransmissionSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBackgroundNoisemW)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownLightSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownWorldSizeX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxSimulationEnabled;
        private System.Windows.Forms.NumericUpDown numericUpDownTimeScale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownRenderInterval;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown numericUpDownBackgroundNoisemW;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxRenderEnabled;
        private System.Windows.Forms.Timer timerRender;
        private System.Windows.Forms.NumericUpDown numericUpDownNodesToCreate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownStartingSeed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonRestartSimulation;
        private System.Windows.Forms.NumericUpDown numericUpDownTransmissionSpeed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.NumericUpDown numericUpDownSendPacketID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDownSendPacketSize;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonSendPacketSend;
        private System.Windows.Forms.NumericUpDown numericUpDownWorldSizeY;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.NumericUpDown numericUpDownTransmissionProbability;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton radioButtonALOHA;
        private System.Windows.Forms.RadioButton radioButtonNONE;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxSimulationCommands;
        private System.Windows.Forms.RadioButton radioButtonCSMA_CD;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxLogOutput;
        private System.Windows.Forms.Button buttonClearLogs;
    }
}

