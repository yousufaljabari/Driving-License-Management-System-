namespace DVLDPresentationLayer.Applications
{
    partial class frmlocalLicenseApplication
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlocalLicenseApplication));
            pictureBoxLocalDrivingLicenseApplications = new PictureBox();
            labelLocalDrivingLicenseApplications = new Label();
            labellocalApplicationRecord = new Label();
            labelFindBy = new Label();
            buttonAddNewApplication = new Button();
            textBoxFilterBy = new TextBox();
            dataGridViewlocalDrivinglicenseApplication = new DataGridView();
            comboBoxLocalLicenseFilterBy = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLocalDrivingLicenseApplications).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewlocalDrivinglicenseApplication).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLocalDrivingLicenseApplications
            // 
            pictureBoxLocalDrivingLicenseApplications.Image = (Image)resources.GetObject("pictureBoxLocalDrivingLicenseApplications.Image");
            pictureBoxLocalDrivingLicenseApplications.Location = new Point(472, 7);
            pictureBoxLocalDrivingLicenseApplications.Name = "pictureBoxLocalDrivingLicenseApplications";
            pictureBoxLocalDrivingLicenseApplications.Size = new Size(242, 194);
            pictureBoxLocalDrivingLicenseApplications.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLocalDrivingLicenseApplications.TabIndex = 0;
            pictureBoxLocalDrivingLicenseApplications.TabStop = false;
            // 
            // labelLocalDrivingLicenseApplications
            // 
            labelLocalDrivingLicenseApplications.AutoSize = true;
            labelLocalDrivingLicenseApplications.Font = new Font("Microsoft New Tai Lue", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLocalDrivingLicenseApplications.ForeColor = Color.IndianRed;
            labelLocalDrivingLicenseApplications.Location = new Point(352, 222);
            labelLocalDrivingLicenseApplications.Name = "labelLocalDrivingLicenseApplications";
            labelLocalDrivingLicenseApplications.Size = new Size(496, 40);
            labelLocalDrivingLicenseApplications.TabIndex = 1;
            labelLocalDrivingLicenseApplications.Text = "Local Driving License Applications";
            // 
            // labellocalApplicationRecord
            // 
            labellocalApplicationRecord.AutoSize = true;
            labellocalApplicationRecord.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labellocalApplicationRecord.Location = new Point(41, 749);
            labellocalApplicationRecord.Name = "labellocalApplicationRecord";
            labellocalApplicationRecord.Size = new Size(62, 25);
            labellocalApplicationRecord.TabIndex = 2;
            labellocalApplicationRecord.Text = "?????";
            // 
            // labelFindBy
            // 
            labelFindBy.AutoSize = true;
            labelFindBy.Font = new Font("Microsoft JhengHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFindBy.Location = new Point(21, 291);
            labelFindBy.Name = "labelFindBy";
            labelFindBy.Size = new Size(75, 23);
            labelFindBy.TabIndex = 3;
            labelFindBy.Text = "Find By";
            // 
            // buttonAddNewApplication
            // 
            buttonAddNewApplication.Image = (Image)resources.GetObject("buttonAddNewApplication.Image");
            buttonAddNewApplication.Location = new Point(1124, 249);
            buttonAddNewApplication.Name = "buttonAddNewApplication";
            buttonAddNewApplication.Size = new Size(85, 73);
            buttonAddNewApplication.TabIndex = 4;
            buttonAddNewApplication.UseVisualStyleBackColor = true;
            buttonAddNewApplication.Click += buttonAddNewApplication_Click;
            // 
            // textBoxFilterBy
            // 
            textBoxFilterBy.Location = new Point(280, 292);
            textBoxFilterBy.Name = "textBoxFilterBy";
            textBoxFilterBy.Size = new Size(191, 27);
            textBoxFilterBy.TabIndex = 6;
            textBoxFilterBy.TextChanged += textBoxFilterBy_TextChanged;
            // 
            // dataGridViewlocalDrivinglicenseApplication
            // 
            dataGridViewlocalDrivinglicenseApplication.AllowUserToAddRows = false;
            dataGridViewlocalDrivinglicenseApplication.AllowUserToDeleteRows = false;
            dataGridViewlocalDrivinglicenseApplication.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewlocalDrivinglicenseApplication.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewlocalDrivinglicenseApplication.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewlocalDrivinglicenseApplication.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewlocalDrivinglicenseApplication.Location = new Point(-3, 336);
            dataGridViewlocalDrivinglicenseApplication.Name = "dataGridViewlocalDrivinglicenseApplication";
            dataGridViewlocalDrivinglicenseApplication.ReadOnly = true;
            dataGridViewlocalDrivinglicenseApplication.RowHeadersWidth = 51;
            dataGridViewlocalDrivinglicenseApplication.Size = new Size(1225, 378);
            dataGridViewlocalDrivinglicenseApplication.TabIndex = 7;
            // 
            // comboBoxLocalLicenseFilterBy
            // 
            comboBoxLocalLicenseFilterBy.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLocalLicenseFilterBy.Font = new Font("Microsoft JhengHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxLocalLicenseFilterBy.FormattingEnabled = true;
            comboBoxLocalLicenseFilterBy.Items.AddRange(new object[] { "None", "L.D.L AppID", "National NO ", "Full Name", "Status " });
            comboBoxLocalLicenseFilterBy.Location = new Point(111, 290);
            comboBoxLocalLicenseFilterBy.Name = "comboBoxLocalLicenseFilterBy";
            comboBoxLocalLicenseFilterBy.Size = new Size(151, 31);
            comboBoxLocalLicenseFilterBy.TabIndex = 8;
            comboBoxLocalLicenseFilterBy.SelectedIndexChanged += comboBoxLocalLicenseFilterBy_SelectedIndexChanged;
            // 
            // frmlocalLicenseApplication
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1224, 804);
            Controls.Add(comboBoxLocalLicenseFilterBy);
            Controls.Add(dataGridViewlocalDrivinglicenseApplication);
            Controls.Add(textBoxFilterBy);
            Controls.Add(buttonAddNewApplication);
            Controls.Add(labelFindBy);
            Controls.Add(labellocalApplicationRecord);
            Controls.Add(labelLocalDrivingLicenseApplications);
            Controls.Add(pictureBoxLocalDrivingLicenseApplications);
            Name = "frmlocalLicenseApplication";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmlocalLicenseApplication";
            Load += frmlocalLicenseApplication_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLocalDrivingLicenseApplications).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewlocalDrivinglicenseApplication).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxLocalDrivingLicenseApplications;
        private Label labelLocalDrivingLicenseApplications;
        private Label labellocalApplicationRecord;
        private Label labelFindBy;
        private Button buttonAddNewApplication;
        private TextBox textBoxFilterBy;
        private DataGridView dataGridViewlocalDrivinglicenseApplication;
        private ComboBox comboBoxLocalLicenseFilterBy;
    }
}