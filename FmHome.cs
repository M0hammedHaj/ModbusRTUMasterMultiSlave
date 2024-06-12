using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using EasyModbus;
using ModbusRTUMasterMultiSlave.Properties;

namespace ModbusRTUMasterMultiSlave
{
    public partial class Home : Form
    {
        int SlavesNumber { get;set; }

        ModbusClient modbusClient;
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            cbComPorts.Items.AddRange(SerialPort.GetPortNames());

            cbSlavesNumber.SelectedIndex = 2;
            cbBaudRate.SelectedIndex = 2;
            cbParityBits.SelectedIndex = 0;

            modbusClient = new ModbusClient();
        }
        private void ValidateComboBox(object sender, CancelEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            if(string.IsNullOrWhiteSpace(comboBox.Text))
            {
                errorProvider1.SetError(comboBox, "Value shouldn't be empty");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(comboBox, null);
                e.Cancel = false;
            }
        }
        private void btnConnection_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                return;
            
            modbusClient.SerialPort = cbComPorts.Text;
            modbusClient.Parity = (Parity)Enum.Parse(typeof(Parity), cbParityBits.Text);
            modbusClient.Baudrate = int.Parse(cbBaudRate.Text);

            try
            {
                if(lbStatue.Text == "Connected")
                {
                    modbusClient.Disconnect();
                    lbStatue.Text = "Disconnected";
                    lbStatue.ForeColor = Color.Red;
                    btnConnection.Text = "    Connect";
                    btnConnection.Image = Resources.connect;
                    groupBox1.Enabled = true;

                    MessageBox.Show("Disconnected Successfully", "Disconnected", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                else
                {
                    modbusClient.Connect();

                    lbStatue.Text = "Connected";
                    lbStatue.ForeColor = Color.Green;
                    btnConnection.Text = "     Disconnect";
                    btnConnection.Image = Resources.disconnect;
                    groupBox1.Enabled = false;


                    MessageBox.Show("Connected Successfully", "Connected", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmVoltRanges fmSettings = new FmVoltRanges();
            fmSettings.ShowDialog();
        }



        private bool ValidateTextBoxes(TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider1.SetError(textBox, "Value shouldn't be empty");
                return false;
            }
            else
            {
                errorProvider1.SetError(textBox, null);
                return true;
            }
                
        }


        private void RegistersStatueMonitorModeStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!modbusClient.Connected)
            {
                MessageBox.Show("Please connect in com port then try again.", "Connection Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                for (int i = 0; i < SlavesNumber; i++)
                {
                    modbusClient.UnitIdentifier = Convert.ToByte(i + 1);
                    modbusClient.WriteSingleCoil(0, false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " ,Please make sure that you selected a right slaves number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FmMonitor fmRegistersStatueMonitor = new
                FmMonitor(modbusClient,SlavesNumber);
            fmRegistersStatueMonitor.ShowDialog();
        }

        private void readWriteManualyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!modbusClient.Connected)
            {
                MessageBox.Show("Please connect in com port then try again.", "Connection Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                for (int i = 0; i < SlavesNumber; i++)
                {
                    modbusClient.UnitIdentifier = Convert.ToByte(i + 1);
                    modbusClient.WriteSingleCoil(0, true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " ,Please make sure that you selected a right slaves number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FmControl fmReadWriteManualy = new FmControl(modbusClient,SlavesNumber);
            fmReadWriteManualy.ShowDialog();
        }

        private void errorsHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmErrorsHistory fmErrorsHistory = new FmErrorsHistory();
                fmErrorsHistory.ShowDialog();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/M0hammedHag");
        }

        private void Home_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnConnection.PerformClick();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cbComPorts.Items.Clear();
            cbComPorts.Items.AddRange(SerialPort.GetPortNames());
        }

        private void cbSlavesNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            SlavesNumber = int.Parse(cbSlavesNumber.Text);
        }


    }
}
