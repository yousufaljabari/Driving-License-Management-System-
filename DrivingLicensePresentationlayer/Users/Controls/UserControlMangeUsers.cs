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
using DVLDPresentationLayer.People;
using System.Runtime.CompilerServices;
using DVLDDataAccessLayer;

namespace DVLDPresentationLayer.Users.Controls
{
    public partial class UserControlMangeUsers : UserControl
    {

        public UserControlMangeUsers()
        {
            InitializeComponent();
        }

        public event EventHandler OnRequestClose;

        public void RequestClose()
        {
            OnRequestClose?.Invoke(this, EventArgs.Empty);
        }

        private void UserControlMangeUsers_Load(object sender, EventArgs e)
        {
            comboBoxFilterByUsers.SelectedIndex = 0;
            comboBoxIsActivechoices.SelectedIndex = 0;
        }


        private void buttonCloseUserForm_Click(object sender, EventArgs e)
        {
            RequestClose();
        }
        public void UsersFillDataGrid(DataTable dt)
        {
            if (dt != null && dt.Rows.Count > 0)
            {
                dataGridMangeUsers.DataSource = dt;
                labelRecordUsersNumbers.Text = $"Records = {dt.Rows.Count.ToString()} ";
            }
            else
            {
                dataGridMangeUsers.DataSource = null;
                labelRecordUsersNumbers.Text = "Records = 0";
            }
        }
        public void GetAllUsers()
        {
            DataTable dt = clsUserInfo.GetAllUsers();
            UsersFillDataGrid(dt);

        }
        public void GetUsersByUserID(int UserID)
        {
            DataTable dt = clsUserInfo.GetUserByUserID(UserID);
            UsersFillDataGrid(dt);
        }

        public void GetUsersByUsername(string Username)
        {
            DataTable dt = clsUserInfo.GetUserByUsername(Username);
            UsersFillDataGrid(dt);
        }


        public void GetUserByPersonID(int PersonID)
        {
            DataTable dt = clsUserInfo.GetUserByPersonID(PersonID);
            UsersFillDataGrid(dt);
        }

        public void GetUsersByFullName(string FullName)
        {
            DataTable dt = clsUserInfo.GetUserByFullName(FullName);
            UsersFillDataGrid(dt);
        }
        public void GetUserByisActive()
        {
            bool? isActive = null;

            if (comboBoxIsActivechoices.Text == "Yes")
            {
                isActive = true;
            }
            else if (comboBoxIsActivechoices.Text == "No")
            {
                isActive = false;
            }
            else
                isActive = null;

            dataGridMangeUsers.DataSource = clsUserInfo.GetUserByisActive(isActive);
        }


        public void userSwitchCase()
        {
            comboBoxIsActivechoices.Visible = false;
            textBoxFilterby.Visible = true;
            comboBoxIsActivechoices.Visible = false;
            textBoxFilterby.Clear();
            textBoxFilterby.Focus();

        }
        private void checkItemByIndex(int index)
        {
            int ID = -1;
            switch (index)
            {

                case 0:
                    {
                        comboBoxIsActivechoices.Visible = false;
                        textBoxFilterby.Visible = false;
                        GetAllUsers();
                        break;

                    }
                case 1:
                    {

                        userSwitchCase();
                        break;

                    }
                case 2:
                    {
                        userSwitchCase();
                        break;

                    }
                case 3:
                    {
                        userSwitchCase();
                        break;
                    }

                case 4:
                    {
                        userSwitchCase();
                        break;
                    }
                case 5:
                    {
                        comboBoxIsActivechoices.Visible = true;
                        textBoxFilterby.Visible = false;
                        break;
                    }




            }

        }
        private void textBoxFilterby_TextChanged(object sender, EventArgs e)
        {
            int ID;
            if (String.IsNullOrEmpty(textBoxFilterby.Text))
            {

                GetAllUsers();
                return;
            }
            if (comboBoxFilterByUsers.SelectedIndex == 1)
            {

                if (int.TryParse(textBoxFilterby.Text, out ID))
                {
                    GetUsersByUserID(ID);
                }

            }
            else if (comboBoxFilterByUsers.SelectedIndex == 2)
            {
                string Username = textBoxFilterby.Text;
                GetUsersByUsername(Username);
            }
            else if (comboBoxFilterByUsers.SelectedIndex == 3)
            {

                if (int.TryParse(textBoxFilterby.Text, out ID))
                {
                    GetUserByPersonID(ID);
                }
                GetUserByPersonID(ID);
            }
            else if (comboBoxFilterByUsers.SelectedIndex == 4)
            {
                string FullName = textBoxFilterby.Text;
                GetUsersByFullName(FullName);
            }

        }

        private void comboBoxFilterByUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkItemByIndex(comboBoxFilterByUsers.SelectedIndex);
        }

        private void textBoxFilterby_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBoxFilterByUsers.SelectedIndex == 1 || comboBoxFilterByUsers.SelectedIndex == 3)
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                {
                    e.Handled = true;
                }
            }
        }

        private void comboBoxIsActivechoices_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxIsActivechoices.SelectedIndex == 0)
            {
                DataTable dt = clsUserInfo.GetUserByisActive();
                UsersFillDataGrid(dt);
            }
            else if (comboBoxIsActivechoices.SelectedIndex == 1)
            {
                DataTable dt = clsUserInfo.GetUserByisActive(true);
                UsersFillDataGrid(dt);
            }
            else if (comboBoxIsActivechoices.SelectedIndex == 2)
            {
                DataTable dt = clsUserInfo.GetUserByisActive(false);
                UsersFillDataGrid(dt);
            }

        }

        private void buttonAddNewUser_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser();
            frm.onUserAdded += frm_PersonAdded;
            frm.ShowDialog();
        }

        public void frm_PersonAdded(int UserID)
        {

            MessageBox.Show($"User Added Successfully with User ID = {UserID}");
            GetAllUsers();
        }

        private void toolStripShowDetails_Click(object sender, EventArgs e)
        {
            if (dataGridMangeUsers.CurrentRow != null)
            {

                int _UserID = Convert.ToInt32(dataGridMangeUsers.CurrentRow.Cells["UserID"].Value);

                frmShowUserDetails frm = new frmShowUserDetails(_UserID);
                frm.ShowDialog();
            }

        }

        private void _refreshList()
        {
            GetAllUsers();
        }

        private void ToolStripaddNewUser_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser();
            frm.ShowDialog();
            _refreshList();
        }

        private void ToolStripedit_Click(object sender, EventArgs e)
        {
            int _UserID = Convert.ToInt32(dataGridMangeUsers.CurrentRow.Cells["UserID"].Value);
            frmAddUpdateUser frm = new frmAddUpdateUser(_UserID);
            frm.ShowDialog();
            _refreshList();

        }

        private void ToolStripsendEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature is Not Implemented Yet", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ToolStripphoneCall_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature is Not Implemented Yet", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ToolStripchangePassword_Click(object sender, EventArgs e)
        {
            int _UserID = Convert.ToInt32(dataGridMangeUsers.CurrentRow.Cells["UserID"].Value);
            frmChangeUserPassword frm = new frmChangeUserPassword(_UserID);
            frm.ShowDialog();
        }

        private void ToolStripdelete_Click(object sender, EventArgs e)
        {
            int _UserID= Convert.ToInt32(dataGridMangeUsers.CurrentRow.Cells["UserID"].Value);
            bool isDeleted =clsUserInfo.DeleteUser(_UserID);
            
                if (MessageBox.Show("Are you sure you want to delete?", "Confirm Delete"
                    ,MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (isDeleted)
                    {
                        MessageBox.Show("User Deleted Successfully.");
                        _refreshList();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete user because is active.");
                    }
                }

            
            
        }
    }
}
