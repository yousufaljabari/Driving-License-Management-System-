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
using DVLDDataAccessLayer;

namespace DVLDPresentationLayer.Users
{
    public partial class frmChangeUserPassword : Form
    {
        int _UserID;
        clsUserInfo _User;

        public frmChangeUserPassword(int _UserID)
        {
            InitializeComponent();
            this._UserID = _UserID;


        }

        private bool ValidatePasswordChange()
        {
            string CurrentPassword = textBoxCurrentPassword.Text.Trim();
            string NewPassword = textBoxNewPassword.Text.Trim();
            string ConfirmPassword = textBoxConfirmPassword.Text.Trim();
            string Password = clsUserInfo.GetPassword(this._UserID);
            if (String.IsNullOrEmpty(CurrentPassword))
            {
                errorProviderPasswordChange.SetError(textBoxCurrentPassword, "Password is Required");
                return false;
            }
            else
            {
                errorProviderPasswordChange.SetError(textBoxCurrentPassword, "");
                if (CurrentPassword == Password)
                {
                    errorProviderPasswordChange.SetError(textBoxCurrentPassword, "");
                }
                else
                {
                    errorProviderPasswordChange.SetError(textBoxCurrentPassword, "Current Password not match Actually Password");
                    return false;
                }
            }
            if (String.IsNullOrEmpty(NewPassword))
            {
                errorProviderPasswordChange.SetError(textBoxNewPassword, "Password is Required");
                return false;
            }
            else
            {
                errorProviderPasswordChange.SetError(textBoxNewPassword, "");
            }
            if (String.IsNullOrEmpty(ConfirmPassword))
            {
                errorProviderPasswordChange.SetError(textBoxConfirmPassword, "Password is Required");
                return false;
            }
            else
            {
                errorProviderPasswordChange.SetError(textBoxConfirmPassword, "");
            }
            if (NewPassword != ConfirmPassword)
            {
                errorProviderPasswordChange.SetError(textBoxConfirmPassword, "Confirm password does not match new password.");
                return false;
            }
            else
            {
                errorProviderPasswordChange.SetError(textBoxConfirmPassword, "");
                return true;
            }

        }

        private void PasswordChange(object sender, EventArgs e)
        {
            buttonSave.Enabled = ValidatePasswordChange();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            _User.Password= textBoxNewPassword.Text.Trim();
            if (_User.Save())
            {
                MessageBox.Show(
                    "Password Changed Successfully.",
                    "Saved",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                
            }
            else
            {
                MessageBox.Show(
                    "An Error Occured, password did not change.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

        }

        private void frmChangeUserPassword_Load(object sender, EventArgs e)
        {
           _User = clsUserInfo.Find(_UserID);
            if(_User==null)
            {
                MessageBox.Show( "Could Not Find User with ID = " + _UserID,  "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Close();
                return;
            }
            userControlShowDetails1.LoadUserData(this._UserID);
        }
    }
}
