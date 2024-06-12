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
using ModbusProject_BusinessLayer;

namespace ModbusRTUMasterMultiSlave
{
    public partial class FmMonitor : Form
    {
        enum enSalveData { slaveID, SolarPanelEagle, SolarPanelVolt}

        enum enShowStopMonitorMessage { Yes ,No};
        enShowStopMonitorMessage showStopMonitorMessage = enShowStopMonitorMessage.Yes;

        int SlavesNumber = 0;

        DataTable dtRegistersStatue = new DataTable();

        List<List<int>> SlavesList;

        ModbusClient modbusClient;
        public FmMonitor(ModbusClient modbusClient,int SlavesNumber)
        {
            InitializeComponent();
            this.modbusClient = modbusClient;
            this.SlavesNumber = SlavesNumber;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(ReadRegistersStatue())
            {
                WriteRegistersOnDGV();
                HandleVoltErrorsActions();
            }
            
        }
        private void HandleVoltErrorsActions()
        {
            foreach(List<int> slave in SlavesList)
            {
                if (clsSolarPannelVoltRange.IsVoltValueWithinTheRange(slave[2]))
                {
                    int ErrorID = clsErrorsHistory.IsThereErrorSlaveNoTFixed(slave[0]);

                    if(ErrorID != 0)
                    {
                        ChangeErrorStatue(clsErrorsHistory.Find(ErrorID));
                        ReloadErrorsHistoryDGV();
                        MessageBox.Show($"Volt Error in Slave : {slave[(int)enSalveData.slaveID]} has been fixed",
                            "Error Fixed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {

                    if (clsErrorsHistory.IsThereErrorSlaveNoTFixed(slave[(int)enSalveData.slaveID]) == 0)
                    {
                        clsErrorsHistory Error = new clsErrorsHistory();

                        Error.SlaveID = slave[(int)enSalveData.slaveID];
                        Error.Date = DateTime.Now;
                        Error.IsFixed = false;
                        Error.VoltValue = slave[2];

                        Error.Save();

                        ReloadErrorsHistoryDGV();

                        MessageBox.Show($"There is an error in volt on Slave : {slave[(int)enSalveData.slaveID]}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }
        }
        private bool ChangeErrorStatue(clsErrorsHistory Error)
        {
            Error.IsFixed = !Error.IsFixed;
            return Error.Save();

        }
        private void ReloadErrorsHistoryDGV()
        {
            dgvErrorsLog.DataSource = clsErrorsHistory.GetAllErrorsHistoryThatNotFixed();

            if (clsErrorsHistory.GetAllErrorsHistoryThatNotFixed() != null)
                dgvErrorsLog.Columns[2].Width = 160;
        }
        private bool ReadRegistersStatue()
        {
            SlavesList = new List<List<int>>();

            for (int i = 0; i < SlavesNumber; i++)
            {
                List<int> Slave = new List<int>();

                modbusClient.UnitIdentifier = Convert.ToByte(i + 1);

                try
                {
                    Slave.Add(modbusClient.UnitIdentifier);
                    Slave.Add(modbusClient.ReadHoldingRegisters(0, 1)[0]);
                    Slave.Add(modbusClient.ReadInputRegisters(0, 1)[0]);
                }
                catch(Exception)
                {
                    showStopMonitorMessage = enShowStopMonitorMessage.No;
                    btnStartStopMonitoring.PerformClick();

                    MessageBox.Show($"Monitoring mode has been stoped because no response from slave {modbusClient.UnitIdentifier}",
                        "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                SlavesList.Add(Slave);
            }

            return true;

        }
        private void WriteRegistersOnDGV()
        {
            int i = 0;

            foreach (DataRow row in dtRegistersStatue.Rows)
            {
                
                
                row[0] = SlavesList[i][0];
                row[1] = SlavesList[i][1];
                row[2] = SlavesList[i][2];
                
                i++;
            }

            
        }
        private void btnStartStopMonitoring_Click(object sender, EventArgs e)
        {

            dtRegistersStatue = new DataTable();
            dtRegistersStatue.Columns.Add("SlaveID", typeof(int));
            dtRegistersStatue.Columns.Add("SolarPanelAngle", typeof(int));
            dtRegistersStatue.Columns.Add("SolarPanelVolt(mv)", typeof(int));

            
            dgvRegistersStatue.DataSource = dtRegistersStatue;
            

            if(lbMonitoringStatue.Text == "OFF")
            {
                for (int i = 0; i < SlavesNumber; i++)
                {
                    dtRegistersStatue.Rows.Add(dtRegistersStatue.NewRow());
                }

                showStopMonitorMessage = enShowStopMonitorMessage.Yes;
                lbMonitoringStatue.Text = "ON";
                lbMonitoringStatue.ForeColor = Color.Green;
                btnStartStopMonitoring.Text = "Stop Monitoring";
                btnStartStopMonitoring.ForeColor = Color.Red;
                timer1.Start();
                //MessageBox.Show("Monitoring mode activated", "Activated Successfully",
                //    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                
                lbMonitoringStatue.Text = "OFF";
                lbMonitoringStatue.ForeColor = Color.Red;
                btnStartStopMonitoring.Text = "Start Monitoring";
                btnStartStopMonitoring.ForeColor = Color.Green;
                timer1.Stop();

                if(showStopMonitorMessage == enShowStopMonitorMessage.Yes)
                MessageBox.Show("Monitoring mode stoped", "Stoped Successfully",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void FmRegistersStatueMonitor_Load(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < SlavesNumber; i++)
                {
                    modbusClient.UnitIdentifier = Convert.ToByte(i + 1);
                    modbusClient.WriteSingleCoil(0, false);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + " ,Please make sure that you selected a right slaves number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            dgvErrorsLog.DataSource = clsErrorsHistory.GetAllErrorsHistoryThatNotFixed();

            if (clsErrorsHistory.GetAllErrorsHistoryThatNotFixed() != null)
                dgvErrorsLog.Columns[2].Width = 160;

        }
        
        private void FmRegistersStatueMonitor_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }
    }
}
