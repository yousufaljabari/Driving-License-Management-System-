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
using DVLDPresentationLayer.GeneralClasses;

namespace DVLDPresentationLayer.TestAppointments
{
    public partial class frmAddEditTestAppointment : Form
    {
        enum enAddEditTestAppointment { AddNew=0,Update=1};
        
        string _FullName;
        string _DrivingClassName;
        
        enAddEditTestAppointment _Mode;
        clsTestAppointment _TestAppointment;


        public event EventHandler TestAppointmentSaved;

        public frmAddEditTestAppointment(int LocalDrivingLicenseApplicationID, string DrivingClassName, string FullName, int TestTypeID)
        {
            InitializeComponent();
            ctrlScheduleTest1.RetakeTestEnabled = false;
            _TestAppointment = new clsTestAppointment();
            _Mode = enAddEditTestAppointment.AddNew;
            _TestAppointment.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _TestAppointment.TestTypeID = TestTypeID;
            this._FullName = FullName;
            this._DrivingClassName = DrivingClassName;

        }

        private void _FillTestAppointmentObject()
        {


            _TestAppointment.CreatedByUserID = clsGlobalUser.CurrentUser.UserID;
            _TestAppointment.IsLocked = false;
            _TestAppointment.AppointmentDate = ctrlScheduleTest1.AppointmentDate;


            _TestAppointment.RetakeTestApplicationID = null;
        }


        private void frmAddEditTestAppointment_Load(object sender, EventArgs e)
        {
            ctrlScheduleTest1.LoadData(_TestAppointment, _DrivingClassName, _FullName);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enAddEditTestAppointment.AddNew:

                    {
                        if(_TestAppointment.Save())
                        {
                            _Mode = enAddEditTestAppointment.Update;
                            return true;
                        }
                    }

                    return false;
            }

            return false;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            _FillTestAppointmentObject();

            if (Save())
            {
                MessageBox.Show(
                    "Test Appointment saved successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                TestAppointmentSaved?.Invoke(this, EventArgs.Empty);


            }
            else
            {
                MessageBox.Show(
                    "Failed to save Test Appointment.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }


        }
    }
}
