namespace DVLDPresentationLayer.Users
{
    partial class frmMangeUsersScreen
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
            userControlMangeUsers1 = new DVLDPresentationLayer.Users.Controls.UserControlMangeUsers();
            SuspendLayout();
            // 
            // userControlMangeUsers1
            // 
            userControlMangeUsers1.Anchor = AnchorStyles.None;
            userControlMangeUsers1.AutoSize = true;
            userControlMangeUsers1.Location = new Point(18, 9);
            userControlMangeUsers1.Name = "userControlMangeUsers1";
            userControlMangeUsers1.Size = new Size(1182, 718);
            userControlMangeUsers1.TabIndex = 0;
            // 
            // frmMangeUsersScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1263, 754);
            Controls.Add(userControlMangeUsers1);
            Name = "frmMangeUsersScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mange Users ";
            Load += frmMangeUsersScreen_Load;
            Resize += frmMangeUsersScreen_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.UserControlMangeUsers userControlMangeUsers1;
    }
}