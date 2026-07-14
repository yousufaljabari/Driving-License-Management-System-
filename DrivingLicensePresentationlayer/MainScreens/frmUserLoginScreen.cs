using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrivingLicenseMangement;
using DVLDBusinessLayer;

namespace DVLDPresentationLayer.MainScreens
{
    
    public partial class frmUserLoginScreen : Form
    {

        

        public frmUserLoginScreen()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public delegate void OnLoginSuccess(clsUserInfo CurrentUser);
        public event OnLoginSuccess LoginSuccess;

        private void UserLoginScreen_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.RememberMe)
            {
                textBoxUserName.Text = Properties.Settings.Default.Username;
                textBoxPassword.Text = Properties.Settings.Default.Password;
                checkboxRememberme.Checked = true;
            }
            else
            {
                textBoxUserName.Text = "";
                textBoxPassword.Text = "";
                checkboxRememberme.Checked = false;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            
            string Username = textBoxUserName.Text.Trim();
            string Password = textBoxPassword.Text.Trim();
            if (Username!=null && Password!=null)
            {
                
                if ( clsUserInfo.checkUserLogin(Username,Password))
                {
                    Properties.Settings.Default.RememberMe = checkboxRememberme.Checked;
                    Properties.Settings.Default.Username = Username;
                    Properties.Settings.Default.Password = Password;
                    Properties.Settings.Default.Save();
                    
                    int _UserCurrentID = clsUserInfo.GetUserIDByUsernameAndPassword(Username, Password);
                    clsGlobalUser.CurrentUser = clsUserInfo.Find(_UserCurrentID);
                    frmMainScreen frm = new frmMainScreen(this);
                    this.Hide();
                    frm.ShowDialog();
                   
                }
                else
                {
                    Properties.Settings.Default.RememberMe = false;
                    Properties.Settings.Default.Username = "";
                    Properties.Settings.Default.Password = "";
                    Properties.Settings.Default.Save();
                    MessageBox.Show("Invalid Username/Password Or Not Active ","Wrong Credintials",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }

            }
        }
    }
}
