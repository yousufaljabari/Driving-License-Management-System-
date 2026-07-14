namespace DVLDPresentationLayer.Applications
{
    partial class frmLocalDrivingLicenseApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocalDrivingLicenseApplication));
            label1 = new Label();
            buttonSave = new Button();
            buttonClose = new Button();
            tabControlLocalLicenseApplication = new TabControl();
            tabPagePersonalInfo = new TabPage();
            userControlPersonCardWithFilter1 = new DVLDPresentationLayer.People.Controls.UserControlPersonCardWithFilter();
            tabPageApplicationInfo = new TabPage();
            labelUser = new Label();
            labelAppFeesResult = new Label();
            comboBoxLicenseClass = new ComboBox();
            labelAppDateResult = new Label();
            labelAppIDResult = new Label();
            labelCreatedBy = new Label();
            labelApplicationFees = new Label();
            labelLicenseClass = new Label();
            labelApplicationDate = new Label();
            labelDLApplicationID = new Label();
            tabControlLocalLicenseApplication.SuspendLayout();
            tabPagePersonalInfo.SuspendLayout();
            tabPageApplicationInfo.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft New Tai Lue", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(302, -86);
            label1.Name = "label1";
            label1.Size = new Size(699, 49);
            label1.TabIndex = 1;
            label1.Text = " New Local Driving License Application";
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSave.Image = (Image)resources.GetObject("buttonSave.Image");
            buttonSave.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSave.Location = new Point(1077, 855);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(129, 54);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Save";
            buttonSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonClose
            // 
            buttonClose.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonClose.Image = (Image)resources.GetObject("buttonClose.Image");
            buttonClose.ImageAlign = ContentAlignment.MiddleLeft;
            buttonClose.Location = new Point(919, 855);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(138, 54);
            buttonClose.TabIndex = 5;
            buttonClose.Text = "CLose";
            buttonClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // tabControlLocalLicenseApplication
            // 
            tabControlLocalLicenseApplication.Controls.Add(tabPagePersonalInfo);
            tabControlLocalLicenseApplication.Controls.Add(tabPageApplicationInfo);
            tabControlLocalLicenseApplication.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControlLocalLicenseApplication.Location = new Point(-4, 73);
            tabControlLocalLicenseApplication.Name = "tabControlLocalLicenseApplication";
            tabControlLocalLicenseApplication.SelectedIndex = 0;
            tabControlLocalLicenseApplication.Size = new Size(1244, 776);
            tabControlLocalLicenseApplication.TabIndex = 6;
            tabControlLocalLicenseApplication.SelectedIndexChanged += tabControlLocalLicenseApplication_SelectedIndexChanged;
            // 
            // tabPagePersonalInfo
            // 
            tabPagePersonalInfo.Controls.Add(userControlPersonCardWithFilter1);
            tabPagePersonalInfo.Controls.Add(label1);
            tabPagePersonalInfo.Location = new Point(4, 34);
            tabPagePersonalInfo.Name = "tabPagePersonalInfo";
            tabPagePersonalInfo.Padding = new Padding(3);
            tabPagePersonalInfo.Size = new Size(1236, 738);
            tabPagePersonalInfo.TabIndex = 0;
            tabPagePersonalInfo.Text = "Personal Info";
            tabPagePersonalInfo.UseVisualStyleBackColor = true;
            // 
            // userControlPersonCardWithFilter1
            // 
            userControlPersonCardWithFilter1.Location = new Point(-1, -7);
            userControlPersonCardWithFilter1.Name = "userControlPersonCardWithFilter1";
            userControlPersonCardWithFilter1.Size = new Size(1227, 749);
            userControlPersonCardWithFilter1.TabIndex = 0;
            // 
            // tabPageApplicationInfo
            // 
            tabPageApplicationInfo.Controls.Add(labelUser);
            tabPageApplicationInfo.Controls.Add(labelAppFeesResult);
            tabPageApplicationInfo.Controls.Add(comboBoxLicenseClass);
            tabPageApplicationInfo.Controls.Add(labelAppDateResult);
            tabPageApplicationInfo.Controls.Add(labelAppIDResult);
            tabPageApplicationInfo.Controls.Add(labelCreatedBy);
            tabPageApplicationInfo.Controls.Add(labelApplicationFees);
            tabPageApplicationInfo.Controls.Add(labelLicenseClass);
            tabPageApplicationInfo.Controls.Add(labelApplicationDate);
            tabPageApplicationInfo.Controls.Add(labelDLApplicationID);
            tabPageApplicationInfo.Location = new Point(4, 34);
            tabPageApplicationInfo.Name = "tabPageApplicationInfo";
            tabPageApplicationInfo.Padding = new Padding(3);
            tabPageApplicationInfo.Size = new Size(192, 62);
            tabPageApplicationInfo.TabIndex = 1;
            tabPageApplicationInfo.Text = "Application Info";
            tabPageApplicationInfo.UseVisualStyleBackColor = true;
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUser.Location = new Point(533, 495);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(65, 38);
            labelUser.TabIndex = 9;
            labelUser.Text = "????";
            // 
            // labelAppFeesResult
            // 
            labelAppFeesResult.AutoSize = true;
            labelAppFeesResult.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAppFeesResult.Location = new Point(533, 416);
            labelAppFeesResult.Name = "labelAppFeesResult";
            labelAppFeesResult.Size = new Size(65, 38);
            labelAppFeesResult.TabIndex = 8;
            labelAppFeesResult.Text = "????";
            // 
            // comboBoxLicenseClass
            // 
            comboBoxLicenseClass.BackColor = SystemColors.Window;
            comboBoxLicenseClass.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLicenseClass.FormattingEnabled = true;
            comboBoxLicenseClass.Location = new Point(449, 340);
            comboBoxLicenseClass.Name = "comboBoxLicenseClass";
            comboBoxLicenseClass.Size = new Size(294, 33);
            comboBoxLicenseClass.TabIndex = 7;
            // 
            // labelAppDateResult
            // 
            labelAppDateResult.AutoSize = true;
            labelAppDateResult.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAppDateResult.Location = new Point(524, 253);
            labelAppDateResult.Name = "labelAppDateResult";
            labelAppDateResult.Size = new Size(65, 38);
            labelAppDateResult.TabIndex = 6;
            labelAppDateResult.Text = "????";
            // 
            // labelAppIDResult
            // 
            labelAppIDResult.AutoSize = true;
            labelAppIDResult.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAppIDResult.Location = new Point(523, 170);
            labelAppIDResult.Name = "labelAppIDResult";
            labelAppIDResult.Size = new Size(85, 38);
            labelAppIDResult.TabIndex = 5;
            labelAppIDResult.Text = "[????]";
            // 
            // labelCreatedBy
            // 
            labelCreatedBy.AutoSize = true;
            labelCreatedBy.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCreatedBy.Location = new Point(213, 495);
            labelCreatedBy.Name = "labelCreatedBy";
            labelCreatedBy.Size = new Size(159, 38);
            labelCreatedBy.TabIndex = 4;
            labelCreatedBy.Text = "Created By";
            // 
            // labelApplicationFees
            // 
            labelApplicationFees.AutoSize = true;
            labelApplicationFees.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelApplicationFees.Location = new Point(213, 416);
            labelApplicationFees.Name = "labelApplicationFees";
            labelApplicationFees.Size = new Size(233, 38);
            labelApplicationFees.TabIndex = 3;
            labelApplicationFees.Text = "Application Fees";
            // 
            // labelLicenseClass
            // 
            labelLicenseClass.AutoSize = true;
            labelLicenseClass.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLicenseClass.Location = new Point(213, 336);
            labelLicenseClass.Name = "labelLicenseClass";
            labelLicenseClass.Size = new Size(191, 38);
            labelLicenseClass.TabIndex = 2;
            labelLicenseClass.Text = "License Class ";
            // 
            // labelApplicationDate
            // 
            labelApplicationDate.AutoSize = true;
            labelApplicationDate.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelApplicationDate.ImageAlign = ContentAlignment.BottomRight;
            labelApplicationDate.Location = new Point(210, 254);
            labelApplicationDate.Name = "labelApplicationDate";
            labelApplicationDate.Size = new Size(238, 38);
            labelApplicationDate.TabIndex = 1;
            labelApplicationDate.Text = "Application Date";
            // 
            // labelDLApplicationID
            // 
            labelDLApplicationID.AutoSize = true;
            labelDLApplicationID.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDLApplicationID.Location = new Point(211, 171);
            labelDLApplicationID.Name = "labelDLApplicationID";
            labelDLApplicationID.Size = new Size(264, 38);
            labelDLApplicationID.TabIndex = 0;
            labelDLApplicationID.Text = "D.L.Application ID ";
            // 
            // frmLocalDrivingLicenseApplication
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1252, 928);
            Controls.Add(tabControlLocalLicenseApplication);
            Controls.Add(buttonClose);
            Controls.Add(buttonSave);
            Name = "frmLocalDrivingLicenseApplication";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAddLocalDrivingLicense";
            Load += frmLocalDrivingLicenseApplication_Load;
            tabControlLocalLicenseApplication.ResumeLayout(false);
            tabPagePersonalInfo.ResumeLayout(false);
            tabPagePersonalInfo.PerformLayout();
            tabPageApplicationInfo.ResumeLayout(false);
            tabPageApplicationInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Button buttonSave;
        private Button buttonClose;
        private TabControl tabControlLocalLicenseApplication;
        private TabPage tabPagePersonalInfo;
        private TabPage tabPageApplicationInfo;
        private People.Controls.UserControlPersonCardWithFilter userControlPersonCardWithFilter1;
        private Label labelDLApplicationID;
        private Label labelCreatedBy;
        private Label labelApplicationFees;
        private Label labelLicenseClass;
        private Label labelApplicationDate;
        private Label labelAppDateResult;
        private Label labelAppIDResult;
        private Label labelUser;
        private Label labelAppFeesResult;
        private ComboBox comboBoxLicenseClass;
    }
}