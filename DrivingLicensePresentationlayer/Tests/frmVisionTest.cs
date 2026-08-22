using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDPresentationLayer.Tests
{
    public partial class frmVisionTest : Form
    {
        int _localDrivingLicenseApplicationID;
        public frmVisionTest()
        {
            InitializeComponent();
        }
        public frmVisionTest(int localDrivingLicenseApplicationID)
        {

            InitializeComponent();
            _localDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
        }

        private void frmVisionTest_Load(object sender, EventArgs e)
        {
            ctrlApplicationInfo1.localDrivingLicenseApplicationID = _localDrivingLicenseApplicationID;
            ctrlApplicationInfo1.LoadLocalApplicationInfo();
        }
    }
}
