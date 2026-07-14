namespace DVLDPresentationLayer.Users.Controls
{
    partial class UserControlShowDetails
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
            userControlPersonCard1 = new DVLDPresentationLayer.UserControls.UserControlPersonCard();
            groupBoxLoginInfo = new GroupBox();
            labelisActiveresult = new Label();
            labelisActive = new Label();
            labelUsernameresult = new Label();
            labelUsername = new Label();
            labelUserIDResult = new Label();
            labelUserID = new Label();
            groupBoxLoginInfo.SuspendLayout();
            SuspendLayout();
            // 
            // userControlPersonCard1
            // 
            userControlPersonCard1.Location = new Point(51, 13);
            userControlPersonCard1.Name = "userControlPersonCard1";
            userControlPersonCard1.Size = new Size(1189, 546);
            userControlPersonCard1.TabIndex = 0;
            // 
            // groupBoxLoginInfo
            // 
            groupBoxLoginInfo.Controls.Add(labelisActiveresult);
            groupBoxLoginInfo.Controls.Add(labelisActive);
            groupBoxLoginInfo.Controls.Add(labelUsernameresult);
            groupBoxLoginInfo.Controls.Add(labelUsername);
            groupBoxLoginInfo.Controls.Add(labelUserIDResult);
            groupBoxLoginInfo.Controls.Add(labelUserID);
            groupBoxLoginInfo.Location = new Point(94, 604);
            groupBoxLoginInfo.Name = "groupBoxLoginInfo";
            groupBoxLoginInfo.Size = new Size(1117, 148);
            groupBoxLoginInfo.TabIndex = 1;
            groupBoxLoginInfo.TabStop = false;
            groupBoxLoginInfo.Text = "Login Information";
            // 
            // labelisActiveresult
            // 
            labelisActiveresult.AutoSize = true;
            labelisActiveresult.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelisActiveresult.Location = new Point(945, 73);
            labelisActiveresult.Name = "labelisActiveresult";
            labelisActiveresult.Size = new Size(48, 25);
            labelisActiveresult.TabIndex = 5;
            labelisActiveresult.Text = "????";
            // 
            // labelisActive
            // 
            labelisActive.AutoSize = true;
            labelisActive.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelisActive.Location = new Point(835, 72);
            labelisActive.Name = "labelisActive";
            labelisActive.Size = new Size(101, 25);
            labelisActive.TabIndex = 4;
            labelisActive.Text = "is Active : ";
            // 
            // labelUsernameresult
            // 
            labelUsernameresult.AutoSize = true;
            labelUsernameresult.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsernameresult.Location = new Point(561, 73);
            labelUsernameresult.Name = "labelUsernameresult";
            labelUsernameresult.Size = new Size(48, 25);
            labelUsernameresult.TabIndex = 3;
            labelUsernameresult.Text = "????";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsername.Location = new Point(434, 72);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(118, 25);
            labelUsername.TabIndex = 2;
            labelUsername.Text = "Username : ";
            // 
            // labelUserIDResult
            // 
            labelUserIDResult.AutoSize = true;
            labelUserIDResult.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUserIDResult.Location = new Point(213, 72);
            labelUserIDResult.Name = "labelUserIDResult";
            labelUserIDResult.Size = new Size(48, 25);
            labelUserIDResult.TabIndex = 1;
            labelUserIDResult.Text = "????";
            // 
            // labelUserID
            // 
            labelUserID.AutoSize = true;
            labelUserID.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUserID.Location = new Point(114, 72);
            labelUserID.Name = "labelUserID";
            labelUserID.Size = new Size(93, 25);
            labelUserID.TabIndex = 0;
            labelUserID.Text = "UserID  : ";
            // 
            // UserControlShowDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxLoginInfo);
            Controls.Add(userControlPersonCard1);
            Name = "UserControlShowDetails";
            Size = new Size(1243, 777);
            groupBoxLoginInfo.ResumeLayout(false);
            groupBoxLoginInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private UserControls.UserControlPersonCard userControlPersonCard1;
        private GroupBox groupBoxLoginInfo;
        private Label labelUserID;
        private Label labelisActiveresult;
        private Label labelisActive;
        private Label labelUsernameresult;
        private Label labelUsername;
        private Label labelUserIDResult;
    }
}
