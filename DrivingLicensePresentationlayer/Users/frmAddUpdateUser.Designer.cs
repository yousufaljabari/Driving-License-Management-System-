namespace DVLDPresentationLayer.People
{
    partial class frmAddUpdateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdateUser));
            tabControlAddNewUser = new TabControl();
            tabPagePersonalInfo = new TabPage();
            userControlPersonCardWithFilter1 = new DVLDPresentationLayer.People.Controls.UserControlPersonCardWithFilter();
            tabPageLoginInfo = new TabPage();
            textBoxConfirmPassword = new TextBox();
            textBoxPassword = new TextBox();
            pictureBoxConfirmPassword = new PictureBox();
            PictureboxPassword = new PictureBox();
            PictureboxUserName = new PictureBox();
            labelComfirmPassword = new Label();
            labelPassword = new Label();
            labelUserName = new Label();
            labelUserIDResult = new Label();
            checkBoxisActive = new CheckBox();
            pictureBoxPersonID = new PictureBox();
            textBoxUsername = new TextBox();
            labwlUserID = new Label();
            buttonClose = new Button();
            buttonSave = new Button();
            labelAddUpdateUser = new Label();
            errorProviderCheckPassword = new ErrorProvider(components);
            tabControlAddNewUser.SuspendLayout();
            tabPagePersonalInfo.SuspendLayout();
            tabPageLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxConfirmPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureboxPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureboxUserName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPersonID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderCheckPassword).BeginInit();
            SuspendLayout();
            // 
            // tabControlAddNewUser
            // 
            tabControlAddNewUser.Controls.Add(tabPagePersonalInfo);
            tabControlAddNewUser.Controls.Add(tabPageLoginInfo);
            tabControlAddNewUser.Location = new Point(48, 96);
            tabControlAddNewUser.Name = "tabControlAddNewUser";
            tabControlAddNewUser.SelectedIndex = 0;
            tabControlAddNewUser.Size = new Size(1324, 764);
            tabControlAddNewUser.TabIndex = 2;
            // 
            // tabPagePersonalInfo
            // 
            tabPagePersonalInfo.AllowDrop = true;
            tabPagePersonalInfo.Controls.Add(userControlPersonCardWithFilter1);
            tabPagePersonalInfo.Location = new Point(4, 29);
            tabPagePersonalInfo.Name = "tabPagePersonalInfo";
            tabPagePersonalInfo.Padding = new Padding(3);
            tabPagePersonalInfo.Size = new Size(1316, 731);
            tabPagePersonalInfo.TabIndex = 0;
            tabPagePersonalInfo.Text = "Personal Info";
            tabPagePersonalInfo.UseVisualStyleBackColor = true;
            // 
            // userControlPersonCardWithFilter1
            // 
            userControlPersonCardWithFilter1.Location = new Point(31, 0);
            userControlPersonCardWithFilter1.Name = "userControlPersonCardWithFilter1";
            userControlPersonCardWithFilter1.Size = new Size(1209, 741);
            userControlPersonCardWithFilter1.TabIndex = 0;
            userControlPersonCardWithFilter1.Load += userControlPersonCardWithFilter1_Load;
            // 
            // tabPageLoginInfo
            // 
            tabPageLoginInfo.Controls.Add(textBoxConfirmPassword);
            tabPageLoginInfo.Controls.Add(textBoxPassword);
            tabPageLoginInfo.Controls.Add(pictureBoxConfirmPassword);
            tabPageLoginInfo.Controls.Add(PictureboxPassword);
            tabPageLoginInfo.Controls.Add(PictureboxUserName);
            tabPageLoginInfo.Controls.Add(labelComfirmPassword);
            tabPageLoginInfo.Controls.Add(labelPassword);
            tabPageLoginInfo.Controls.Add(labelUserName);
            tabPageLoginInfo.Controls.Add(labelUserIDResult);
            tabPageLoginInfo.Controls.Add(checkBoxisActive);
            tabPageLoginInfo.Controls.Add(pictureBoxPersonID);
            tabPageLoginInfo.Controls.Add(textBoxUsername);
            tabPageLoginInfo.Controls.Add(labwlUserID);
            tabPageLoginInfo.Location = new Point(4, 29);
            tabPageLoginInfo.Name = "tabPageLoginInfo";
            tabPageLoginInfo.Padding = new Padding(3);
            tabPageLoginInfo.Size = new Size(1305, 703);
            tabPageLoginInfo.TabIndex = 1;
            tabPageLoginInfo.Text = "Login Info";
            tabPageLoginInfo.UseVisualStyleBackColor = true;
            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.Location = new Point(493, 453);
            textBoxConfirmPassword.Multiline = true;
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.Size = new Size(250, 30);
            textBoxConfirmPassword.TabIndex = 12;
            textBoxConfirmPassword.TextChanged += Password_TextChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(490, 380);
            textBoxPassword.Multiline = true;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(252, 30);
            textBoxPassword.TabIndex = 11;
            textBoxPassword.TextChanged += Password_TextChanged;
            // 
            // pictureBoxConfirmPassword
            // 
            pictureBoxConfirmPassword.Image = (Image)resources.GetObject("pictureBoxConfirmPassword.Image");
            pictureBoxConfirmPassword.Location = new Point(440, 453);
            pictureBoxConfirmPassword.Name = "pictureBoxConfirmPassword";
            pictureBoxConfirmPassword.Size = new Size(31, 30);
            pictureBoxConfirmPassword.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxConfirmPassword.TabIndex = 10;
            pictureBoxConfirmPassword.TabStop = false;
            // 
            // PictureboxPassword
            // 
            PictureboxPassword.Image = (Image)resources.GetObject("PictureboxPassword.Image");
            PictureboxPassword.Location = new Point(437, 378);
            PictureboxPassword.Name = "PictureboxPassword";
            PictureboxPassword.Size = new Size(34, 32);
            PictureboxPassword.TabIndex = 9;
            PictureboxPassword.TabStop = false;
            // 
            // PictureboxUserName
            // 
            PictureboxUserName.Image = (Image)resources.GetObject("PictureboxUserName.Image");
            PictureboxUserName.Location = new Point(432, 301);
            PictureboxUserName.Name = "PictureboxUserName";
            PictureboxUserName.Size = new Size(40, 30);
            PictureboxUserName.SizeMode = PictureBoxSizeMode.Zoom;
            PictureboxUserName.TabIndex = 8;
            PictureboxUserName.TabStop = false;
            // 
            // labelComfirmPassword
            // 
            labelComfirmPassword.AutoSize = true;
            labelComfirmPassword.Font = new Font("Microsoft YaHei", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelComfirmPassword.Location = new Point(144, 450);
            labelComfirmPassword.Name = "labelComfirmPassword";
            labelComfirmPassword.Size = new Size(274, 37);
            labelComfirmPassword.TabIndex = 7;
            labelComfirmPassword.Text = "Confirm Password";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Microsoft YaHei", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPassword.Location = new Point(225, 373);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(152, 37);
            labelPassword.TabIndex = 6;
            labelPassword.Text = "Password";
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Font = new Font("Microsoft YaHei", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUserName.Location = new Point(221, 297);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(159, 37);
            labelUserName.TabIndex = 5;
            labelUserName.Text = "Username";
            // 
            // labelUserIDResult
            // 
            labelUserIDResult.AutoSize = true;
            labelUserIDResult.Font = new Font("Microsoft YaHei", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUserIDResult.Location = new Point(489, 221);
            labelUserIDResult.Name = "labelUserIDResult";
            labelUserIDResult.Size = new Size(69, 37);
            labelUserIDResult.TabIndex = 4;
            labelUserIDResult.Text = "????";
            // 
            // checkBoxisActive
            // 
            checkBoxisActive.AutoSize = true;
            checkBoxisActive.Font = new Font("Segoe UI Variable Display", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxisActive.Location = new Point(493, 514);
            checkBoxisActive.Name = "checkBoxisActive";
            checkBoxisActive.Size = new Size(126, 35);
            checkBoxisActive.TabIndex = 3;
            checkBoxisActive.Text = "is Active";
            checkBoxisActive.UseVisualStyleBackColor = true;
            // 
            // pictureBoxPersonID
            // 
            pictureBoxPersonID.Image = (Image)resources.GetObject("pictureBoxPersonID.Image");
            pictureBoxPersonID.Location = new Point(433, 225);
            pictureBoxPersonID.Name = "pictureBoxPersonID";
            pictureBoxPersonID.Size = new Size(40, 30);
            pictureBoxPersonID.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPersonID.TabIndex = 2;
            pictureBoxPersonID.TabStop = false;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(486, 297);
            textBoxUsername.Multiline = true;
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(250, 30);
            textBoxUsername.TabIndex = 1;
            // 
            // labwlUserID
            // 
            labwlUserID.AutoSize = true;
            labwlUserID.Font = new Font("Microsoft YaHei", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labwlUserID.Location = new Point(239, 223);
            labwlUserID.Name = "labwlUserID";
            labwlUserID.Size = new Size(120, 37);
            labwlUserID.TabIndex = 0;
            labwlUserID.Text = "User ID";
            // 
            // buttonClose
            // 
            buttonClose.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonClose.Image = (Image)resources.GetObject("buttonClose.Image");
            buttonClose.ImageAlign = ContentAlignment.MiddleLeft;
            buttonClose.Location = new Point(1060, 866);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(132, 57);
            buttonClose.TabIndex = 4;
            buttonClose.Text = "CLose";
            buttonClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSave.Image = (Image)resources.GetObject("buttonSave.Image");
            buttonSave.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSave.Location = new Point(1216, 862);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(139, 64);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Save";
            buttonSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // labelAddUpdateUser
            // 
            labelAddUpdateUser.AutoSize = true;
            labelAddUpdateUser.Font = new Font("Microsoft New Tai Lue", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAddUpdateUser.ForeColor = Color.IndianRed;
            labelAddUpdateUser.Location = new Point(497, 37);
            labelAddUpdateUser.Name = "labelAddUpdateUser";
            labelAddUpdateUser.Size = new Size(86, 49);
            labelAddUpdateUser.TabIndex = 3;
            labelAddUpdateUser.Text = "????";
            labelAddUpdateUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // errorProviderCheckPassword
            // 
            errorProviderCheckPassword.ContainerControl = this;
            // 
            // frmAddUpdateUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1399, 935);
            Controls.Add(buttonClose);
            Controls.Add(labelAddUpdateUser);
            Controls.Add(buttonSave);
            Controls.Add(tabControlAddNewUser);
            Name = "frmAddUpdateUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddUpdateUser";
            Load += frmAddUpdateUser_Load;
            tabControlAddNewUser.ResumeLayout(false);
            tabPagePersonalInfo.ResumeLayout(false);
            tabPageLoginInfo.ResumeLayout(false);
            tabPageLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxConfirmPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureboxPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureboxUserName).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPersonID).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderCheckPassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControlAddNewUser;
        private TabPage tabPagePersonalInfo;
        private Controls.UserControlPersonCardWithFilter userControlPersonCardWithFilter1;
        private TabPage tabPageLoginInfo;
        private Button buttonSave;
        private Button buttonClose;
        private Label labelAddUpdateUser;
        private CheckBox checkBoxisActive;
        private PictureBox pictureBoxPersonID;
        private TextBox textBoxUsername;
        private Label labwlUserID;
        private Label labelComfirmPassword;
        private Label labelPassword;
        private Label labelUserName;
        private Label labelUserIDResult;
        private PictureBox PictureboxUserName;
        private TextBox textBoxConfirmPassword;
        private TextBox textBoxPassword;
        private PictureBox pictureBoxConfirmPassword;
        private PictureBox PictureboxPassword;
        private ErrorProvider errorProviderCheckPassword;
    }
}