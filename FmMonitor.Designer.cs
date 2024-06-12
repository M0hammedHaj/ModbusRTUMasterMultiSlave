namespace ModbusRTUMasterMultiSlave
{
    partial class FmMonitor
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
            this.dgvRegistersStatue = new System.Windows.Forms.DataGridView();
            this.btnStartStopMonitoring = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.lbMonitoringStatue = new System.Windows.Forms.Label();
            this.dgvErrorsLog = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistersStatue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrorsLog)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRegistersStatue
            // 
            this.dgvRegistersStatue.AllowUserToAddRows = false;
            this.dgvRegistersStatue.AllowUserToDeleteRows = false;
            this.dgvRegistersStatue.AllowUserToOrderColumns = true;
            this.dgvRegistersStatue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRegistersStatue.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvRegistersStatue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistersStatue.Location = new System.Drawing.Point(8, 45);
            this.dgvRegistersStatue.Name = "dgvRegistersStatue";
            this.dgvRegistersStatue.ReadOnly = true;
            this.dgvRegistersStatue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegistersStatue.Size = new System.Drawing.Size(619, 147);
            this.dgvRegistersStatue.TabIndex = 0;
            // 
            // btnStartStopMonitoring
            // 
            this.btnStartStopMonitoring.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStartStopMonitoring.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartStopMonitoring.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnStartStopMonitoring.Location = new System.Drawing.Point(456, 473);
            this.btnStartStopMonitoring.Name = "btnStartStopMonitoring";
            this.btnStartStopMonitoring.Size = new System.Drawing.Size(171, 54);
            this.btnStartStopMonitoring.TabIndex = 2;
            this.btnStartStopMonitoring.Text = "Start Monitoring";
            this.btnStartStopMonitoring.UseVisualStyleBackColor = true;
            this.btnStartStopMonitoring.Click += new System.EventHandler(this.btnStartStopMonitoring_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Errors Log:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Regiters Statue:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 564);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Monitoring Statue:";
            // 
            // lbMonitoringStatue
            // 
            this.lbMonitoringStatue.AutoSize = true;
            this.lbMonitoringStatue.Location = new System.Drawing.Point(149, 564);
            this.lbMonitoringStatue.Name = "lbMonitoringStatue";
            this.lbMonitoringStatue.Size = new System.Drawing.Size(41, 20);
            this.lbMonitoringStatue.TabIndex = 6;
            this.lbMonitoringStatue.Text = "OFF";
            // 
            // dgvErrorsLog
            // 
            this.dgvErrorsLog.AllowUserToAddRows = false;
            this.dgvErrorsLog.AllowUserToDeleteRows = false;
            this.dgvErrorsLog.AllowUserToOrderColumns = true;
            this.dgvErrorsLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvErrorsLog.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvErrorsLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvErrorsLog.Location = new System.Drawing.Point(10, 261);
            this.dgvErrorsLog.Name = "dgvErrorsLog";
            this.dgvErrorsLog.ReadOnly = true;
            this.dgvErrorsLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvErrorsLog.Size = new System.Drawing.Size(619, 193);
            this.dgvErrorsLog.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dgvErrorsLog);
            this.groupBox1.Controls.Add(this.dgvRegistersStatue);
            this.groupBox1.Controls.Add(this.btnStartStopMonitoring);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(644, 533);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // FmMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 595);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbMonitoringStatue);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FmMonitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitor Mode";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FmRegistersStatueMonitor_FormClosed);
            this.Load += new System.EventHandler(this.FmRegistersStatueMonitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistersStatue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrorsLog)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRegistersStatue;
        private System.Windows.Forms.Button btnStartStopMonitoring;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbMonitoringStatue;
        private System.Windows.Forms.DataGridView dgvErrorsLog;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}