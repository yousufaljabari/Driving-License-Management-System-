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

namespace DVLDPresentationLayer.Tests
{
    public partial class frmUpdateTestType : Form
    {
        clsTestType.enMode _Mode;
        clsTestType _TestType;
        public frmUpdateTestType(int ID)
        {
            InitializeComponent();
            _TestType = clsTestType.GetTestTypeInfoByID(ID);
            _Mode = clsTestType.enMode.Update;
        }
        private void loadTestTypeData()
        {
            labelTestIDR.Text = _TestType.ID.ToString();
            textBoxTestTitle.Text = _TestType.Title;
            textBoxDescription.Text = _TestType.Description;
            textBoxFees.Text = _TestType.Fees.ToString();

        }
        private bool FillTestObject()
        {
            if (!String.IsNullOrEmpty(textBoxTestTitle.Text))
            {
                _TestType.Title = textBoxTestTitle.Text;
            }
            else
            {
                return false;
            }
            if (!String.IsNullOrEmpty(textBoxDescription.Text))
            {
                _TestType.Description = textBoxDescription.Text;
            }
            else
            {
                return false;
            }
            if (!String.IsNullOrEmpty(textBoxFees.Text))
            {
                _TestType.Fees = Convert.ToDecimal(textBoxFees.Text);
            }
            else
            {
                return false;
            }
            return true;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUpdateTestType_Load(object sender, EventArgs e)
        {
            if (_TestType != null)
            {
                loadTestTypeData();
            }
            else
            {
                MessageBox.Show("Data Not Found ");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (_Mode == clsTestType.enMode.Update)
            {
                if (FillTestObject())
                {
                    if (_TestType.Save())
                    {
                        MessageBox.Show("Test Update Succesfully");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Test Update Failed");
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
