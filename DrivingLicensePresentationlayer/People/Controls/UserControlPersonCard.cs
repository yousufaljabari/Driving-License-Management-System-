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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using DVLDPresentationLayer.PeopleScreens;


namespace DVLDPresentationLayer.UserControls
{
    public partial class UserControlPersonCard : UserControl
    {

        int person_ID;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool ShowCloseButton
        {
            set { buttonClose.Visible = value; }
            get { return buttonClose.Visible; }
        }
        public UserControlPersonCard()
        {
            InitializeComponent();

        }

        public event EventHandler Close;

        private void UserControlShowDetails_Load(object sender, EventArgs e)
        {

        }

        public void FillInformation(clsPerson person)
        {
            if (person != null)
            {
                person_ID = person.ID;
                labelPersonD.Text = person.ID.ToString();
                labelNationalNoD.Text = person.NationalNo;
                labelNameD.Text = person.FirstName + " " + person.SecondName + " " + person.ThirdName + " " + person.LastName;
                labelGenderD.Text = person.Gender.ToString();
                labelDateOfBirthD.Text = person.DateOfBirth.ToString();
                labelAddressD.Text = person.Address;
                labelPhoneD.Text = person.Phone;
                labelEmailD.Text = person.Email;
                LabelCountryD.Text = clsCountry._GetNationalityCountryNameByID(person.NationalityCountryID);
                if (!string.IsNullOrEmpty(person.ImagePath) && File.Exists(person.ImagePath))
                {
                    pictureBoxPersonImageDetails.ImageLocation = person.ImagePath;
                }
                else
                {
                    pictureBoxPersonImageDetails.Image = person.Gender == 0
                        ? Properties.Resources.man
                        : Properties.Resources.woman;
                }
            }
        }
        protected virtual void OnRequestClose()
        {
            Close?.Invoke(this, EventArgs.Empty);
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            OnRequestClose();
        }

        private void linkLabelEditPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (int.TryParse(labelPersonD.Text, out int PersonID))
            {

                frmAddEditPerson frm = new frmAddEditPerson(PersonID);

                frm.onPersonUpdated += (UpdatedPersonID) =>
                {
                    clsPerson updatedPerson = clsPerson.Find(UpdatedPersonID);
                    if (updatedPerson != null)
                    {
                        FillInformation(updatedPerson);
                    }
                };

                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Person ID. Please select a valid person first.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }
