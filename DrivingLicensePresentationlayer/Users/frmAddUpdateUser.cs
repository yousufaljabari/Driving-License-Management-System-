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
using DVLDPresentationLayer.UserControls;
using Microsoft.VisualBasic.ApplicationServices;

namespace DVLDPresentationLayer.People
{
    public partial class frmAddUpdateUser : Form
    {
        clsPerson _Person;
        clsUserInfo _User;
        private int _UserID;
        public event Action<int> onUserAdded;
        public event EventHandler onUserUpdated;

        enum enMode { Add = 0, Edit = 1 };
        enMode _Mode;


        
        public frmAddUpdateUser()
        {

            InitializeComponent();
            userControlPersonCardWithFilter1.UserControlPersonCard.ShowCloseButton = false;
            _Mode = enMode.Add;


        }
        public frmAddUpdateUser(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            _Mode = enMode.Edit;
            _User = clsUserInfo.Find(_UserID);
            _Person = clsPerson.Find(_User.PersonID);


        }
        private void _ResetForm()
        {
            if (_Mode == enMode.Add)
            {
                labelAddUpdateUser.Text = "Add New User";

                userControlPersonCardWithFilter1.Mode =
                    UserControlPersonCardWithFilter.enMode.Add;

                userControlPersonCardWithFilter1.UseFor =
                    UserControlPersonCardWithFilter.enUseFor.Users;

                return;
            }

            labelAddUpdateUser.Text = $"Update User With UserID = {_UserID}";

            userControlPersonCardWithFilter1.Mode =
                UserControlPersonCardWithFilter.enMode.Update;

            userControlPersonCardWithFilter1.UseFor =
                UserControlPersonCardWithFilter.enUseFor.Users;

            userControlPersonCardWithFilter1.GroupBoxFilterBy.Enabled = false;
            userControlPersonCardWithFilter1.UserControlPersonCard.ShowCloseButton = false;

            userControlPersonCardWithFilter1.SelectedPersonID = _User.PersonID;
            userControlPersonCardWithFilter1.UserControlPersonCard.FillInformation(_Person);

            _LoadUserData();
        }

        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            userControlPersonCardWithFilter1.OnNextClicked += FrmAddUpdateUser_OnNextClicked;

            _ResetForm();
            
        }
        private void _LoadUserData()
        {
            if (_User != null)
            {
                labelUserIDResult.Text = _User.UserID.ToString();
                textBoxUsername.Text = _User.UserName;
                textBoxPassword.Text = _User.Password;
                textBoxConfirmPassword.Text = _User.Password;
                checkBoxisActive.Checked = _User.IsActive;
            }
        }
        private bool _FillUserObject()
        {
            string newUserName = textBoxUsername.Text.Trim();
                if (newUserName != _User.UserName && clsUserInfo.checkUserNameIsFound(textBoxUsername.Text.Trim()))
                {
                textBoxUsername.Text = _User.UserName;
                MessageBox.Show("This Username already exists, please choose another one.", "Warning",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                return false;
                }


            _User.UserName = textBoxUsername.Text;
            _User.PersonID = userControlPersonCardWithFilter1.SelectedPersonID;
            _User.Password = textBoxPassword.Text;
            _User.IsActive = checkBoxisActive.Checked;
            return true;
        }
        public void AddNewUser()
        {
            _User = new clsUserInfo();
            _FillUserObject();
            _User.Save();
        }
        public bool UpdateUser()
        {
            if (!_FillUserObject())
            {
                return false;
            }
               return _User.Save();
        }
        private void FrmAddUpdateUser_OnNextClicked(object sender, EventArgs e)
        {
            tabControlAddNewUser.SelectedTab = tabPageLoginInfo;
        }
        

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (tabControlAddNewUser.SelectedTab == tabPagePersonalInfo)
            {

                MessageBox.Show("Please complete the Personal Info step and select a valid Person ID before adding the user.",
                                "Missing Person ID",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;

            }
            if (!ValidatePasswords())
            {
                MessageBox.Show("Please fix password errors before saving.");
                return;
            }

            switch (_Mode)
            {
                case enMode.Add:
                    {
                        AddNewUser();
                        _UserID = _User.UserID;
                       
                        onUserAdded?.Invoke(_UserID);
                        _Mode = enMode.Edit;

                        _ResetForm();

                        break;
                    }
                case enMode.Edit:
                    {

                        if (UpdateUser())
                        {
                            MessageBox.Show("User Updated Successfully");
                        }

                        break;
                    }
            }


        }

        private bool ValidatePasswords()
        {
            string password = textBoxPassword.Text.Trim();
            string confirmPassword = textBoxConfirmPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(password))
            {
                errorProviderCheckPassword.SetError(textBoxPassword, "Password is required.");
                return false;
            }
            else
            {
                errorProviderCheckPassword.SetError(textBoxPassword, "");
            }

            if (string.IsNullOrWhiteSpace(confirmPassword))
            {
                errorProviderCheckPassword.SetError(textBoxConfirmPassword, "Confirm password is required.");
                return false;
            }

            if (confirmPassword != password)
            {
                errorProviderCheckPassword.SetError(textBoxConfirmPassword, "Confirm password does not match password.");
                return false;
            }
            else
            {
                errorProviderCheckPassword.SetError(textBoxConfirmPassword, "");
                return true;
            }
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
           buttonSave.Enabled=ValidatePasswords();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userControlPersonCardWithFilter1_Load(object sender, EventArgs e)
        {

        }
    }
}
