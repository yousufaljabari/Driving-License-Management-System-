namespace DVLDPresentationLayer.Users
{
    partial class frmShowUserDetails
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
            userControlShowDetails1 = new DVLDPresentationLayer.Users.Controls.UserControlShowDetails();
            SuspendLayout();
            // 
            // userControlShowDetails1
            // 
            userControlShowDetails1.Location = new Point(12, 12);
            userControlShowDetails1.Name = "userControlShowDetails1";
            userControlShowDetails1.Size = new Size(1332, 716);
            userControlShowDetails1.TabIndex = 0;
            // 
            // frmShowUserDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1323, 774);
            Controls.Add(userControlShowDetails1);
            Name = "frmShowUserDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmShowUserDetailscs";
            Load += frmShowUserDetailscs_Load;
            ResumeLayout(false);
        }

        #endregion

        private Controls.UserControlShowDetails userControlShowDetails1;
    }
}