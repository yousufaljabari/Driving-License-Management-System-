using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDPresentationLayer.Users
{
    public partial class frmShowUserDetails : Form
    {
        int _UserID;
        public frmShowUserDetails(int UserID)
        {
            InitializeComponent();
            this._UserID = UserID;
        }

        private void frmShowUserDetailscs_Load(object sender, EventArgs e)
        {
            userControlShowDetails1.LoadUserData(_UserID);
        }
    }
}
