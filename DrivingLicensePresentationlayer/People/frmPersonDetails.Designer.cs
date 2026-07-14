namespace DVLDPresentationLayer.PeopleScreens
{
    partial class frmPersonDetails
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
            userControlPersonCard1 = new DVLDPresentationLayer.UserControls.UserControlPersonCard();
            SuspendLayout();
            // 
            // userControlPersonCard1
            // 
            userControlPersonCard1.Location = new Point(12, 3);
            userControlPersonCard1.Name = "userControlPersonCard1";
            userControlPersonCard1.Size = new Size(1168, 648);
            userControlPersonCard1.TabIndex = 0;
            // 
            // frmPersonDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 644);
            Controls.Add(userControlPersonCard1);
            Name = "frmPersonDetails";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmPersonDetails";
            Load += frmPersonDetails_Load;
            ResumeLayout(false);
        }

        #endregion

        private UserControls.UserControlPersonCard userControlPersonCard1;
    }
}