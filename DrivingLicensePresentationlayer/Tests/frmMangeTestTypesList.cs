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
    public partial class frmMangeTestTypesList : Form
    {
        public frmMangeTestTypesList()
        {
            InitializeComponent();
        }
        private void RefreshTestTypesList()
        {
            DataTable dt = clsTestType.GetAllTestTypes();
            if (dt != null)
            {
                dataGridViewTestTypes.DataSource = dt;

                dataGridViewTestTypes.ClearSelection();
                labelTestRecord.Text = $"Records = {dt.Rows.Count.ToString()}";
            }
            else
            {
                MessageBox.Show(
                    "No Data Found.",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                labelTestRecord.Text = $"Records = 0";
            }
        }

        private void frmMangeTestTypesList_Load(object ?sender, EventArgs ?e)
        {
            RefreshTestTypesList();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestID = Convert.ToInt32(dataGridViewTestTypes.CurrentRow.Cells["TestTypeID"].Value);
            frmUpdateTestType frm = new frmUpdateTestType(TestID);
            frm.ShowDialog();
            frmMangeTestTypesList_Load(null, null);
        }
    }
}
