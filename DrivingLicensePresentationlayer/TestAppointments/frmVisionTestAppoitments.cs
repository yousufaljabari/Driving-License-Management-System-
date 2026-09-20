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
using DVLDPresentationLayer.TestAppointments;

namespace DVLDPresentationLayer.Tests
{

    public partial class frmVisionTestAppointments : Form
    {
        private void Frm_TestAppointmentSaved(object sender, EventArgs e)
        {
            LoadAppointments();
        }
        enum enTestType
        {
            Vision = 1,
            Written = 2,
            Street = 3
        }
        int _localDrivingLicenseApplicationID;
        int TestTypeID = (int)enTestType.Vision;
        public frmVisionTestAppointments()
        {
            InitializeComponent();
        }
        public frmVisionTestAppointments(int localDrivingLicenseApplicationID)
        {

            InitializeComponent();
            _localDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
        }

        private void frmVisionTest_Load(object sender, EventArgs e)
        {
            ctrlApplicationInfo1.localDrivingLicenseApplicationID = _localDrivingLicenseApplicationID;
            ctrlApplicationInfo1.LoadLocalApplicationInfo();
            LoadAppointments();
        }

        private void UpdateRecordsCount()
        {
            lblRecordsCount.Text = dgvAppointments.Rows.Count.ToString();
        }
        void LoadAppointments()
        {
            DataTable dt = clsTestAppointment.GetAppointmentsByLocalDrivingLicenseApplicationID(_localDrivingLicenseApplicationID);
            dgvAppointments.DataSource = dt;
            UpdateRecordsCount();
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            if (clsTestAppointment.IsThereAnActiveAppointment(_localDrivingLicenseApplicationID, TestTypeID))
            {
                MessageBox.Show(
                    "An active appointment already exists for this test type.",
                    "Appointment Already Exists",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string FullName = ctrlApplicationInfo1.FullName;
            string DrivingClassName = ctrlApplicationInfo1.DrivingClassName;

            frmAddEditTestAppointment frm = new frmAddEditTestAppointment(_localDrivingLicenseApplicationID, DrivingClassName, FullName, TestTypeID);

            frm.TestAppointmentSaved += Frm_TestAppointmentSaved;
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiEditAppointment_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.CurrentRow == null)
                return;

            int TestAppointmentID = Convert.ToInt32(
                dgvAppointments.CurrentRow.Cells["TestAppointmentID"].Value);

            frmAddEditTestAppointment frm =
                new frmAddEditTestAppointment(
                    TestAppointmentID,
                    ctrlApplicationInfo1.DrivingClassName,
                    ctrlApplicationInfo1.FullName);

            frm.TestAppointmentSaved += Frm_TestAppointmentSaved;

            frm.ShowDialog();
        }

        private void cmsTestAppointments_Opening(object sender, CancelEventArgs e)
        {
            if (dgvAppointments.CurrentRow == null)
            {
                e.Cancel = true;
                return;
            }

            bool IsLocked = Convert.ToBoolean(
                dgvAppointments.CurrentRow.Cells["IsLocked"].Value);

            tsmiEditAppointment.Enabled = !IsLocked;
            tsmiTakeTest.Enabled = !IsLocked;
        }
    }
}
