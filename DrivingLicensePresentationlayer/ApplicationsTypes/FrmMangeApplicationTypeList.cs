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
using DVLDPresentationLayer.Applications;

namespace DVLDPresentationLayer
{
    public partial class FrmMangeApplicationTypeList : Form
    {
        public FrmMangeApplicationTypeList()
        {
            InitializeComponent();

        }

        private void FrmApplicationTypes_Load(object? sender, EventArgs? e)
        {
            RefreshApplicationTypes();

        }
        private void RefreshApplicationTypes()
        {
            DataTable dt = clsApplicationType.GetAllApplicationTypes();
            if (dt != null)
            {
                dataGridViewApplicationTypes.DataSource = dt;
                dataGridViewApplicationTypes.ClearSelection();
                labelApplictionRecord.Text = $"Records = {dt.Rows.Count.ToString()}";
            }
            else
            {
                MessageBox.Show(
                    "No Data Found.",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                labelApplictionRecord.Text = $"Records = 0";
            }
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ApplicationTypeID = Convert.ToInt32(dataGridViewApplicationTypes.CurrentRow.Cells["ApplicationTypeID"].Value);
            frmUpdateApplicationType frm = new frmUpdateApplicationType(ApplicationTypeID);
            frm.ShowDialog();
            FrmApplicationTypes_Load(sender: null, null);



        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
