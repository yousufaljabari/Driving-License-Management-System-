using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLDBusinessLayer;
using DVLDPresentationLayer.GeneralClasses;

namespace DVLDPresentationLayer.TestAppointments
{
    public partial class ctrlScheduleTest: UserControl
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool RetakeTestEnabled
        {
            get { return groupBoxRetakeTest.Enabled; }
            set { groupBoxRetakeTest.Enabled = value; }
        }
        public DateTime AppointmentDate
        {
            get { return dateTimePickerAppointmentDate.Value; }
        }

        public decimal PaidFees
        {
            get { return Convert.ToDecimal(labelTotalFeesResult.Text); }
        }

        public ctrlScheduleTest()
        {
            InitializeComponent();
        }




        public void LoadData(
     clsTestAppointment TA,
     string ClassName,
     string FullName)
        {
            labelDLAppIDResult.Text =
                TA.LocalDrivingLicenseApplicationID.ToString();

            labelDClassResult.Text = ClassName;
            labelNameResult.Text = FullName;

            // Appoinment Date defined when apply save (Take value from DataTimePicker)

           
            labeTrialResult.Text =
                clsTest.GetTestTrials(
                    TA.LocalDrivingLicenseApplicationID,
                    TA.TestTypeID).ToString();

            TA.PaidFees = clsTestType.GetPaidFeesUsingTestTypeID(TA.TestTypeID);
            labelFeesResult.Text = TA.PaidFees.ToString();
           
        }

    }
}
