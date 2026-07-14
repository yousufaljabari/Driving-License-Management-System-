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

namespace DVLDPresentationLayer.Applications
{
    public partial class frmUpdateApplicationType : Form
    {
        clsApplicationType.enMode _Mode;
        clsApplicationType _AppplicationType;
        public frmUpdateApplicationType(int ID)
        {
            InitializeComponent();
            _AppplicationType = clsApplicationType.GetApplicationTypeInfoByID(ID);
            _Mode = clsApplicationType.enMode.Update;
        }
        private void loadApplicationData()
        {
            labelApplicationIDR.Text = _AppplicationType.ID.ToString();
            textBoxTitle.Text = _AppplicationType.Title;
            textBoxFees.Text = _AppplicationType.Fees.ToString();
            
        }
        private bool FillApplicationObject()
        {
            if(!String.IsNullOrEmpty(textBoxTitle.Text))
            {
                _AppplicationType.Title = textBoxTitle.Text;
            }
            else
            {
                return false;
            }
            if (!String.IsNullOrEmpty(textBoxFees.Text))
            {
                _AppplicationType.Fees = Convert.ToDecimal(textBoxFees.Text);
            }
            else
            {
                return false;
            }
            return true;
        }

        private void frmUpdateApplicationTypes_Load(object sender, EventArgs e)
        {
            if (_AppplicationType != null)
            {
                loadApplicationData();
            }
            else
            {
                MessageBox.Show("Data Not Found ");
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (_Mode == clsApplicationType.enMode.Update)
            {
                if (FillApplicationObject())
                {
                    if (_AppplicationType.Save())
                    {
                        MessageBox.Show("Application Update Succesfully");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Application Update Failed");
                    }
                }
                else
                {
                    MessageBox.Show("Fill All Fileds");
                }
            }
        }
    }
}
