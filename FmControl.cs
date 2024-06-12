using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;

namespace ModbusRTUMasterMultiSlave
{
    public partial class FmControl : Form
    {
        int SlavesNumber { get; set; }

        int BroadcastValue 
        { get
            {
                if (rbSpecificRange.Checked)
                    return trackBar1.Value;
                else
                {
                    if (string.IsNullOrWhiteSpace(tbValue.Text))
                        return 0;
                    else
                        return int.Parse(tbValue.Text);
                }
            } 
        }
        int S1Value
        {
            get
            {
                if (rbSR1.Checked)
                    return trbS1.Value;
                else
                {
                    if (string.IsNullOrWhiteSpace(tbS1.Text))
                        return 0;
                    else
                        return int.Parse(tbS1.Text);
                }
            }
        }
        int S2Value
        {
            get
            {
                if (rbSR2.Checked)
                    return trbS2.Value;
                else
                {
                    if (string.IsNullOrWhiteSpace(tbS2.Text))
                        return 0;
                    else
                        return int.Parse(tbS2.Text);
                }
            }
        }
        int S3Value
        {
            get
            {
                if (rbSR3.Checked)
                    return trbS3.Value;
                else
                {
                    if (string.IsNullOrWhiteSpace(tbS3.Text))
                        return 0;
                    else
                        return int.Parse(tbS3.Text);
                }
            }
        }

        ModbusClient modbusClient;
        public FmControl(ModbusClient modbusClient,int SlavesNumber)
        {
            InitializeComponent();
            this.modbusClient = modbusClient;
            this.SlavesNumber = SlavesNumber;
        }

        private void WriteOnHoldingRegisterSlave(int SlaveID,int value)
        {
            try
            {

                modbusClient.UnitIdentifier = Convert.ToByte(SlaveID);


                modbusClient.WriteSingleRegister(0, value);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void btnWrite_Click(object sender, EventArgs e)
        {
                for(int i = 0 ;i < SlavesNumber; i++)
                {
                    WriteOnHoldingRegisterSlave(i + 1, BroadcastValue);
                }
        }



        private void FmReadWriteManualy_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    for (int i = 0; i < SlavesNumber; i++)
            //    {
            //        modbusClient.UnitIdentifier = Convert.ToByte(i + 1);
            //        modbusClient.WriteSingleCoil(0, true);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message + " ,Please make sure that you selected a right slaves number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    this.Close();
            //}

            rbSpecificSlave.PerformClick();

            timer1.Start();


        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            lbTrackBar.Text = trackBar1.Value.ToString();
        }

        private void rbWithoutRange_CheckedChanged(object sender, EventArgs e)
        {
            tbValue.Visible = true;
            trackBar1.Visible = false;
            lbTrackBar.Visible = false;
        }

        private void rbSpecificRange_CheckedChanged(object sender, EventArgs e)
        {
            trackBar1.Value = 5;

            tbValue.Visible = false;
            trackBar1.Visible = true;
            lbTrackBar.Visible = true;
        }

        private void rbSpecificSlave_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSpecificRange.Checked)
            {
                gbStaions.Enabled = true;
                gbBroadcast.Enabled = false;

            }  
            else
            {
                gbStaions.Enabled = false;
                gbBroadcast.Enabled = true;
            }
                
        }

        private void rbAllSlaves_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAllSlaves.Checked)
            {
                gbStaions.Enabled = false;
                gbBroadcast.Enabled = true;

            }
            else
            {
                gbStaions.Enabled = true;
                gbBroadcast.Enabled = false;
                
            }
        }

        private void rbSR1_CheckedChanged(object sender, EventArgs e)
        {
            trbS1.Value = 5;

            tbS1.Visible = false;
            trbS1.Visible = true;
            lbS1.Visible = true;
        }

        private void tbSR2_CheckedChanged(object sender, EventArgs e)
        {
            trbS2.Value = 5;

            tbS2.Visible = false;
            trbS2.Visible = true;
            lbS2.Visible = true;
        }

        private void rbSR3_CheckedChanged(object sender, EventArgs e)
        {
            trbS3.Value = 5;

            tbS3.Visible = false;
            trbS3.Visible = true;
            lbS3.Visible = true;
        }

        private void rbWR1_CheckedChanged(object sender, EventArgs e)
        {
            tbS1.Visible = true;
            trbS1.Visible = false;
            lbS1.Visible = false;
        }

        private void rbWR2_CheckedChanged(object sender, EventArgs e)
        {
            tbS2.Visible = true;
            trbS2.Visible = false;
            lbS2.Visible = false;
        }

        private void rbWR3_CheckedChanged(object sender, EventArgs e)
        {
            tbS3.Visible = true;
            trbS3.Visible = false;
            lbS3.Visible = false;
        }

        private void btnWriteS1_Click(object sender, EventArgs e)
        {
            
            WriteOnHoldingRegisterSlave(1, S1Value);


        }

        private void btnWriteS2_Click(object sender, EventArgs e)
        {

                WriteOnHoldingRegisterSlave(2, S2Value);

        }

        private void btnWriteS3_Click(object sender, EventArgs e)
        { 
                WriteOnHoldingRegisterSlave(3, S3Value);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < SlavesNumber; i++)
                {
                    modbusClient.UnitIdentifier = Convert.ToByte(i + 1);

                    if (i == 0)
                        lbPanelOne.Text = modbusClient.ReadInputRegisters(0, 1)[0].ToString();

                    else if (i == 1)
                        lbPanelTwo.Text = modbusClient.ReadInputRegisters(0, 1)[0].ToString();

                    else
                        lbPanelThree.Text = modbusClient.ReadInputRegisters(0, 1)[0].ToString();
                }
            }
            catch(Exception)
            {

            }
        }

        private void trbS1_ValueChanged(object sender, EventArgs e)
        {
            lbS1.Text = trbS1.Value.ToString();
        }


        private void trbS3_ValueChanged(object sender, EventArgs e)
        {
            lbS3.Text = trbS3.Value.ToString();
        }

        private void trbS2_ValueChanged(object sender, EventArgs e)
        {
            lbS2.Text = trbS2.Value.ToString();
        }

        private void FmControl_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }

        private void rbSpecificSlave_Click(object sender, EventArgs e)
        {

            gbStaions.Enabled = true;
            gbBroadcast.Enabled = false;
          
        }

        private void rbAllSlaves_Click(object sender, EventArgs e)
        {
            gbStaions.Enabled = false;
            gbBroadcast.Enabled = true;
        }
    }
}
