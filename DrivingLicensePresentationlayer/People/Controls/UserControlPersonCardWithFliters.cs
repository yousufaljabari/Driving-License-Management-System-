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
using DVLDPresentationLayer.UserControls;
using DVLDPresentationLayer.PeopleScreens;
using System.Runtime.CompilerServices;

namespace DVLDPresentationLayer.People.Controls
{
    public partial class UserControlPersonCardWithFilter : UserControl
    {
        clsPerson _Person;
        public int SelectedPersonID = 0;

        public enum enUseFor
        {
         Users = 0,
         LocalLicenseApplication = 1
        }

         [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
         public enUseFor UseFor { get; set; }


        public enum enMode
        {
            Add = 0,
            Update = 1
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public enMode Mode { get; set; }




        public event Action<int> onPersonSelected;

        public event EventHandler OnRequsetdClose;

        public event EventHandler OnNextClicked;

        

        public UserControlPersonCard UserControlPersonCard
        {
            get { return userControlPersonCard1; }
        }
        public GroupBox GroupBoxFilterBy
        {
            get { return groupBoxFliterBy; }

        }
        public UserControlPersonCardWithFilter()
        {
            InitializeComponent();
            userControlPersonCard1.Close += UserControlPersonCard1_RequestClose;


        }



        protected virtual void NextClicked()
        {
            OnNextClicked?.Invoke(this, EventArgs.Empty);
        }
        protected virtual void PersonSelected(int PersonID)
        {
            onPersonSelected?.Invoke(PersonID);
        }

        public virtual void RequsetClose()
        {
            OnRequsetdClose?.Invoke(this, EventArgs.Empty);
        }





        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (comboBoxFIndBy.SelectedIndex == 0)
            {
                if (!String.IsNullOrEmpty(textBoxFindBy.Text))
                {
                    _Person = clsPerson.Find(int.Parse(textBoxFindBy.Text));
                    if (_Person != null)
                    {
                        userControlPersonCard1.FillInformation(_Person);
                        SelectedPersonID = _Person.ID;
                        PersonSelected(_Person.ID);

                    }
                    else
                    {
                        MessageBox.Show("Person Not Found");
                        textBoxFindBy.Text = "";
                        textBoxFindBy.Focus();
                    }
                }
            }
            else if (comboBoxFIndBy.SelectedIndex == 1)
            {

                if (!String.IsNullOrEmpty(textBoxFindBy.Text))
                {
                    _Person = clsPerson.FindByNationalNO(textBoxFindBy.Text);
                    if (_Person != null)
                    {
                        userControlPersonCard1.FillInformation(_Person);
                        SelectedPersonID = _Person.ID;
                    }
                    else
                    {
                        MessageBox.Show("Person Not Found");
                        textBoxFindBy.Text = "";
                        textBoxFindBy.Focus();
                    }
                }
            }
            //if (onPersonSelected != null)
            //{
            //    onPersonSelected(userControlPersonCard1.PersonID);
            //}
        }

        private void textBoxFindBy_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFindBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBoxFIndBy.SelectedIndex == 0)
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                {
                    e.Handled = true;
                }
            }
        }
        private void UserControlPersonCard1_RequestClose(object sender, EventArgs e)
        {
            RequsetClose();
        }


        private void textBoxFindBy_TextChanged_1(object sender, EventArgs e)
        {

        }


        private void buttonAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson();
            frm.OnPersonAdded += frm_OnPersonAdded;
            frm.ShowDialog();


        }
        public void frm_OnPersonAdded(int PersonID)
        {
            MessageBox.Show("Person With ID = " + PersonID + " Successfully Added");

        }

        public void frm_CloseForm()
        {
            RequsetClose();
        }
        public bool ValidatePersonForNext()
        {

            if (SelectedPersonID <= 0)
            {
                MessageBox.Show("Please Select a Person First");
                return false;

            }
            if (UseFor == enUseFor.Users && Mode==enMode.Add)
            {
                if (clsUserInfo.isPersonIDRelatedWithUser(SelectedPersonID))
                {
                    MessageBox.Show("This Person is already related with a User");
                    return false;
                }
            }


            return true;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (!ValidatePersonForNext())
            {
                return;
            }
            NextClicked();
        }

    }
    }
