using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLDDataAccessLayer;
using DVLDBusinessLayer;
using System.Text.Json.Serialization;
using System.Reflection;
using DVLDPresentationLayer.PeopleScreens;
using DVDLPresentationLayer.ListScreen;

namespace DVLDPresentationLayer.UserControls
{
    public partial class UserctrlShowPeople : UserControl
    {
        public UserctrlShowPeople()
        {
            InitializeComponent();
         
        }


        public void ShowPeople()
        {
            DataTable dt = DVLDBusinessLayer.clsPerson._showPersonList();
            dataGridViewShowPeople.DataSource = dt;
            labelNumberOfRecord.Text = $"Records = {dt.Rows.Count.ToString()} ";

        }
        public void FillDataGrid(DataTable dt)
        {
            if (dt != null && dt.Rows.Count > 0)
            {
                dataGridViewShowPeople.DataSource = dt;
                labelNumberOfRecord.Text = $"Records = {dt.Rows.Count.ToString()} ";
            }
            else
            {
                dataGridViewShowPeople.DataSource = null;
                labelNumberOfRecord.Text = "Records = 0";
            }
        }
        public void GetPersonInfoByID(int ID)
        {
            DataTable dt = clsPerson._GetPersonByID(ID);

            FillDataGrid(dt);
        }
        public void GetPersonByNationalNo(string NationalNO)
        {
            DataTable dt = clsPerson._GetPersonByNationalNo(NationalNO);
            FillDataGrid(dt);

        }
        public void GetPersonInfoByFirstName(string FirstName)

        {
            DataTable dt = clsPerson._GetPersonByFirstName(FirstName);
            FillDataGrid(dt);
        }
        public void GetPersonInfoBySecondName(string SecondName)
        {
            DataTable dt = clsPerson._GetPersonBySecondName(SecondName);
            FillDataGrid(dt);
        }
        public void GetPersonInfoByThirdName(string ThirdName)
        {
            DataTable dt = clsPerson._GetPersonByThirdName(ThirdName);
            FillDataGrid(dt);
        }
        public void GetPersonInfoByLastName(string lastName)

        {
            DataTable dt = clsPerson._GetPersonByLastName(lastName);
            FillDataGrid(dt);
        }
        public void GetPersonInfoByNationaliy(int Nationality)
        {
            DataTable dt = clsPerson._GetPersonbyNationality(Nationality);
            FillDataGrid(dt);
        }

        public void GetPersonInfoByGender(int Gender)
        {
            DataTable dt = clsPerson._GetPersonInfoByGender(Gender);
            FillDataGrid(dt);
        }

        public void GetPersonInfoByPhone(string Phone)
        {
            DataTable dt = clsPerson._GetPersonByPhone(Phone);
            FillDataGrid(dt);
        }
        public void GetPersonInfoByEmail(string Email)
        {
            DataTable dt = clsPerson._GetPersonByEmail(Email);
            FillDataGrid(dt);
        }
        private void PersonSwitchCase()
        {
            textBoxFilterBy.Visible = true;
            textBoxFilterBy.Clear();
            textBoxFilterBy.Focus();
        }

        private void CheckitemByindex(int index)
        {
            int ID = -1;
            switch (index)
            {

                case 0:
                    {
                        textBoxFilterBy.Visible = false;
                        ShowPeople();
                        break;

                    }
                case 1:
                    {

                        PersonSwitchCase();
                        break;

                    }
                case 2:
                    {
                        PersonSwitchCase();
                        break;

                    }
                case 3:
                    {
                        PersonSwitchCase();
                        break;
                    }
                case 4:
                    {

                        PersonSwitchCase();
                        break;

                    }
                case 5:
                    {

                        PersonSwitchCase();
                        break;

                    }

                case 6:
                    {

                        PersonSwitchCase();
                        break;

                    }
                case 7:
                    {

                        PersonSwitchCase();
                        break;

                    }
                case 8:
                    {

                        PersonSwitchCase();
                        break;

                    }
                case 9:
                    {

                        PersonSwitchCase();
                        break;


                    }
                case 10:
                    {

                        PersonSwitchCase();
                        break;

                    }
            }


        }



        private void textBoxFilterBy_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFilterBy.Text))
            {
                ShowPeople();
                return;
            }

            if (comboBoxFilterBy.SelectedIndex == 1)
            {
                int ID;
                if (int.TryParse(textBoxFilterBy.Text, out ID))
                {
                    GetPersonInfoByID(ID);
                }


            }
            else if (comboBoxFilterBy.SelectedIndex == 2)
            {
                GetPersonByNationalNo(textBoxFilterBy.Text);
            }
            else if (comboBoxFilterBy.SelectedIndex == 3)
            {
                GetPersonInfoByFirstName(textBoxFilterBy.Text);
            }
            else if (comboBoxFilterBy.SelectedIndex == 4)
            {
                GetPersonInfoBySecondName(textBoxFilterBy.Text);
            }
            else if (comboBoxFilterBy.SelectedIndex == 5)
            {
                GetPersonInfoByThirdName(textBoxFilterBy.Text);
            }
            else if (comboBoxFilterBy.SelectedIndex == 6)
            {
                GetPersonInfoByLastName(textBoxFilterBy.Text);
            }
            else if (comboBoxFilterBy.SelectedIndex == 7)
            {
                int Nationaliy;
                if (int.TryParse(textBoxFilterBy.Text, out Nationaliy))
                {
                    GetPersonInfoByNationaliy(Nationaliy);
                }

            }
            else if (comboBoxFilterBy.SelectedIndex == 8)
            {
                int Gender;
                if (int.TryParse(textBoxFilterBy.Text, out Gender))
                {
                    GetPersonInfoByGender(Gender);
                }

            }
            else if (comboBoxFilterBy.SelectedIndex == 9)
            {
                GetPersonInfoByPhone(textBoxFilterBy.Text);
            }
            else if (comboBoxFilterBy.SelectedIndex == 10)
            {
                GetPersonInfoByEmail(textBoxFilterBy.Text);
            }





        }

        private void UserctrlShowPeople_Load(object sender, EventArgs e)
        {
           // ShowPeople();
        }

        private void comboBoxFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckitemByindex(comboBoxFilterBy.SelectedIndex);
        }

        private void textBoxFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBoxFilterBy.SelectedIndex == 1 || comboBoxFilterBy.SelectedIndex == 7 || comboBoxFilterBy.SelectedIndex == 8)
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                {
                    e.Handled = true;
                }
            }
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ShowPeople();
            }

        }

        private void ShowDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dataGridViewShowPeople.CurrentRow != null)
            {

                int PersonID = Convert.ToInt32(dataGridViewShowPeople.CurrentRow.Cells["PersonID"].Value);
                clsPerson Person = clsPerson.Find(PersonID);


                frmPersonDetails frm = new frmPersonDetails(Person);
                frm.ShowDialog();
                
                    ShowPeople();
               








            }

        }

        private void EditPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = Convert.ToInt32(dataGridViewShowPeople.CurrentRow.Cells["PersonID"].Value);
            frmAddEditPerson frm = new frmAddEditPerson(PersonID);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ShowPeople();
            }

        }

        private void addNewPersonToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ShowPeople();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = Convert.ToInt32(dataGridViewShowPeople.CurrentRow.Cells["PersonID"].Value);

            if (clsPerson.isPersonExist(PersonID))
            {
                if (MessageBox.Show(
                    "Are you sure you want to delete?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (clsPerson.DeletePerson(PersonID))
                    {
                        MessageBox.Show("Person Deleted Successfully.");
                        ShowPeople();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete contact.");
                    }
                }
            }
                                            }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature is Not Implemented Yet", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Warning) ;

        }

        private void callPhoneToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature is Not Implemented Yet", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
