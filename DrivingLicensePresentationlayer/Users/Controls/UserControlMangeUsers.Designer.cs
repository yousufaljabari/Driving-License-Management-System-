namespace DVLDPresentationLayer.Users.Controls
{
    partial class UserControlMangeUsers
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlMangeUsers));
            pictureBoxMangeUsersIcon = new PictureBox();
            labelMangeUsers = new Label();
            dataGridMangeUsers = new DataGridView();
            contextMenuStripUsersMange = new ContextMenuStrip(components);
            toolStripShowDetails = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            ToolStripaddNewUser = new ToolStripMenuItem();
            ToolStripedit = new ToolStripMenuItem();
            ToolStripdelete = new ToolStripMenuItem();
            ToolStripchangePassword = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            ToolStripsendEmail = new ToolStripMenuItem();
            ToolStripphoneCall = new ToolStripMenuItem();
            buttonCloseUserForm = new Button();
            labelFilterByUsers = new Label();
            comboBoxFilterByUsers = new ComboBox();
            labelRecordUsersNumbers = new Label();
            buttonAddNewUser = new Button();
            textBoxFilterby = new TextBox();
            comboBoxIsActivechoices = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMangeUsersIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridMangeUsers).BeginInit();
            contextMenuStripUsersMange.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxMangeUsersIcon
            // 
            pictureBoxMangeUsersIcon.Image = (Image)resources.GetObject("pictureBoxMangeUsersIcon.Image");
            pictureBoxMangeUsersIcon.Location = new Point(491, 18);
            pictureBoxMangeUsersIcon.Name = "pictureBoxMangeUsersIcon";
            pictureBoxMangeUsersIcon.Size = new Size(222, 158);
            pictureBoxMangeUsersIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMangeUsersIcon.TabIndex = 0;
            pictureBoxMangeUsersIcon.TabStop = false;
            // 
            // labelMangeUsers
            // 
            labelMangeUsers.AutoSize = true;
            labelMangeUsers.Font = new Font("Segoe UI Variable Display", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMangeUsers.ForeColor = Color.IndianRed;
            labelMangeUsers.Location = new Point(507, 176);
            labelMangeUsers.Name = "labelMangeUsers";
            labelMangeUsers.Size = new Size(195, 37);
            labelMangeUsers.TabIndex = 1;
            labelMangeUsers.Text = "Mange Users ";
            // 
            // dataGridMangeUsers
            // 
            dataGridMangeUsers.AllowUserToAddRows = false;
            dataGridMangeUsers.AllowUserToDeleteRows = false;
            dataGridMangeUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridMangeUsers.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridMangeUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMangeUsers.ContextMenuStrip = contextMenuStripUsersMange;
            dataGridMangeUsers.Location = new Point(77, 289);
            dataGridMangeUsers.Name = "dataGridMangeUsers";
            dataGridMangeUsers.ReadOnly = true;
            dataGridMangeUsers.RowHeadersWidth = 51;
            dataGridMangeUsers.Size = new Size(1085, 354);
            dataGridMangeUsers.TabIndex = 2;
            // 
            // contextMenuStripUsersMange
            // 
            contextMenuStripUsersMange.ImageScalingSize = new Size(20, 20);
            contextMenuStripUsersMange.Items.AddRange(new ToolStripItem[] { toolStripShowDetails, toolStripSeparator1, ToolStripaddNewUser, ToolStripedit, ToolStripdelete, ToolStripchangePassword, toolStripSeparator2, ToolStripsendEmail, ToolStripphoneCall });
            contextMenuStripUsersMange.Name = "contextMenuStripUsersMange";
            contextMenuStripUsersMange.Size = new Size(217, 212);
            // 
            // toolStripShowDetails
            // 
            toolStripShowDetails.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripShowDetails.Image = (Image)resources.GetObject("toolStripShowDetails.Image");
            toolStripShowDetails.ImageAlign = ContentAlignment.MiddleLeft;
            toolStripShowDetails.Name = "toolStripShowDetails";
            toolStripShowDetails.Size = new Size(216, 28);
            toolStripShowDetails.Text = "Show Details";
            toolStripShowDetails.Click += toolStripShowDetails_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(213, 6);
            // 
            // ToolStripaddNewUser
            // 
            ToolStripaddNewUser.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ToolStripaddNewUser.Image = (Image)resources.GetObject("ToolStripaddNewUser.Image");
            ToolStripaddNewUser.ImageAlign = ContentAlignment.MiddleLeft;
            ToolStripaddNewUser.Name = "ToolStripaddNewUser";
            ToolStripaddNewUser.Size = new Size(216, 28);
            ToolStripaddNewUser.Text = "Add New User";
            ToolStripaddNewUser.Click += ToolStripaddNewUser_Click;
            // 
            // ToolStripedit
            // 
            ToolStripedit.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ToolStripedit.Image = (Image)resources.GetObject("ToolStripedit.Image");
            ToolStripedit.ImageAlign = ContentAlignment.MiddleLeft;
            ToolStripedit.Name = "ToolStripedit";
            ToolStripedit.Size = new Size(216, 28);
            ToolStripedit.Text = "Edit";
            ToolStripedit.Click += ToolStripedit_Click;
            // 
            // ToolStripdelete
            // 
            ToolStripdelete.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ToolStripdelete.Image = (Image)resources.GetObject("ToolStripdelete.Image");
            ToolStripdelete.ImageAlign = ContentAlignment.MiddleLeft;
            ToolStripdelete.Name = "ToolStripdelete";
            ToolStripdelete.Size = new Size(216, 28);
            ToolStripdelete.Text = "Delete";
            ToolStripdelete.Click += ToolStripdelete_Click;
            // 
            // ToolStripchangePassword
            // 
            ToolStripchangePassword.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ToolStripchangePassword.Image = (Image)resources.GetObject("ToolStripchangePassword.Image");
            ToolStripchangePassword.Name = "ToolStripchangePassword";
            ToolStripchangePassword.Size = new Size(216, 28);
            ToolStripchangePassword.Text = "Change Password";
            ToolStripchangePassword.Click += ToolStripchangePassword_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(213, 6);
            // 
            // ToolStripsendEmail
            // 
            ToolStripsendEmail.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ToolStripsendEmail.Image = (Image)resources.GetObject("ToolStripsendEmail.Image");
            ToolStripsendEmail.ImageAlign = ContentAlignment.MiddleLeft;
            ToolStripsendEmail.Name = "ToolStripsendEmail";
            ToolStripsendEmail.Size = new Size(216, 28);
            ToolStripsendEmail.Text = "Send Email";
            ToolStripsendEmail.Click += ToolStripsendEmail_Click;
            // 
            // ToolStripphoneCall
            // 
            ToolStripphoneCall.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ToolStripphoneCall.Image = (Image)resources.GetObject("ToolStripphoneCall.Image");
            ToolStripphoneCall.ImageAlign = ContentAlignment.MiddleLeft;
            ToolStripphoneCall.Name = "ToolStripphoneCall";
            ToolStripphoneCall.Size = new Size(216, 28);
            ToolStripphoneCall.Text = "Phone Call";
            ToolStripphoneCall.Click += ToolStripphoneCall_Click;
            // 
            // buttonCloseUserForm
            // 
            buttonCloseUserForm.BackgroundImageLayout = ImageLayout.Center;
            buttonCloseUserForm.Image = (Image)resources.GetObject("buttonCloseUserForm.Image");
            buttonCloseUserForm.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCloseUserForm.Location = new Point(1032, 658);
            buttonCloseUserForm.Name = "buttonCloseUserForm";
            buttonCloseUserForm.Size = new Size(130, 53);
            buttonCloseUserForm.TabIndex = 3;
            buttonCloseUserForm.Text = "Close";
            buttonCloseUserForm.TextAlign = ContentAlignment.MiddleRight;
            buttonCloseUserForm.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCloseUserForm.UseVisualStyleBackColor = true;
            buttonCloseUserForm.Click += buttonCloseUserForm_Click;
            // 
            // labelFilterByUsers
            // 
            labelFilterByUsers.AutoSize = true;
            labelFilterByUsers.Location = new Point(78, 251);
            labelFilterByUsers.Name = "labelFilterByUsers";
            labelFilterByUsers.Size = new Size(62, 20);
            labelFilterByUsers.TabIndex = 4;
            labelFilterByUsers.Text = "Filter By";
            // 
            // comboBoxFilterByUsers
            // 
            comboBoxFilterByUsers.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilterByUsers.FormattingEnabled = true;
            comboBoxFilterByUsers.Items.AddRange(new object[] { "None", "User ID ", "User Name", "Person ID ", "Full Name ", "is Active " });
            comboBoxFilterByUsers.Location = new Point(159, 248);
            comboBoxFilterByUsers.Name = "comboBoxFilterByUsers";
            comboBoxFilterByUsers.Size = new Size(151, 28);
            comboBoxFilterByUsers.TabIndex = 5;
            comboBoxFilterByUsers.SelectedIndexChanged += comboBoxFilterByUsers_SelectedIndexChanged;
            // 
            // labelRecordUsersNumbers
            // 
            labelRecordUsersNumbers.AutoSize = true;
            labelRecordUsersNumbers.Font = new Font("Microsoft JhengHei", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRecordUsersNumbers.Location = new Point(81, 658);
            labelRecordUsersNumbers.Name = "labelRecordUsersNumbers";
            labelRecordUsersNumbers.Size = new Size(46, 23);
            labelRecordUsersNumbers.TabIndex = 6;
            labelRecordUsersNumbers.Text = "????";
            // 
            // buttonAddNewUser
            // 
            buttonAddNewUser.BackgroundImage = (Image)resources.GetObject("buttonAddNewUser.BackgroundImage");
            buttonAddNewUser.BackgroundImageLayout = ImageLayout.Center;
            buttonAddNewUser.Location = new Point(1074, 208);
            buttonAddNewUser.Name = "buttonAddNewUser";
            buttonAddNewUser.Size = new Size(88, 74);
            buttonAddNewUser.TabIndex = 7;
            buttonAddNewUser.UseVisualStyleBackColor = true;
            buttonAddNewUser.Click += buttonAddNewUser_Click;
            // 
            // textBoxFilterby
            // 
            textBoxFilterby.Location = new Point(324, 249);
            textBoxFilterby.Name = "textBoxFilterby";
            textBoxFilterby.Size = new Size(207, 27);
            textBoxFilterby.TabIndex = 8;
            textBoxFilterby.TextChanged += textBoxFilterby_TextChanged;
            textBoxFilterby.KeyPress += textBoxFilterby_KeyPress;
            // 
            // comboBoxIsActivechoices
            // 
            comboBoxIsActivechoices.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxIsActivechoices.FormattingEnabled = true;
            comboBoxIsActivechoices.Items.AddRange(new object[] { "All", "Yes", "No " });
            comboBoxIsActivechoices.Location = new Point(324, 249);
            comboBoxIsActivechoices.Name = "comboBoxIsActivechoices";
            comboBoxIsActivechoices.Size = new Size(115, 28);
            comboBoxIsActivechoices.TabIndex = 9;
            comboBoxIsActivechoices.SelectedIndexChanged += comboBoxIsActivechoices_SelectedIndexChanged;
            // 
            // UserControlMangeUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBoxIsActivechoices);
            Controls.Add(textBoxFilterby);
            Controls.Add(buttonAddNewUser);
            Controls.Add(labelRecordUsersNumbers);
            Controls.Add(comboBoxFilterByUsers);
            Controls.Add(labelFilterByUsers);
            Controls.Add(buttonCloseUserForm);
            Controls.Add(dataGridMangeUsers);
            Controls.Add(labelMangeUsers);
            Controls.Add(pictureBoxMangeUsersIcon);
            Name = "UserControlMangeUsers";
            Size = new Size(1272, 781);
            Load += UserControlMangeUsers_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxMangeUsersIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridMangeUsers).EndInit();
            contextMenuStripUsersMange.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxMangeUsersIcon;
        private Label labelMangeUsers;
        private DataGridView dataGridMangeUsers;
        private Button buttonCloseUserForm;
        private Label labelFilterByUsers;
        private ComboBox comboBoxFilterByUsers;
        private Label labelRecordUsersNumbers;
        private Button buttonAddNewUser;
        private TextBox textBoxFilterby;
        private ComboBox comboBoxIsActivechoices;
        private ContextMenuStrip contextMenuStripUsersMange;
        private ToolStripMenuItem toolStripShowDetails;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem ToolStripaddNewUser;
        private ToolStripMenuItem ToolStripedit;
        private ToolStripMenuItem ToolStripdelete;
        private ToolStripMenuItem ToolStripchangePassword;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem ToolStripsendEmail;
        private ToolStripMenuItem ToolStripphoneCall;
    }
}
