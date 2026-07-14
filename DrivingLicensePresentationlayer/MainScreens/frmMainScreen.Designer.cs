namespace DrivingLicenseMangement
{
    partial class frmMainScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainScreen));
            MenustrDVDL = new MenuStrip();
            applicationsToolStripMenuItem = new ToolStripMenuItem();
            drivingLicensesServicesToolStripMenuItem = new ToolStripMenuItem();
            newDrivingLicenseToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            mangeApplicationToolStripMenuItem = new ToolStripMenuItem();
            localDrivingLicenseApplicationToolStripMenuItem = new ToolStripMenuItem();
            internationalLicenseApplicationToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripSeparator();
            ToolStripMenuItemmangeApplicationTypes = new ToolStripMenuItem();
            mangeToolStripMenuItemSeprate = new ToolStripSeparator();
            ToolStripMenuItemTestTypes = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            peopleToolStripMenuItem = new ToolStripMenuItem();
            driversToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            accountSettToolStripMenuItem = new ToolStripMenuItem();
            currentUserToolStripMenuItem = new ToolStripMenuItem();
            ToolStripchangePassword = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            signOutToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            localLicenseToolStripMenuItem = new ToolStripMenuItem();
            internationalLicenseToolStripMenuItem = new ToolStripMenuItem();
            MenustrDVDL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // MenustrDVDL
            // 
            MenustrDVDL.AutoSize = false;
            MenustrDVDL.ImageScalingSize = new Size(40, 40);
            MenustrDVDL.Items.AddRange(new ToolStripItem[] { applicationsToolStripMenuItem, peopleToolStripMenuItem, driversToolStripMenuItem, usersToolStripMenuItem, accountSettToolStripMenuItem });
            MenustrDVDL.Location = new Point(0, 0);
            MenustrDVDL.Name = "MenustrDVDL";
            MenustrDVDL.Size = new Size(1672, 72);
            MenustrDVDL.TabIndex = 0;
            // 
            // applicationsToolStripMenuItem
            // 
            applicationsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { drivingLicensesServicesToolStripMenuItem, toolStripMenuItem2, mangeApplicationToolStripMenuItem, toolStripMenuItem4, ToolStripMenuItemmangeApplicationTypes, mangeToolStripMenuItemSeprate, ToolStripMenuItemTestTypes, toolStripMenuItem3 });
            applicationsToolStripMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            applicationsToolStripMenuItem.Image = (Image)resources.GetObject("applicationsToolStripMenuItem.Image");
            applicationsToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            applicationsToolStripMenuItem.Name = "applicationsToolStripMenuItem";
            applicationsToolStripMenuItem.Size = new Size(164, 68);
            applicationsToolStripMenuItem.Text = "Applications";
            // 
            // drivingLicensesServicesToolStripMenuItem
            // 
            drivingLicensesServicesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newDrivingLicenseToolStripMenuItem });
            drivingLicensesServicesToolStripMenuItem.Image = (Image)resources.GetObject("drivingLicensesServicesToolStripMenuItem.Image");
            drivingLicensesServicesToolStripMenuItem.Name = "drivingLicensesServicesToolStripMenuItem";
            drivingLicensesServicesToolStripMenuItem.Size = new Size(313, 46);
            drivingLicensesServicesToolStripMenuItem.Text = "Driving Licenses Services";
            // 
            // newDrivingLicenseToolStripMenuItem
            // 
            newDrivingLicenseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { localLicenseToolStripMenuItem, internationalLicenseToolStripMenuItem });
            newDrivingLicenseToolStripMenuItem.Font = new Font("Segoe UI Symbol", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newDrivingLicenseToolStripMenuItem.Image = (Image)resources.GetObject("newDrivingLicenseToolStripMenuItem.Image");
            newDrivingLicenseToolStripMenuItem.Name = "newDrivingLicenseToolStripMenuItem";
            newDrivingLicenseToolStripMenuItem.Size = new Size(248, 46);
            newDrivingLicenseToolStripMenuItem.Text = "New Driving License";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(310, 6);
            // 
            // mangeApplicationToolStripMenuItem
            // 
            mangeApplicationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { localDrivingLicenseApplicationToolStripMenuItem, internationalLicenseApplicationToolStripMenuItem });
            mangeApplicationToolStripMenuItem.Image = (Image)resources.GetObject("mangeApplicationToolStripMenuItem.Image");
            mangeApplicationToolStripMenuItem.Name = "mangeApplicationToolStripMenuItem";
            mangeApplicationToolStripMenuItem.Size = new Size(313, 46);
            mangeApplicationToolStripMenuItem.Text = "Mange Applications";
            // 
            // localDrivingLicenseApplicationToolStripMenuItem
            // 
            localDrivingLicenseApplicationToolStripMenuItem.Font = new Font("Microsoft JhengHei UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            localDrivingLicenseApplicationToolStripMenuItem.Image = (Image)resources.GetObject("localDrivingLicenseApplicationToolStripMenuItem.Image");
            localDrivingLicenseApplicationToolStripMenuItem.Name = "localDrivingLicenseApplicationToolStripMenuItem";
            localDrivingLicenseApplicationToolStripMenuItem.Size = new Size(331, 26);
            localDrivingLicenseApplicationToolStripMenuItem.Text = "Local Driving License Application";
            localDrivingLicenseApplicationToolStripMenuItem.Click += localDrivingLicenseApplicationToolStripMenuItem_Click;
            // 
            // internationalLicenseApplicationToolStripMenuItem
            // 
            internationalLicenseApplicationToolStripMenuItem.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            internationalLicenseApplicationToolStripMenuItem.Image = (Image)resources.GetObject("internationalLicenseApplicationToolStripMenuItem.Image");
            internationalLicenseApplicationToolStripMenuItem.Name = "internationalLicenseApplicationToolStripMenuItem";
            internationalLicenseApplicationToolStripMenuItem.Size = new Size(331, 26);
            internationalLicenseApplicationToolStripMenuItem.Text = "international License Application";
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(310, 6);
            // 
            // ToolStripMenuItemmangeApplicationTypes
            // 
            ToolStripMenuItemmangeApplicationTypes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ToolStripMenuItemmangeApplicationTypes.Image = (Image)resources.GetObject("ToolStripMenuItemmangeApplicationTypes.Image");
            ToolStripMenuItemmangeApplicationTypes.ImageAlign = ContentAlignment.MiddleLeft;
            ToolStripMenuItemmangeApplicationTypes.Name = "ToolStripMenuItemmangeApplicationTypes";
            ToolStripMenuItemmangeApplicationTypes.Size = new Size(313, 46);
            ToolStripMenuItemmangeApplicationTypes.Text = "Mange Application Types";
            ToolStripMenuItemmangeApplicationTypes.Click += ToolStripMenuItemMangeApplicationTypes_Click;
            // 
            // mangeToolStripMenuItemSeprate
            // 
            mangeToolStripMenuItemSeprate.Name = "mangeToolStripMenuItemSeprate";
            mangeToolStripMenuItemSeprate.Size = new Size(310, 6);
            // 
            // ToolStripMenuItemTestTypes
            // 
            ToolStripMenuItemTestTypes.Image = (Image)resources.GetObject("ToolStripMenuItemTestTypes.Image");
            ToolStripMenuItemTestTypes.Name = "ToolStripMenuItemTestTypes";
            ToolStripMenuItemTestTypes.Size = new Size(313, 46);
            ToolStripMenuItemTestTypes.Text = "Mange Test Types";
            ToolStripMenuItemTestTypes.Click += mangeToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(310, 6);
            // 
            // peopleToolStripMenuItem
            // 
            peopleToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            peopleToolStripMenuItem.Image = (Image)resources.GetObject("peopleToolStripMenuItem.Image");
            peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            peopleToolStripMenuItem.Size = new Size(129, 68);
            peopleToolStripMenuItem.Text = "People";
            peopleToolStripMenuItem.Click += peopleToolStripMenuItem_Click;
            // 
            // driversToolStripMenuItem
            // 
            driversToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            driversToolStripMenuItem.Image = (Image)resources.GetObject("driversToolStripMenuItem.Image");
            driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            driversToolStripMenuItem.Size = new Size(134, 68);
            driversToolStripMenuItem.Text = "Drivers";
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usersToolStripMenuItem.Image = (Image)resources.GetObject("usersToolStripMenuItem.Image");
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(117, 68);
            usersToolStripMenuItem.Text = "Users";
            usersToolStripMenuItem.Click += usersToolStripMenuItem_Click;
            // 
            // accountSettToolStripMenuItem
            // 
            accountSettToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { currentUserToolStripMenuItem, ToolStripchangePassword, toolStripMenuItem1, signOutToolStripMenuItem });
            accountSettToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accountSettToolStripMenuItem.Image = (Image)resources.GetObject("accountSettToolStripMenuItem.Image");
            accountSettToolStripMenuItem.Name = "accountSettToolStripMenuItem";
            accountSettToolStripMenuItem.Size = new Size(227, 68);
            accountSettToolStripMenuItem.Text = "Account Settings";
            // 
            // currentUserToolStripMenuItem
            // 
            currentUserToolStripMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            currentUserToolStripMenuItem.Image = (Image)resources.GetObject("currentUserToolStripMenuItem.Image");
            currentUserToolStripMenuItem.Name = "currentUserToolStripMenuItem";
            currentUserToolStripMenuItem.Size = new Size(256, 46);
            currentUserToolStripMenuItem.Text = "Current User";
            currentUserToolStripMenuItem.Click += currentUserToolStripMenuItem_Click;
            // 
            // ToolStripchangePassword
            // 
            ToolStripchangePassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ToolStripchangePassword.Image = (Image)resources.GetObject("ToolStripchangePassword.Image");
            ToolStripchangePassword.Name = "ToolStripchangePassword";
            ToolStripchangePassword.Size = new Size(256, 46);
            ToolStripchangePassword.Text = "Change Password";
            ToolStripchangePassword.Click += ToolStripchangePassword_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(253, 6);
            // 
            // signOutToolStripMenuItem
            // 
            signOutToolStripMenuItem.BackgroundImageLayout = ImageLayout.None;
            signOutToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signOutToolStripMenuItem.Image = (Image)resources.GetObject("signOutToolStripMenuItem.Image");
            signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            signOutToolStripMenuItem.Size = new Size(256, 46);
            signOutToolStripMenuItem.Text = "Sign Out";
            signOutToolStripMenuItem.Click += signOutToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1698, 650);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // localLicenseToolStripMenuItem
            // 
            localLicenseToolStripMenuItem.Image = (Image)resources.GetObject("localLicenseToolStripMenuItem.Image");
            localLicenseToolStripMenuItem.Name = "localLicenseToolStripMenuItem";
            localLicenseToolStripMenuItem.Size = new Size(249, 46);
            localLicenseToolStripMenuItem.Text = "Local License";
            // 
            // internationalLicenseToolStripMenuItem
            // 
            internationalLicenseToolStripMenuItem.Image = (Image)resources.GetObject("internationalLicenseToolStripMenuItem.Image");
            internationalLicenseToolStripMenuItem.Name = "internationalLicenseToolStripMenuItem";
            internationalLicenseToolStripMenuItem.Size = new Size(249, 46);
            internationalLicenseToolStripMenuItem.Text = "international License";
            // 
            // frmMainScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1672, 708);
            Controls.Add(pictureBox1);
            Controls.Add(MenustrDVDL);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            IsMdiContainer = true;
            MainMenuStrip = MenustrDVDL;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "frmMainScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Screen ";
            Load += frmMainScreen_Load;
            MenustrDVDL.ResumeLayout(false);
            MenustrDVDL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip MenustrDVDL;
        private ToolStripMenuItem applicationsToolStripMenuItem;
        private ToolStripMenuItem peopleToolStripMenuItem;
        private ToolStripMenuItem driversToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem accountSettToolStripMenuItem;
        private PictureBox pictureBox1;
        private ToolStripMenuItem signOutToolStripMenuItem;
        private ToolStripMenuItem currentUserToolStripMenuItem;
        private ToolStripMenuItem ToolStripchangePassword;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem ToolStripMenuItemmangeApplicationTypes;
        private ToolStripMenuItem ToolStripMenuItemTestTypes;
        private ToolStripSeparator mangeToolStripMenuItemSeprate;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem drivingLicensesServicesToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripMenuItem newDrivingLicenseToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem mangeApplicationToolStripMenuItem;
        private ToolStripMenuItem localDrivingLicenseApplicationToolStripMenuItem;
        private ToolStripMenuItem internationalLicenseApplicationToolStripMenuItem;
        private ToolStripMenuItem localLicenseToolStripMenuItem;
        private ToolStripMenuItem internationalLicenseToolStripMenuItem;
    }
}
