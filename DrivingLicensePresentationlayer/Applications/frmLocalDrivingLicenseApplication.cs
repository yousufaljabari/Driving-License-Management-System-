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
using DVLDPresentationLayer.People.Controls;
using Microsoft.VisualBasic;
using static System.Net.Mime.MediaTypeNames;

namespace DVLDPresentationLayer.Applications
{

    public partial class frmLocalDrivingLicenseApplication : Form
    {
        clslocalLicenseApplication.enMode _Mode;
        clsApplication Application;
        //this use for generate Local License Application
        int ApplicationID;
        public frmLocalDrivingLicenseApplication()
        {
            InitializeComponent();
            userControlPersonCardWithFilter1.UserControlPersonCard.ShowCloseButton = false;
            userControlPersonCardWithFilter1.UseFor = UserControlPersonCardWithFilter.enUseFor.LocalLicenseApplication;
            _Mode = clslocalLicenseApplication.enMode.Add;
            userControlPersonCardWithFilter1.OnNextClicked += frmAddLocalDrivingLicense_Next;
        }

        public void frmAddLocalDrivingLicense_Next(object sender, EventArgs e)
        {
            tabControlLocalLicenseApplication.SelectedTab = tabPageApplicationInfo;
        }

        private void tabPageApplicationInfo_Click(object sender, EventArgs e)
        {
            buttonSave.Enabled = true;
        }

        private bool generateApplicationAndSave()
        {
            Application = new clsApplication();

            Application.ApplicantPersonID = userControlPersonCardWithFilter1.SelectedPersonID;
            Application.ApplicationTypeID = (int)clsApplicationType.enApplicationType.NewLocalDrivingLicense;
            Application.ApplicationStatus = 1;
            decimal paidFees = clsApplicationType.GetApplicationFees(Application.ApplicationTypeID);
            Application.PaidFees = paidFees;

            Application.CreatedByUserID = clsGlobalUser.CurrentUser.UserID;



            if (!Application.Save())
            {
                MessageBox.Show(
                    "Failed to generate the main application.",
                    "Save Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }

            ApplicationID = Application.ApplicationID;

            return true;

        }

        private bool GenerateLocalLicenseApplicationAndSave()
        {
            clslocalLicenseApplication localApplication =
                new clslocalLicenseApplication();

            localApplication.ApplicationID = ApplicationID;

            localApplication.LicenseClassID =
                Convert.ToInt32(comboBoxLicenseClass.SelectedValue);

            if (!localApplication.Save())
            {
                MessageBox.Show(
                    "Failed to generate the local driving license application.",
                    "Save Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }

            return true;
        }
        private void LoadLicenseClasses()
        {
            comboBoxLicenseClass.DataSource =
                clsLicenseClass.GetAllLicenseClasses();

            comboBoxLicenseClass.DisplayMember = "ClassName";

            comboBoxLicenseClass.ValueMember = "LicenseClassID";

            comboBoxLicenseClass.SelectedIndex = 0;
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {

            int licenseClassID = Convert.ToInt32(comboBoxLicenseClass.SelectedValue);

            if (clslocalLicenseApplication.DoesHaveActiveApplicationForLicenseClass(userControlPersonCardWithFilter1.SelectedPersonID, licenseClassID))
            {
                MessageBox.Show(
                    "This person already has an active application for this license class.",
                    "Not Allowed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!generateApplicationAndSave())
                return;

            if (!GenerateLocalLicenseApplicationAndSave())
                return;

            MessageBox.Show(
                $"Application saved successfully.\nApplication ID: {ApplicationID}",
                "Saved",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            buttonSave.Enabled = false;
        }

        private void frmLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            buttonSave.Enabled = false;
            labelAppDateResult.Text = DateTime.Now.ToString("dd/MM/yyyy");
            labelAppFeesResult.Text = clsApplicationType.GetApplicationFees((int)(clsApplicationType.enApplicationType.NewLocalDrivingLicense)).ToString();
            labelUser.Text = clsGlobalUser.CurrentUser.UserName;
            LoadLicenseClasses();
            comboBoxLicenseClass.SelectedIndex = 2;

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPagePersonalInfo_Click(object sender, EventArgs e)
        {

        }

        private void tabControlLocalLicenseApplication_TabIndexChanged(object sender, EventArgs e)
        {
            buttonSave.Enabled =
        tabControlLocalLicenseApplication.SelectedTab ==
        tabPageApplicationInfo;
        }

        private void tabControlLocalLicenseApplication_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            buttonSave.Enabled =
        tabControlLocalLicenseApplication.SelectedTab ==
        tabPageApplicationInfo;
        }
    }
}
