namespace DVLDPresentationLayer.MainScreens
{
    partial class frmUserLoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserLoginScreen));
            panel1 = new Panel();
            labelLoginMessage = new Label();
            pictBoxUserlogin = new PictureBox();
            labelloginToYourAccount = new Label();
            labeluserName = new Label();
            labelPassword = new Label();
            pictureBoxUserName = new PictureBox();
            pictureBoxPassword = new PictureBox();
            textBoxUserName = new TextBox();
            textBoxPassword = new TextBox();
            checkboxRememberme = new CheckBox();
            buttonLogin = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictBoxUserlogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUserName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPassword).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(labelLoginMessage);
            panel1.Controls.Add(pictBoxUserlogin);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(771, 778);
            panel1.TabIndex = 0;
            // 
            // labelLoginMessage
            // 
            labelLoginMessage.Font = new Font("Microsoft YaHei", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLoginMessage.ForeColor = SystemColors.ButtonHighlight;
            labelLoginMessage.Location = new Point(-22, 461);
            labelLoginMessage.Name = "labelLoginMessage";
            labelLoginMessage.Size = new Size(815, 186);
            labelLoginMessage.TabIndex = 1;
            labelLoginMessage.Text = "WELCOME TO DVLD System\r\n (DRIVING & VEHICLE LICENSE DEPARTMENT SYSTEM )\r\n";
            labelLoginMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictBoxUserlogin
            // 
            pictBoxUserlogin.BackgroundImageLayout = ImageLayout.Zoom;
            pictBoxUserlogin.Image = (Image)resources.GetObject("pictBoxUserlogin.Image");
            pictBoxUserlogin.Location = new Point(7, 102);
            pictBoxUserlogin.Name = "pictBoxUserlogin";
            pictBoxUserlogin.Size = new Size(757, 356);
            pictBoxUserlogin.SizeMode = PictureBoxSizeMode.Zoom;
            pictBoxUserlogin.TabIndex = 0;
            pictBoxUserlogin.TabStop = false;
            // 
            // labelloginToYourAccount
            // 
            labelloginToYourAccount.AutoSize = true;
            labelloginToYourAccount.Font = new Font("Microsoft YaHei", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelloginToYourAccount.Location = new Point(892, 184);
            labelloginToYourAccount.Name = "labelloginToYourAccount";
            labelloginToYourAccount.Size = new Size(270, 31);
            labelloginToYourAccount.TabIndex = 1;
            labelloginToYourAccount.Text = "Login to your account";
            // 
            // labeluserName
            // 
            labeluserName.AutoSize = true;
            labeluserName.Font = new Font("Microsoft YaHei", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labeluserName.Location = new Point(799, 302);
            labeluserName.Name = "labeluserName";
            labeluserName.Size = new Size(130, 31);
            labeluserName.TabIndex = 2;
            labeluserName.Text = "Username";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Microsoft YaHei", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPassword.Location = new Point(802, 371);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(124, 31);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Password";
            // 
            // pictureBoxUserName
            // 
            pictureBoxUserName.Image = (Image)resources.GetObject("pictureBoxUserName.Image");
            pictureBoxUserName.Location = new Point(936, 303);
            pictureBoxUserName.Name = "pictureBoxUserName";
            pictureBoxUserName.Size = new Size(41, 31);
            pictureBoxUserName.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxUserName.TabIndex = 2;
            pictureBoxUserName.TabStop = false;
            // 
            // pictureBoxPassword
            // 
            pictureBoxPassword.Image = (Image)resources.GetObject("pictureBoxPassword.Image");
            pictureBoxPassword.Location = new Point(936, 371);
            pictureBoxPassword.Name = "pictureBoxPassword";
            pictureBoxPassword.Size = new Size(41, 31);
            pictureBoxPassword.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPassword.TabIndex = 4;
            pictureBoxPassword.TabStop = false;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(997, 306);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(256, 27);
            textBoxUserName.TabIndex = 5;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(997, 372);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(256, 27);
            textBoxPassword.TabIndex = 6;
            // 
            // checkboxRememberme
            // 
            checkboxRememberme.AutoSize = true;
            checkboxRememberme.Location = new Point(998, 422);
            checkboxRememberme.Name = "checkboxRememberme";
            checkboxRememberme.Size = new Size(133, 24);
            checkboxRememberme.TabIndex = 2;
            checkboxRememberme.Text = "Remember me ";
            checkboxRememberme.UseVisualStyleBackColor = true;
            // 
            // buttonLogin
            // 
            buttonLogin.Image = (Image)resources.GetObject("buttonLogin.Image");
            buttonLogin.ImageAlign = ContentAlignment.MiddleLeft;
            buttonLogin.Location = new Point(997, 485);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(106, 48);
            buttonLogin.TabIndex = 7;
            buttonLogin.Text = "Login";
            buttonLogin.TextAlign = ContentAlignment.MiddleRight;
            buttonLogin.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // frmUserLoginScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1268, 776);
            Controls.Add(buttonLogin);
            Controls.Add(checkboxRememberme);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUserName);
            Controls.Add(pictureBoxPassword);
            Controls.Add(labelPassword);
            Controls.Add(pictureBoxUserName);
            Controls.Add(labeluserName);
            Controls.Add(labelloginToYourAccount);
            Controls.Add(panel1);
            Name = "frmUserLoginScreen";
            Text = "UserLoginScreen";
            Load += UserLoginScreen_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictBoxUserlogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUserName).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label labelLoginMessage;
        private PictureBox pictBoxUserlogin;
        private Label labelloginToYourAccount;
        private Label labeluserName;
        private PictureBox pictureBox2;
        private Label labelPassword;
        private PictureBox pictureBoxUserName;
        private PictureBox pictureBoxPassword;
        private TextBox textBoxUserName;
        private TextBox textBoxPassword;
        private CheckBox checkboxRememberme;
        private Button buttonLogin;
    }
}