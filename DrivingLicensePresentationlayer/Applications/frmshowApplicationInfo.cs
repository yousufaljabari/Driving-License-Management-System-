using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDPresentationLayer.Applications
{
    public partial class frmshowApplicationInfo : Form
    {
        int _localDrivingLicenseApplicationID;
        public frmshowApplicationInfo(int localDrivingLicenseApplicationID)
        {
            InitializeComponent();
            this._localDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
        }

        private void frmshowApplicationInfo_Load(object sender, EventArgs e)
        {
            ctrlApplicationInfo1.localDrivingLicenseApplicationID = _localDrivingLicenseApplicationID;
            ctrlApplicationInfo1.LoadLocalApplicationInfo();
        }
    }
}
