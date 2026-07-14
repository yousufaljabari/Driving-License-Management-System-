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
using DVLDPresentationLayer.UserControls;

namespace DVLDPresentationLayer.PeopleScreens
{
    public partial class frmPersonDetails : Form
    {
        clsPerson _person;
        public frmPersonDetails()
        {
            InitializeComponent();
        }
        public frmPersonDetails(clsPerson Person)
        {
            InitializeComponent();
            _person = Person;
            userControlPersonCard1.Close += CloseRequest;

        }


        private void userControlShowDetails1_Load(object sender, EventArgs e)
        {


           // userControlPersonCard1.FillInformation(_person);



        }

        private void frmPersonDetails_Load(object sender, EventArgs e)
        {
            if (_person != null)
            {
             
                userControlPersonCard1.FillInformation(_person);
               
            }
           
        }

        public void CloseRequest(object sender,EventArgs e)
        {
            this.Close();
        }
    }
}
