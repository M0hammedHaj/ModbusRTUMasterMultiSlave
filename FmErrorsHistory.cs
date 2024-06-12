using ModbusProject_BusinessLayer;
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
    public partial class FmErrorsHistory : Form
    {
        public FmErrorsHistory()
        {
            InitializeComponent();
        }

        private void FmErrorsHistory_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clsErrorsHistory.GetAllErrorsHistory();
            lbRecordsCount.Text = dataGridView1.Rows.Count.ToString();
        }
    }
}
