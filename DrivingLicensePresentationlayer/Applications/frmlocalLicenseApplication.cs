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

namespace DVLDPresentationLayer.Applications
{
    public partial class frmlocalLicenseApplication : Form
    {
        public frmlocalLicenseApplication()
        {
            InitializeComponent();
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
            frm.ShowDialog();
        }
    }
}


    

