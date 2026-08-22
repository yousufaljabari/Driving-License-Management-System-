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
using DVLDPresentationLayer.PeopleScreens;

namespace DVLDPresentationLayer.Applications.Controls
{
    public partial class ctrlApplicationInfo : UserControl
    {
        clsApplication _application;
        clslocalLicenseApplication _LocalApplication;
        public ctrlApplicationInfo()
        {
            InitializeComponent();
        }

        public int localDrivingLicenseApplicationID;

        public void LoadLocalApplicationInfo()
        {

             _application = clsApplication.FindByLocalDrivingLicenseApplicationID(localDrivingLicenseApplicationID);
            _LocalApplication = clslocalLicenseApplication.Find(localDrivingLicenseApplicationID);
            // Application Properties
            labelIDResult.Text = _application.ApplicationID.ToString();
            labelStatusResult.Text = _application.ApplicationStatus.ToString();
            labelFeesResult.Text = _application.PaidFees.ToString();
            labelTypeResult.Text = clsApplicationType.GetApplicationTypeName(_application.ApplicationTypeID);
            labelApplicantResult.Text = _application.ApplicantFullName;
            labelDateResult.Text = _application.ApplicationDate.ToString("yyyy/MM/dd");
            labelStatusDateResult.Text = _application.LastStatusDate.ToString("yyyy/MM/dd");
            labelCreatedByResult.Text = clsGlobalUser.CurrentUser.UserName;

            // Local Application Properties

            labelDLAppIDResult.Text = _LocalApplication.LocalDrivingLicenseApplicationID.ToString();
            labelAppliedForLicenseResult.Text = clsLicenseClass.GetClassName(_LocalApplication.LicenseClassID);
            labelPassedTestResult.Text = clslocalLicenseApplication.PassedTest(localDrivingLicenseApplicationID).ToString() + "/3";
            
        }

        private void ctrlApplicationInfo_Load(object sender, EventArgs e)
        {

        }

        private void linkViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clsPerson _Person = clsPerson.Find(_application.ApplicantPersonID);
            frmPersonDetails frm = new frmPersonDetails(_Person);
            frm.ShowDialog();
        }
    }
}
