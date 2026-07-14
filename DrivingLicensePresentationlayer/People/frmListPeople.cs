using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Identity.Client;
using DVLDBusinessLayer;
using DVLDPresentationLayer.UserControls;

namespace DVDLPresentationLayer.ListScreen
{
    public partial class frmListPeople : Form
    {
        public frmListPeople()
        {
            InitializeComponent();
           
        }

        private void frmListPeople_Load(object sender, EventArgs e)
        {
            userctrlShowPeople1.ShowPeople();
        }

        private void userctrlShowPeople1_Load(object sender, EventArgs e)
        {
         
        }
    }
}
