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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace DVLDPresentationLayer.PeopleScreens
{
    public partial class frmAddEditPerson : Form
    {
       
        enum enMode { Add = 0, Edit = 1 };
        clsPerson _Person;
        enMode _Mode;

        public event Action<int> OnPersonAdded;
        public event Action<int> onPersonUpdated;

        public virtual void PersronAdded(int PersonID)
        {
            OnPersonAdded?.Invoke(PersonID);
        }

        private void frmAddEditPerson_PersonAdded(int PersonID)
        {
            MessageBox.Show("Selected Person ID: " + PersonID);

           
        }


        public void FillPersonObject()
        { 
            _Person.NationalNo = textBoxNationalNo.Text;
            _Person.FirstName = textBoxFirstName.Text;
            _Person.SecondName = textBoxSecondName.Text;
            _Person.ThirdName = textBoxThirdName.Text;
            _Person.LastName = textBoxLastName.Text;
            _Person.DateOfBirth = dateTimePickerDateofBirth.Value;
            if (radioButtonMale.Checked)
            {
                _Person.Gender = Convert.ToInt32(radioButtonMale.Tag);
            }
            else
            {
                _Person.Gender = Convert.ToInt32(radioButtonFemale.Tag);
            }
            _Person.Address = textBoxAddress.Text;
            _Person.Email = textBoxEmail.Text;
            _Person.Phone = textBoxPhone.Text;
            _Person.NationalityCountryID = Convert.ToInt32(comboBoxCountries.SelectedValue);
            
        }
        public void AddNewPerson()
        {
            
           
            FillPersonObject();
            _Person.Save();
            
        }

        public void UpdatePerson()
        {
            FillPersonObject();
            _Person.Save();
        }
        public void GetAllCountries()
        {
            DataTable dt = clsCountry._GetAllCoutries();

            comboBoxCountries.DataSource = dt;
            comboBoxCountries.DisplayMember = "CountryName";
            comboBoxCountries.ValueMember = "CountryID";

            
        }
        public frmAddEditPerson()
        {
            InitializeComponent();
            _Person = new clsPerson();
            labelTitleMode.Text = "Add New Person";
            _Mode = enMode.Add;


        }
        public frmAddEditPerson(int ID)
        {
            InitializeComponent();
            _Person = clsPerson.Find(ID);

            labelTitleMode.Text = "Edit Person With ID = " + ID.ToString();
            _Mode = enMode.Edit;
             labelPersonID.Text = ID.ToString();
           
           
        }

        private void _LoadPersonData()
        {
            if (_Person != null)
            {


                textBoxNationalNo.Text = _Person.NationalNo;
                textBoxFirstName.Text = _Person.FirstName;
                textBoxSecondName.Text = _Person.SecondName;
                textBoxThirdName.Text = _Person.ThirdName;
                textBoxLastName.Text = _Person.LastName;

                dateTimePickerDateofBirth.Value = _Person.DateOfBirth;

                if (_Person.Gender == Convert.ToInt32(radioButtonMale.Tag))
                {
                    radioButtonMale.Checked = true;
                }
                else
                {
                    radioButtonFemale.Checked = true;
                }

                textBoxAddress.Text = _Person.Address;
                textBoxEmail.Text = _Person.Email;
                textBoxPhone.Text = _Person.Phone;

                comboBoxCountries.SelectedValue = _Person.NationalityCountryID;

                if (_Person.ImagePath != null && _Person.ImagePath != "")
                {
                    pictureBoxPersonImage.ImageLocation = _Person.ImagePath;
                }

            }


            }

        private void btnSave_Click(object sender, EventArgs e)
        {
           

            switch (_Mode)
            {
                case enMode.Add:
                    {
                        AddNewPerson();
                        _Mode = enMode.Edit;
                       
                        this.DialogResult = DialogResult.OK;
                        PersronAdded(_Person.ID);
                        this.Close();
                        break;
                    }

                case enMode.Edit:
                {
                       
                   UpdatePerson();
                   MessageBox.Show("Updated Successfuly");
                        
                        this.DialogResult = DialogResult.OK;
                        onPersonUpdated?.Invoke(_Person.ID);
                        this.Close();
                        
                        break;
                }
            }

        }

        private void frmAddEditPerson_Load(object sender, EventArgs e)
        {
                GetAllCountries();
                DateTime today = DateTime.Today;

                dateTimePickerDateofBirth.MinDate = today.AddYears(-100);

                dateTimePickerDateofBirth.MaxDate = today.AddYears(-18);
                dateTimePickerDateofBirth.Value = today.AddYears(-18);
            if (_Mode == enMode.Add)
            {
                comboBoxCountries.SelectedIndex = comboBoxCountries.FindString("Jordan");
            }
            else if (_Mode == enMode.Edit)
            {
                if (_Person == null)
                {
                    MessageBox.Show("Person not found.");
                    this.Close();
                    return;
                }

                _LoadPersonData();
            }

        }

        
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabelSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.png;*.jpeg";

            if (open.ShowDialog() == DialogResult.OK)
            {
                string sourcePath = open.FileName;
                string folderPath = Path.Combine(Application.StartupPath, "PersonImages");

                if (!Directory.Exists(folderPath))
                    Directory.CreateDirectory(folderPath);

                string fileName = Guid.NewGuid().ToString() + Path.GetExtension(sourcePath);
                string newPath = Path.Combine(folderPath, fileName);

                try
                {
                   
                    pictureBoxPersonImage.Image = null;

                  
                    File.Copy(sourcePath, newPath, true);

                  
                    string oldImagePath = _Person?.ImagePath;
                    if (!string.IsNullOrEmpty(oldImagePath) && File.Exists(oldImagePath))
                    {
                        File.Delete(oldImagePath);
                    }

                  
                    pictureBoxPersonImage.ImageLocation = newPath;
                    _Person.ImagePath = newPath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    _Person.ImagePath = "";
                }
            }
        }
        private void radioButtonMale_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButtonMale.Checked)
            {
                pictureBoxPersonImage.Image = Properties.Resources.man;


            }
        }

        private void radioButtonFemale_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButtonFemale.Checked)
            {
                pictureBoxPersonImage.Image = Properties.Resources.woman;

            }
        }
    }

}
