namespace ModbusRTUMasterMultiSlave
{
    partial class FmControl
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
            this.lbTrackBar = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.rbWithoutRange = new System.Windows.Forms.RadioButton();
            this.rbSpecificRange = new System.Windows.Forms.RadioButton();
            this.btnWrite = new System.Windows.Forms.Button();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbBroadcast = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbSpecificSlave = new System.Windows.Forms.RadioButton();
            this.rbAllSlaves = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbStaions = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.lbS3 = new System.Windows.Forms.Label();
            this.trbS3 = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.tbS3 = new System.Windows.Forms.TextBox();
            this.btnWriteS3 = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.rbWR3 = new System.Windows.Forms.RadioButton();
            this.rbSR3 = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lbS2 = new System.Windows.Forms.Label();
            this.btnWriteS2 = new System.Windows.Forms.Button();
            this.trbS2 = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.rbWR2 = new System.Windows.Forms.RadioButton();
            this.rbSR2 = new System.Windows.Forms.RadioButton();
            this.tbS2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnWriteS1 = new System.Windows.Forms.Button();
            this.lbS1 = new System.Windows.Forms.Label();
            this.trbS1 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.tbS1 = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rbWR1 = new System.Windows.Forms.RadioButton();
            this.rbSR1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbPanelThree = new System.Windows.Forms.Label();
            this.lbPanelTwo = new System.Windows.Forms.Label();
            this.lbPanelOne = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbBroadcast.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbStaions.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbS3)).BeginInit();
            this.groupBox10.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbS2)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbS1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTrackBar
            // 
            this.lbTrackBar.AutoSize = true;
            this.lbTrackBar.Location = new System.Drawing.Point(282, 45);
            this.lbTrackBar.Name = "lbTrackBar";
            this.lbTrackBar.Size = new System.Drawing.Size(18, 20);
            this.lbTrackBar.TabIndex = 18;
            this.lbTrackBar.Text = "5";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(162, 36);
            this.trackBar1.Maximum = 175;
            this.trackBar1.Minimum = 5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 16;
            this.trackBar1.Value = 5;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // rbWithoutRange
            // 
            this.rbWithoutRange.AutoSize = true;
            this.rbWithoutRange.Location = new System.Drawing.Point(158, 43);
            this.rbWithoutRange.Name = "rbWithoutRange";
            this.rbWithoutRange.Size = new System.Drawing.Size(134, 24);
            this.rbWithoutRange.TabIndex = 17;
            this.rbWithoutRange.TabStop = true;
            this.rbWithoutRange.Text = "Without Range";
            this.rbWithoutRange.UseVisualStyleBackColor = true;
            this.rbWithoutRange.CheckedChanged += new System.EventHandler(this.rbWithoutRange_CheckedChanged);
            // 
            // rbSpecificRange
            // 
            this.rbSpecificRange.AutoSize = true;
            this.rbSpecificRange.Checked = true;
            this.rbSpecificRange.Location = new System.Drawing.Point(6, 42);
            this.rbSpecificRange.Name = "rbSpecificRange";
            this.rbSpecificRange.Size = new System.Drawing.Size(135, 24);
            this.rbSpecificRange.TabIndex = 16;
            this.rbSpecificRange.TabStop = true;
            this.rbSpecificRange.Text = "Specific Range";
            this.rbSpecificRange.UseVisualStyleBackColor = true;
            this.rbSpecificRange.CheckedChanged += new System.EventHandler(this.rbSpecificRange_CheckedChanged);
            // 
            // btnWrite
            // 
            this.btnWrite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWrite.Location = new System.Drawing.Point(398, 125);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(128, 40);
            this.btnWrite.TabIndex = 9;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(166, 36);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(100, 26);
            this.tbValue.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Solar Panel Angle:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbWithoutRange);
            this.groupBox1.Controls.Add(this.rbSpecificRange);
            this.groupBox1.Location = new System.Drawing.Point(18, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 78);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Range";
            // 
            // gbBroadcast
            // 
            this.gbBroadcast.Controls.Add(this.btnWrite);
            this.gbBroadcast.Controls.Add(this.groupBox1);
            this.gbBroadcast.Controls.Add(this.lbTrackBar);
            this.gbBroadcast.Controls.Add(this.trackBar1);
            this.gbBroadcast.Controls.Add(this.label7);
            this.gbBroadcast.Controls.Add(this.tbValue);
            this.gbBroadcast.Location = new System.Drawing.Point(12, 12);
            this.gbBroadcast.Name = "gbBroadcast";
            this.gbBroadcast.Size = new System.Drawing.Size(547, 173);
            this.gbBroadcast.TabIndex = 18;
            this.gbBroadcast.TabStop = false;
            this.gbBroadcast.Text = "Broadcast";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbSpecificSlave);
            this.groupBox3.Controls.Add(this.rbAllSlaves);
            this.groupBox3.Location = new System.Drawing.Point(908, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(174, 173);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Write on";
            // 
            // rbSpecificSlave
            // 
            this.rbSpecificSlave.AutoSize = true;
            this.rbSpecificSlave.Location = new System.Drawing.Point(6, 41);
            this.rbSpecificSlave.Name = "rbSpecificSlave";
            this.rbSpecificSlave.Size = new System.Drawing.Size(126, 24);
            this.rbSpecificSlave.TabIndex = 18;
            this.rbSpecificSlave.Text = "Specific Slave";
            this.rbSpecificSlave.UseVisualStyleBackColor = true;
            this.rbSpecificSlave.Click += new System.EventHandler(this.rbSpecificSlave_Click);
            // 
            // rbAllSlaves
            // 
            this.rbAllSlaves.AutoSize = true;
            this.rbAllSlaves.Location = new System.Drawing.Point(6, 101);
            this.rbAllSlaves.Name = "rbAllSlaves";
            this.rbAllSlaves.Size = new System.Drawing.Size(95, 24);
            this.rbAllSlaves.TabIndex = 19;
            this.rbAllSlaves.TabStop = true;
            this.rbAllSlaves.Text = "All Slaves";
            this.rbAllSlaves.UseVisualStyleBackColor = true;
            this.rbAllSlaves.Click += new System.EventHandler(this.rbAllSlaves_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gbStaions
            // 
            this.gbStaions.Controls.Add(this.groupBox9);
            this.gbStaions.Controls.Add(this.groupBox7);
            this.gbStaions.Controls.Add(this.groupBox5);
            this.gbStaions.Location = new System.Drawing.Point(12, 201);
            this.gbStaions.Name = "gbStaions";
            this.gbStaions.Size = new System.Drawing.Size(1070, 321);
            this.gbStaions.TabIndex = 19;
            this.gbStaions.TabStop = false;
            this.gbStaions.Text = "Stations";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.lbS3);
            this.groupBox9.Controls.Add(this.trbS3);
            this.groupBox9.Controls.Add(this.label11);
            this.groupBox9.Controls.Add(this.tbS3);
            this.groupBox9.Controls.Add(this.btnWriteS3);
            this.groupBox9.Controls.Add(this.groupBox10);
            this.groupBox9.Controls.Add(this.label13);
            this.groupBox9.Controls.Add(this.label14);
            this.groupBox9.Location = new System.Drawing.Point(712, 31);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(341, 278);
            this.groupBox9.TabIndex = 26;
            this.groupBox9.TabStop = false;
            // 
            // lbS3
            // 
            this.lbS3.AutoSize = true;
            this.lbS3.Location = new System.Drawing.Point(271, 88);
            this.lbS3.Name = "lbS3";
            this.lbS3.Size = new System.Drawing.Size(18, 20);
            this.lbS3.TabIndex = 28;
            this.lbS3.Text = "5";
            // 
            // trbS3
            // 
            this.trbS3.Location = new System.Drawing.Point(161, 79);
            this.trbS3.Maximum = 175;
            this.trbS3.Minimum = 5;
            this.trbS3.Name = "trbS3";
            this.trbS3.Size = new System.Drawing.Size(104, 45);
            this.trbS3.TabIndex = 27;
            this.trbS3.Value = 5;
            this.trbS3.ValueChanged += new System.EventHandler(this.trbS3_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "Solar Panel Angle:";
            // 
            // tbS3
            // 
            this.tbS3.Location = new System.Drawing.Point(165, 79);
            this.tbS3.Name = "tbS3";
            this.tbS3.Size = new System.Drawing.Size(100, 26);
            this.tbS3.TabIndex = 26;
            // 
            // btnWriteS3
            // 
            this.btnWriteS3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWriteS3.Location = new System.Drawing.Point(207, 224);
            this.btnWriteS3.Name = "btnWriteS3";
            this.btnWriteS3.Size = new System.Drawing.Size(128, 40);
            this.btnWriteS3.TabIndex = 21;
            this.btnWriteS3.Text = "Write";
            this.btnWriteS3.UseVisualStyleBackColor = true;
            this.btnWriteS3.Click += new System.EventHandler(this.btnWriteS3_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.rbWR3);
            this.groupBox10.Controls.Add(this.rbSR3);
            this.groupBox10.Location = new System.Drawing.Point(14, 130);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(327, 78);
            this.groupBox10.TabIndex = 20;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Range";
            // 
            // rbWR3
            // 
            this.rbWR3.AutoSize = true;
            this.rbWR3.Location = new System.Drawing.Point(158, 43);
            this.rbWR3.Name = "rbWR3";
            this.rbWR3.Size = new System.Drawing.Size(134, 24);
            this.rbWR3.TabIndex = 17;
            this.rbWR3.TabStop = true;
            this.rbWR3.Text = "Without Range";
            this.rbWR3.UseVisualStyleBackColor = true;
            this.rbWR3.CheckedChanged += new System.EventHandler(this.rbWR3_CheckedChanged);
            // 
            // rbSR3
            // 
            this.rbSR3.AutoSize = true;
            this.rbSR3.Checked = true;
            this.rbSR3.Location = new System.Drawing.Point(6, 42);
            this.rbSR3.Name = "rbSR3";
            this.rbSR3.Size = new System.Drawing.Size(135, 24);
            this.rbSR3.TabIndex = 16;
            this.rbSR3.TabStop = true;
            this.rbSR3.Text = "Specific Range";
            this.rbSR3.UseVisualStyleBackColor = true;
            this.rbSR3.CheckedChanged += new System.EventHandler(this.rbSR3_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(75, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 20);
            this.label13.TabIndex = 1;
            this.label13.Text = "3";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Station:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lbS2);
            this.groupBox7.Controls.Add(this.btnWriteS2);
            this.groupBox7.Controls.Add(this.trbS2);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.groupBox8);
            this.groupBox7.Controls.Add(this.tbS2);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Location = new System.Drawing.Point(365, 31);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(341, 278);
            this.groupBox7.TabIndex = 25;
            this.groupBox7.TabStop = false;
            // 
            // lbS2
            // 
            this.lbS2.AutoSize = true;
            this.lbS2.Location = new System.Drawing.Point(272, 88);
            this.lbS2.Name = "lbS2";
            this.lbS2.Size = new System.Drawing.Size(18, 20);
            this.lbS2.TabIndex = 28;
            this.lbS2.Text = "5";
            // 
            // btnWriteS2
            // 
            this.btnWriteS2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWriteS2.Location = new System.Drawing.Point(207, 224);
            this.btnWriteS2.Name = "btnWriteS2";
            this.btnWriteS2.Size = new System.Drawing.Size(128, 40);
            this.btnWriteS2.TabIndex = 21;
            this.btnWriteS2.Text = "Write";
            this.btnWriteS2.UseVisualStyleBackColor = true;
            this.btnWriteS2.Click += new System.EventHandler(this.btnWriteS2_Click);
            // 
            // trbS2
            // 
            this.trbS2.Location = new System.Drawing.Point(162, 79);
            this.trbS2.Maximum = 175;
            this.trbS2.Minimum = 5;
            this.trbS2.Name = "trbS2";
            this.trbS2.Size = new System.Drawing.Size(104, 45);
            this.trbS2.TabIndex = 27;
            this.trbS2.Value = 5;
            this.trbS2.ValueChanged += new System.EventHandler(this.trbS2_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Solar Panel Angle:";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.rbWR2);
            this.groupBox8.Controls.Add(this.rbSR2);
            this.groupBox8.Location = new System.Drawing.Point(8, 130);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(327, 78);
            this.groupBox8.TabIndex = 20;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Range";
            // 
            // rbWR2
            // 
            this.rbWR2.AutoSize = true;
            this.rbWR2.Location = new System.Drawing.Point(158, 43);
            this.rbWR2.Name = "rbWR2";
            this.rbWR2.Size = new System.Drawing.Size(134, 24);
            this.rbWR2.TabIndex = 17;
            this.rbWR2.TabStop = true;
            this.rbWR2.Text = "Without Range";
            this.rbWR2.UseVisualStyleBackColor = true;
            this.rbWR2.CheckedChanged += new System.EventHandler(this.rbWR2_CheckedChanged);
            // 
            // rbSR2
            // 
            this.rbSR2.AutoSize = true;
            this.rbSR2.Checked = true;
            this.rbSR2.Location = new System.Drawing.Point(6, 42);
            this.rbSR2.Name = "rbSR2";
            this.rbSR2.Size = new System.Drawing.Size(135, 24);
            this.rbSR2.TabIndex = 16;
            this.rbSR2.TabStop = true;
            this.rbSR2.Text = "Specific Range";
            this.rbSR2.UseVisualStyleBackColor = true;
            this.rbSR2.CheckedChanged += new System.EventHandler(this.tbSR2_CheckedChanged);
            // 
            // tbS2
            // 
            this.tbS2.Location = new System.Drawing.Point(166, 79);
            this.tbS2.Name = "tbS2";
            this.tbS2.Size = new System.Drawing.Size(100, 26);
            this.tbS2.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(75, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Station:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnWriteS1);
            this.groupBox5.Controls.Add(this.lbS1);
            this.groupBox5.Controls.Add(this.trbS1);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.tbS1);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Location = new System.Drawing.Point(18, 31);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(341, 278);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            // 
            // btnWriteS1
            // 
            this.btnWriteS1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWriteS1.Location = new System.Drawing.Point(207, 224);
            this.btnWriteS1.Name = "btnWriteS1";
            this.btnWriteS1.Size = new System.Drawing.Size(128, 40);
            this.btnWriteS1.TabIndex = 21;
            this.btnWriteS1.Text = "Write";
            this.btnWriteS1.UseVisualStyleBackColor = true;
            this.btnWriteS1.Click += new System.EventHandler(this.btnWriteS1_Click);
            // 
            // lbS1
            // 
            this.lbS1.AutoSize = true;
            this.lbS1.Location = new System.Drawing.Point(257, 88);
            this.lbS1.Name = "lbS1";
            this.lbS1.Size = new System.Drawing.Size(18, 20);
            this.lbS1.TabIndex = 24;
            this.lbS1.Text = "5";
            // 
            // trbS1
            // 
            this.trbS1.Location = new System.Drawing.Point(147, 79);
            this.trbS1.Maximum = 175;
            this.trbS1.Minimum = 5;
            this.trbS1.Name = "trbS1";
            this.trbS1.Size = new System.Drawing.Size(104, 45);
            this.trbS1.TabIndex = 23;
            this.trbS1.Value = 5;
            this.trbS1.ValueChanged += new System.EventHandler(this.trbS1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Solar Panel Angle:";
            // 
            // tbS1
            // 
            this.tbS1.Location = new System.Drawing.Point(148, 79);
            this.tbS1.Name = "tbS1";
            this.tbS1.Size = new System.Drawing.Size(100, 26);
            this.tbS1.TabIndex = 22;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rbWR1);
            this.groupBox6.Controls.Add(this.rbSR1);
            this.groupBox6.Location = new System.Drawing.Point(8, 130);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(327, 78);
            this.groupBox6.TabIndex = 20;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Range";
            // 
            // rbWR1
            // 
            this.rbWR1.AutoSize = true;
            this.rbWR1.Location = new System.Drawing.Point(158, 43);
            this.rbWR1.Name = "rbWR1";
            this.rbWR1.Size = new System.Drawing.Size(134, 24);
            this.rbWR1.TabIndex = 17;
            this.rbWR1.TabStop = true;
            this.rbWR1.Text = "Without Range";
            this.rbWR1.UseVisualStyleBackColor = true;
            this.rbWR1.CheckedChanged += new System.EventHandler(this.rbWR1_CheckedChanged);
            // 
            // rbSR1
            // 
            this.rbSR1.AutoSize = true;
            this.rbSR1.Checked = true;
            this.rbSR1.Location = new System.Drawing.Point(6, 42);
            this.rbSR1.Name = "rbSR1";
            this.rbSR1.Size = new System.Drawing.Size(135, 24);
            this.rbSR1.TabIndex = 16;
            this.rbSR1.TabStop = true;
            this.rbSR1.Text = "Specific Range";
            this.rbSR1.UseVisualStyleBackColor = true;
            this.rbSR1.CheckedChanged += new System.EventHandler(this.rbSR1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Station:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbPanelThree);
            this.groupBox4.Controls.Add(this.lbPanelTwo);
            this.groupBox4.Controls.Add(this.lbPanelOne);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(565, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(337, 173);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Solar Panels Volt (mv)";
            // 
            // lbPanelThree
            // 
            this.lbPanelThree.AutoSize = true;
            this.lbPanelThree.Location = new System.Drawing.Point(126, 105);
            this.lbPanelThree.Name = "lbPanelThree";
            this.lbPanelThree.Size = new System.Drawing.Size(14, 20);
            this.lbPanelThree.TabIndex = 27;
            this.lbPanelThree.Text = "-";
            // 
            // lbPanelTwo
            // 
            this.lbPanelTwo.AutoSize = true;
            this.lbPanelTwo.Location = new System.Drawing.Point(114, 71);
            this.lbPanelTwo.Name = "lbPanelTwo";
            this.lbPanelTwo.Size = new System.Drawing.Size(14, 20);
            this.lbPanelTwo.TabIndex = 26;
            this.lbPanelTwo.Text = "-";
            // 
            // lbPanelOne
            // 
            this.lbPanelOne.AutoSize = true;
            this.lbPanelOne.Location = new System.Drawing.Point(116, 39);
            this.lbPanelOne.Name = "lbPanelOne";
            this.lbPanelOne.Size = new System.Drawing.Size(14, 20);
            this.lbPanelOne.TabIndex = 25;
            this.lbPanelOne.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Station three:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Station two:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Station one:";
            // 
            // FmControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 544);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbStaions);
            this.Controls.Add(this.gbBroadcast);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FmControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control Mode";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FmControl_FormClosed);
            this.Load += new System.EventHandler(this.FmReadWriteManualy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbBroadcast.ResumeLayout(false);
            this.gbBroadcast.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbStaions.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbS3)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbS2)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbS1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.RadioButton rbWithoutRange;
        private System.Windows.Forms.RadioButton rbSpecificRange;
        private System.Windows.Forms.Label lbTrackBar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbBroadcast;
        private System.Windows.Forms.RadioButton rbAllSlaves;
        private System.Windows.Forms.RadioButton rbSpecificSlave;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox gbStaions;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button btnWriteS3;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.RadioButton rbWR3;
        private System.Windows.Forms.RadioButton rbSR3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnWriteS2;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.RadioButton rbWR2;
        private System.Windows.Forms.RadioButton rbSR2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnWriteS1;
        private System.Windows.Forms.Label lbS1;
        private System.Windows.Forms.TrackBar trbS1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbS1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rbWR1;
        private System.Windows.Forms.RadioButton rbSR1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbS3;
        private System.Windows.Forms.TrackBar trbS3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbS3;
        private System.Windows.Forms.Label lbS2;
        private System.Windows.Forms.TrackBar trbS2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbS2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbPanelThree;
        private System.Windows.Forms.Label lbPanelTwo;
        private System.Windows.Forms.Label lbPanelOne;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}