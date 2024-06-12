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

namespace ModbusRTUMasterMultiSlave
{
    public partial class FmUpdateVoltRanges : Form
    {

        int ID = -1;

        clsSolarPannelVoltRange solarPannelVoltRangeRow = new clsSolarPannelVoltRange();

        public FmUpdateVoltRanges(int ID)
        {
            InitializeComponent();

            this.ID = ID;
            LoadSolarPanelRowInfo();
        }

        private void LoadSolarPanelRowInfo()
        {
            solarPannelVoltRangeRow = clsSolarPannelVoltRange.Find(ID);

            lbID.Text = solarPannelVoltRangeRow.ID.ToString();
            dtpRangeDateStart.Value = DateTime.Parse(solarPannelVoltRangeRow.FromDate);
            dtpRangeDateEnd.Value = DateTime.Parse(solarPannelVoltRangeRow.ToDate);
            tbStartVoltRange.Text = solarPannelVoltRangeRow.FromVolt.ToString();
            tbEndVoltRange.Text = solarPannelVoltRangeRow.ToVolt.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                return;

            solarPannelVoltRangeRow.FromVolt = int.Parse(tbStartVoltRange.Text);
            solarPannelVoltRangeRow.ToVolt = int.Parse(tbEndVoltRange.Text);
            solarPannelVoltRangeRow.FromDate = dtpRangeDateStart.Value.TimeOfDay.ToString();
            solarPannelVoltRangeRow.ToDate = dtpRangeDateEnd.Value.TimeOfDay.ToString();



            if (solarPannelVoltRangeRow.Save())
            {
                MessageBox.Show("Saved successfully", "Saved", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                this.Close();
            }
                
            else
                MessageBox.Show("Saving failed", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        private void ValidateTextBoxes(object sender,CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if(string.IsNullOrEmpty(textBox.Text))
            {
                errorProvider1.SetError(textBox, "Value shouldn't be empty");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBox, null);
                e.Cancel = false;
            }
        }
    }
}
