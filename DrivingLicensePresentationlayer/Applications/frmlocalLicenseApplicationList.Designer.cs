namespace DVLDPresentationLayer.Applications
{
    partial class frmlocalLicenseApplicationList
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlocalLicenseApplicationList));
            pictureBoxLocalDrivingLicenseApplications = new PictureBox();
            labelLocalDrivingLicenseApplications = new Label();
            labellocalApplicationRecord = new Label();
            labelFindBy = new Label();
            buttonAddNewApplication = new Button();
            textBoxFilterBy = new TextBox();
            dataGridViewlocalDrivinglicenseApplication = new DataGridView();
            contextMenuStripLocalLicenseApplicationList = new ContextMenuStrip(components);
            toolStripShowApplicationDetails = new ToolStripMenuItem();
            toolStripEditApplication = new ToolStripMenuItem();
            toolStripDeleteApplication = new ToolStripMenuItem();
            toolStripCancelApplication = new ToolStripMenuItem();
            comboBoxLocalLicenseFilterBy = new ComboBox();
            toolStripSeperator = new ToolStripSeparator();
            toolStripSeperatior = new ToolStripSeparator();
            toolStripMenuItem1 = new ToolStripSeparator();
            ScheduleTestsToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            issueDrivingLicenseFirstTimeToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            showLicenseToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripSeparator();
            showPersonLicenseHisotryToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLocalDrivingLicenseApplications).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewlocalDrivinglicenseApplication).BeginInit();
            contextMenuStripLocalLicenseApplicationList.SuspendLayout();
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
            dataGridViewlocalDrivinglicenseApplication.ContextMenuStrip = contextMenuStripLocalLicenseApplicationList;
            dataGridViewlocalDrivinglicenseApplication.Location = new Point(-3, 336);
            dataGridViewlocalDrivinglicenseApplication.Name = "dataGridViewlocalDrivinglicenseApplication";
            dataGridViewlocalDrivinglicenseApplication.ReadOnly = true;
            dataGridViewlocalDrivinglicenseApplication.RowHeadersWidth = 51;
            dataGridViewlocalDrivinglicenseApplication.Size = new Size(1225, 378);
            dataGridViewlocalDrivinglicenseApplication.TabIndex = 7;
            // 
            // contextMenuStripLocalLicenseApplicationList
            // 
            contextMenuStripLocalLicenseApplicationList.ImageScalingSize = new Size(20, 20);
            contextMenuStripLocalLicenseApplicationList.Items.AddRange(new ToolStripItem[] { toolStripShowApplicationDetails, toolStripSeperator, toolStripEditApplication, toolStripDeleteApplication, toolStripSeperatior, toolStripCancelApplication, toolStripMenuItem1, ScheduleTestsToolStripMenuItem, toolStripMenuItem2, issueDrivingLicenseFirstTimeToolStripMenuItem, toolStripMenuItem3, showLicenseToolStripMenuItem, toolStripMenuItem4, showPersonLicenseHisotryToolStripMenuItem });
            contextMenuStripLocalLicenseApplicationList.Name = "contextMenuStripLocalLicenseApplicationList";
            contextMenuStripLocalLicenseApplicationList.Size = new Size(365, 308);
            // 
            // toolStripShowApplicationDetails
            // 
            toolStripShowApplicationDetails.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripShowApplicationDetails.Image = Properties.Resources.application;
            toolStripShowApplicationDetails.Name = "toolStripShowApplicationDetails";
            toolStripShowApplicationDetails.Size = new Size(364, 30);
            toolStripShowApplicationDetails.Text = "Sbow Application Details";
            // 
            // toolStripEditApplication
            // 
            toolStripEditApplication.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripEditApplication.Image = Properties.Resources.ApplicationEdit;
            toolStripEditApplication.Name = "toolStripEditApplication";
            toolStripEditApplication.Size = new Size(364, 30);
            toolStripEditApplication.Text = "Edit Application";
            // 
            // toolStripDeleteApplication
            // 
            toolStripDeleteApplication.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripDeleteApplication.Image = Properties.Resources.Deleteapp;
            toolStripDeleteApplication.Name = "toolStripDeleteApplication";
            toolStripDeleteApplication.Size = new Size(364, 30);
            toolStripDeleteApplication.Text = "Delete Application";
            // 
            // toolStripCancelApplication
            // 
            toolStripCancelApplication.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripCancelApplication.Image = Properties.Resources.cancelapplication__1_;
            toolStripCancelApplication.Name = "toolStripCancelApplication";
            toolStripCancelApplication.Size = new Size(364, 30);
            toolStripCancelApplication.Text = "Cancel Application";
            toolStripCancelApplication.Click += toolStripCancelApplication_Click;
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
            // toolStripSeperator
            // 
            toolStripSeperator.Name = "toolStripSeperator";
            toolStripSeperator.Size = new Size(357, 6);
            // 
            // toolStripSeperatior
            // 
            toolStripSeperatior.Name = "toolStripSeperatior";
            toolStripSeperatior.Size = new Size(357, 6);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(357, 6);
            // 
            // ScheduleTestsToolStripMenuItem
            // 
            ScheduleTestsToolStripMenuItem.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ScheduleTestsToolStripMenuItem.Image = Properties.Resources.Schdule;
            ScheduleTestsToolStripMenuItem.Name = "ScheduleTestsToolStripMenuItem";
            ScheduleTestsToolStripMenuItem.Size = new Size(364, 30);
            ScheduleTestsToolStripMenuItem.Text = "Schedule Test";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(357, 6);
            // 
            // issueDrivingLicenseFirstTimeToolStripMenuItem
            // 
            issueDrivingLicenseFirstTimeToolStripMenuItem.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            issueDrivingLicenseFirstTimeToolStripMenuItem.Image = Properties.Resources.icons8_software_license_96;
            issueDrivingLicenseFirstTimeToolStripMenuItem.Name = "issueDrivingLicenseFirstTimeToolStripMenuItem";
            issueDrivingLicenseFirstTimeToolStripMenuItem.Size = new Size(364, 30);
            issueDrivingLicenseFirstTimeToolStripMenuItem.Text = "Issue Driving License (First Time)";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(357, 6);
            // 
            // showLicenseToolStripMenuItem
            // 
            showLicenseToolStripMenuItem.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showLicenseToolStripMenuItem.Image = Properties.Resources.icons8_driver_license_96;
            showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            showLicenseToolStripMenuItem.Size = new Size(364, 30);
            showLicenseToolStripMenuItem.Text = "Show License";
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(357, 6);
            // 
            // showPersonLicenseHisotryToolStripMenuItem
            // 
            showPersonLicenseHisotryToolStripMenuItem.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showPersonLicenseHisotryToolStripMenuItem.Image = Properties.Resources.icons8_activity_history_100;
            showPersonLicenseHisotryToolStripMenuItem.Name = "showPersonLicenseHisotryToolStripMenuItem";
            showPersonLicenseHisotryToolStripMenuItem.Size = new Size(364, 30);
            showPersonLicenseHisotryToolStripMenuItem.Text = "Show Person License Hisotry";
            // 
            // frmlocalLicenseApplicationList
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
            Name = "frmlocalLicenseApplicationList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmlocalLicenseApplication";
            Load += frmlocalLicenseApplication_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLocalDrivingLicenseApplications).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewlocalDrivinglicenseApplication).EndInit();
            contextMenuStripLocalLicenseApplicationList.ResumeLayout(false);
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
        private ContextMenuStrip contextMenuStripLocalLicenseApplicationList;
        private ToolStripMenuItem toolStripShowApplicationDetails;
        private ToolStripMenuItem toolStripEditApplication;
        private ToolStripMenuItem toolStripDeleteApplication;
        private ToolStripMenuItem toolStripCancelApplication;
        private ToolStripSeparator toolStripSeperator;
        private ToolStripSeparator toolStripSeperatior;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem ScheduleTestsToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem issueDrivingLicenseFirstTimeToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem showLicenseToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripMenuItem showPersonLicenseHisotryToolStripMenuItem;
    }
}