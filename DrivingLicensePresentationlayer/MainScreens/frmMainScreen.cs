using System.Windows.Forms;
using DVDLPresentationLayer.ListScreen;
using DVLDBusinessLayer;
using DVLDPresentationLayer;
using DVLDPresentationLayer.Applications;
using DVLDPresentationLayer.MainScreens;
using DVLDPresentationLayer.Tests;
using DVLDPresentationLayer.UserControls;
using DVLDPresentationLayer.Users;

namespace DrivingLicenseMangement
{
    public partial class frmMainScreen : Form
    {
        int _CurrentUserID;
        frmUserLoginScreen frm;

        public frmMainScreen(frmUserLoginScreen frmlogin)
        {
            InitializeComponent();

            this.frm = frmlogin;
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListPeople form = new frmListPeople();

            form.ShowDialog(this);

        }

        private void frmMainScreen_Load(object sender, EventArgs e)
        {

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMangeUsersScreen form = new frmMangeUsersScreen();
            //form.MdiParent = this;
            //form.Dock = DockStyle.Fill;
            form.ShowDialog(this);
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm.Show();
            this.Close();

        }

        private void currentUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowUserDetails frm = new frmShowUserDetails(clsGlobalUser.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void ToolStripchangePassword_Click(object sender, EventArgs e)
        {

            frmChangeUserPassword frm = new frmChangeUserPassword(_CurrentUserID);
            frm.ShowDialog();

        }

        private void ToolStripMenuItemMangeApplicationTypes_Click(object sender, EventArgs e)
        {
            FrmMangeApplicationTypeList frm = new FrmMangeApplicationTypeList();
            frm.ShowDialog();
        }

        private void mangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMangeTestTypesList frm = new frmMangeTestTypesList();
            frm.ShowDialog();
        }

        private void localDrivingLicenseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmlocalLicenseApplication frm = new frmlocalLicenseApplication();
            frm.ShowDialog();
        }
    }
}
