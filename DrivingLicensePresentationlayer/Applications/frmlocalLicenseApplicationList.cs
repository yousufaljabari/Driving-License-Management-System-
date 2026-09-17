using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLDBusinessLayer;
using DVLDPresentationLayer.Tests;

namespace DVLDPresentationLayer.Applications
{
    public partial class frmlocalLicenseApplicationList : Form
    {
        public frmlocalLicenseApplicationList()
        {
            InitializeComponent();
        }
        private void Frm_LocalApplicationSaved(object sender, EventArgs e)
        {
            _refreshList();
        }
        string FilterBy = "";

        public void LocalLicenseFillDataGrid(DataTable dt)
        {
            if (dt != null && dt.Rows.Count > 0)
            {
                dataGridViewlocalDrivinglicenseApplication.DataSource = dt;
                labellocalApplicationRecord.Text = $"Records = {dt.Rows.Count.ToString()} ";
            }
            else
            {
                dataGridViewlocalDrivinglicenseApplication.DataSource = null;
                labellocalApplicationRecord.Text = "Records = 0";
            }
        }
        public void GetAlllocalLicenseApplication()
        {
            DataTable dt = clslocalLicenseApplication.GetAllLocalLicenseApplication();
            LocalLicenseFillDataGrid(dt);
        }
        public void GetlocalLicenseApplicationWithFilter()
        {
            DataTable dt = clslocalLicenseApplication.GetAllLocalLicenseApplication(FilterBy, textBoxFilterBy.Text.Trim());
            LocalLicenseFillDataGrid(dt);
        }
        public void localLicenseSwitchCase()
        {

            textBoxFilterBy.Visible = true;

            textBoxFilterBy.Clear();
            textBoxFilterBy.Focus();

        }
        private void localcheckItemByIndex(int index)
        {

            switch (index)
            {

                case 0:
                    {

                        textBoxFilterBy.Visible = false;
                        GetAlllocalLicenseApplication();
                        break;

                    }
                case 1:
                    {
                        FilterBy = "L.D.L AppID";
                        localLicenseSwitchCase();
                        break;

                    }
                case 2:
                    {
                        FilterBy = "National NO";
                        localLicenseSwitchCase();
                        break;

                    }
                case 3:
                    {
                        FilterBy = "Full Name";

                        localLicenseSwitchCase();
                        break;
                    }

                case 4:
                    {
                        FilterBy = "Status";
                        localLicenseSwitchCase();
                        break;
                    }

            }
        }




        private void textBoxFilterBy_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxLocalLicenseFilterBy.SelectedIndex != 0)
            {
                GetlocalLicenseApplicationWithFilter();
            }
        }

        private void comboBoxLocalLicenseFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            localcheckItemByIndex(comboBoxLocalLicenseFilterBy.SelectedIndex);
        }

        private void frmlocalLicenseApplication_Load(object sender, EventArgs e)
        {
            comboBoxLocalLicenseFilterBy.SelectedIndex = 0;
            
        }

        private void buttonAddNewApplication_Click(object sender, EventArgs e)
        {
            frmLocalDrivingLicenseApplication frm = new frmLocalDrivingLicenseApplication();
            frm.LocalApplicationSaved += Frm_LocalApplicationSaved;
            frm.ShowDialog();
        }

        private void _refreshList()
        {
            GetAlllocalLicenseApplication();
        }
        private void toolStripCancelApplication_Click(object sender, EventArgs e)
        {
            int LocalDrivingLicenseApplicationID = Convert.ToInt32(dataGridViewlocalDrivinglicenseApplication.CurrentRow.Cells["L.D.L.AppID"].Value);
            DialogResult result = MessageBox.Show(
        "Are you sure you want to cancel this application?",
        "Confirm Cancellation",
        MessageBoxButtons.YesNo,
         MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;


            if (clsApplication.CancelApplication(LocalDrivingLicenseApplicationID))
            {
                MessageBox.Show(
             "Application cancelled successfully.",
             "Cancelled",
             MessageBoxButtons.OK,
             MessageBoxIcon.Information);

                _refreshList();
            }
            else
            {
                MessageBox.Show(
            "The application could not be cancelled. " +
            "It may already be cancelled or completed.",
            "Cancellation Failed",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning);
            }

        }

        private void scheduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int localDrivingLicenseApplicationID = Convert.ToInt32(dataGridViewlocalDrivinglicenseApplication.CurrentRow.Cells["L.D.L.AppID"].Value);
            frmVisionTestAppointments frm = new frmVisionTestAppointments(localDrivingLicenseApplicationID);
            frm.ShowDialog();
        }

        
        

        private void ScheduleTestsToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            int localDrivingLicenseApplicationID = Convert.ToInt32(dataGridViewlocalDrivinglicenseApplication.CurrentRow.Cells["L.D.L.AppID"].Value);
            int Passedtest = clslocalLicenseApplication.PassedTest(localDrivingLicenseApplicationID);
            if (Passedtest == 0)
            {
                scheduleVisionTestToolStripMenuItem.Enabled = true;
                scheduleStreetTestToolStripMenuItem.Enabled = false;
                scheduleWrittenTestToolStripMenuItem.Enabled = false;
            }
            else if (Passedtest == 1)
            {
                scheduleVisionTestToolStripMenuItem.Enabled = false;
                scheduleWrittenTestToolStripMenuItem.Enabled = true;
                scheduleStreetTestToolStripMenuItem.Enabled = false;
            }
            else if (Passedtest == 2)
            {
                scheduleVisionTestToolStripMenuItem.Enabled = false;
                scheduleWrittenTestToolStripMenuItem.Enabled = false;
                scheduleStreetTestToolStripMenuItem.Enabled = true;
            }
            else if (Passedtest == 3)
            {
                scheduleVisionTestToolStripMenuItem.Enabled = false;
                scheduleWrittenTestToolStripMenuItem.Enabled = false;
                scheduleStreetTestToolStripMenuItem.Enabled = false;
            }
        }
    }
}


    

