namespace DVLDPresentationLayer.Users
{
    partial class frmChangeUserPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangeUserPassword));
            userControlShowDetails1 = new DVLDPresentationLayer.Users.Controls.UserControlShowDetails();
            textBoxConfirmPassword = new TextBox();
            textBoxNewPassword = new TextBox();
            pictureBoxConfirmPassword = new PictureBox();
            PictureboxNewPassword = new PictureBox();
            PictureboxCurrentPassword = new PictureBox();
            labelComfirmPassword = new Label();
            labelNewPassword = new Label();
            labelCurrentPassword = new Label();
            textBoxCurrentPassword = new TextBox();
            buttonSave = new Button();
            buttonExit = new Button();
            errorProviderPasswordChange = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxConfirmPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureboxNewPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureboxCurrentPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderPasswordChange).BeginInit();
            SuspendLayout();
            // 
            // userControlShowDetails1
            // 
            userControlShowDetails1.Location = new Point(0, 1);
            userControlShowDetails1.Name = "userControlShowDetails1";
            userControlShowDetails1.Size = new Size(1258, 774);
            userControlShowDetails1.TabIndex = 0;
            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.Location = new Point(388, 951);
            textBoxConfirmPassword.Multiline = true;
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.Size = new Size(250, 30);
            textBoxConfirmPassword.TabIndex = 21;
            textBoxConfirmPassword.TextChanged += PasswordChange;
            // 
            // textBoxNewPassword
            // 
            textBoxNewPassword.Location = new Point(385, 878);
            textBoxNewPassword.Multiline = true;
            textBoxNewPassword.Name = "textBoxNewPassword";
            textBoxNewPassword.Size = new Size(252, 30);
            textBoxNewPassword.TabIndex = 20;
            textBoxNewPassword.TextChanged += PasswordChange;
            // 
            // pictureBoxConfirmPassword
            // 
            pictureBoxConfirmPassword.Image = (Image)resources.GetObject("pictureBoxConfirmPassword.Image");
            pictureBoxConfirmPassword.Location = new Point(332, 951);
            pictureBoxConfirmPassword.Name = "pictureBoxConfirmPassword";
            pictureBoxConfirmPassword.Size = new Size(31, 30);
            pictureBoxConfirmPassword.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxConfirmPassword.TabIndex = 19;
            pictureBoxConfirmPassword.TabStop = false;
            // 
            // PictureboxNewPassword
            // 
            PictureboxNewPassword.Image = (Image)resources.GetObject("PictureboxNewPassword.Image");
            PictureboxNewPassword.Location = new Point(332, 876);
            PictureboxNewPassword.Name = "PictureboxNewPassword";
            PictureboxNewPassword.Size = new Size(34, 32);
            PictureboxNewPassword.TabIndex = 18;
            PictureboxNewPassword.TabStop = false;
            // 
            // PictureboxCurrentPassword
            // 
            PictureboxCurrentPassword.Image = (Image)resources.GetObject("PictureboxCurrentPassword.Image");
            PictureboxCurrentPassword.Location = new Point(327, 796);
            PictureboxCurrentPassword.Name = "PictureboxCurrentPassword";
            PictureboxCurrentPassword.Size = new Size(40, 30);
            PictureboxCurrentPassword.SizeMode = PictureBoxSizeMode.Zoom;
            PictureboxCurrentPassword.TabIndex = 17;
            PictureboxCurrentPassword.TabStop = false;
            // 
            // labelComfirmPassword
            // 
            labelComfirmPassword.AutoSize = true;
            labelComfirmPassword.Font = new Font("Microsoft YaHei", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelComfirmPassword.Location = new Point(39, 948);
            labelComfirmPassword.Name = "labelComfirmPassword";
            labelComfirmPassword.Size = new Size(274, 37);
            labelComfirmPassword.TabIndex = 16;
            labelComfirmPassword.Text = "Confirm Password";
            // 
            // labelNewPassword
            // 
            labelNewPassword.AutoSize = true;
            labelNewPassword.Font = new Font("Microsoft YaHei", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNewPassword.Location = new Point(67, 871);
            labelNewPassword.Name = "labelNewPassword";
            labelNewPassword.Size = new Size(224, 37);
            labelNewPassword.TabIndex = 15;
            labelNewPassword.Text = "New Password";
            // 
            // labelCurrentPassword
            // 
            labelCurrentPassword.AutoSize = true;
            labelCurrentPassword.Font = new Font("Microsoft YaHei", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCurrentPassword.Location = new Point(43, 793);
            labelCurrentPassword.Name = "labelCurrentPassword";
            labelCurrentPassword.Size = new Size(275, 37);
            labelCurrentPassword.TabIndex = 14;
            labelCurrentPassword.Text = "Current Password ";
            // 
            // textBoxCurrentPassword
            // 
            textBoxCurrentPassword.Location = new Point(381, 796);
            textBoxCurrentPassword.Multiline = true;
            textBoxCurrentPassword.Name = "textBoxCurrentPassword";
            textBoxCurrentPassword.Size = new Size(250, 30);
            textBoxCurrentPassword.TabIndex = 13;
            textBoxCurrentPassword.TextChanged += PasswordChange;
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSave.Image = (Image)resources.GetObject("buttonSave.Image");
            buttonSave.Location = new Point(977, 851);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(111, 57);
            buttonSave.TabIndex = 22;
            buttonSave.Text = "Save";
            buttonSave.TextAlign = ContentAlignment.MiddleRight;
            buttonSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackgroundImageLayout = ImageLayout.Zoom;
            buttonExit.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonExit.Image = (Image)resources.GetObject("buttonExit.Image");
            buttonExit.Location = new Point(830, 851);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(110, 57);
            buttonExit.TabIndex = 23;
            buttonExit.Text = "Exit";
            buttonExit.TextAlign = ContentAlignment.MiddleRight;
            buttonExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // errorProviderPasswordChange
            // 
            errorProviderPasswordChange.ContainerControl = this;
            // 
            // frmChangeUserPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1226, 1052);
            Controls.Add(buttonExit);
            Controls.Add(buttonSave);
            Controls.Add(textBoxConfirmPassword);
            Controls.Add(textBoxNewPassword);
            Controls.Add(pictureBoxConfirmPassword);
            Controls.Add(PictureboxNewPassword);
            Controls.Add(PictureboxCurrentPassword);
            Controls.Add(labelComfirmPassword);
            Controls.Add(labelNewPassword);
            Controls.Add(labelCurrentPassword);
            Controls.Add(textBoxCurrentPassword);
            Controls.Add(userControlShowDetails1);
            Name = "frmChangeUserPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmChangeUserPassword";
            Load += frmChangeUserPassword_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxConfirmPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureboxNewPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureboxCurrentPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderPasswordChange).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.UserControlShowDetails userControlShowDetails1;
        private TextBox textBoxConfirmPassword;
        private TextBox textBoxNewPassword;
        private PictureBox pictureBoxConfirmPassword;
        private PictureBox PictureboxNewPassword;
        private PictureBox PictureboxCurrentPassword;
        private Label labelComfirmPassword;
        private Label labelNewPassword;
        private Label labelCurrentPassword;
        private TextBox textBoxCurrentPassword;
        private Button buttonSave;
        private Button buttonExit;
        private ErrorProvider errorProviderPasswordChange;
    }
}