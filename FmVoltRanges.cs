using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModbusProject_BusinessLayer;

namespace ModbusRTUMasterMultiSlave
{
    public partial class FmVoltRanges : Form
    {
        public FmVoltRanges()
        {
            InitializeComponent();
        }

        private void FmSettings_Load(object sender, EventArgs e)
        {
            LoadTableInfo();
            lbRecordsCount.Text = dataGridView1.Rows.Count.ToString();
        }

        private void LoadTableInfo()
        {
            dataGridView1.DataSource = clsSolarPannelVoltRange.GetAllSolarPannelVoltRanges();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmUpdateVoltRanges fmUpdateVoltRanges = new FmUpdateVoltRanges(
                Convert.ToInt32(dataGridView1.SelectedCells[0].Value));
            fmUpdateVoltRanges.ShowDialog();

            LoadTableInfo();
        }
    }
}
