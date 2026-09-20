namespace DVLDPresentationLayer.Applications
{
    partial class frmshowApplicationInfo
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
            ctrlApplicationInfo1 = new DVLDPresentationLayer.Applications.Controls.ctrlApplicationInfo();
            SuspendLayout();
            // 
            // ctrlApplicationInfo1
            // 
            ctrlApplicationInfo1.Location = new Point(56, 12);
            ctrlApplicationInfo1.Name = "ctrlApplicationInfo1";
            ctrlApplicationInfo1.Size = new Size(898, 607);
            ctrlApplicationInfo1.TabIndex = 0;
            // 
            // frmshowApplicationInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 631);
            Controls.Add(ctrlApplicationInfo1);
            Name = "frmshowApplicationInfo";
            Text = "frmshowApplicationInfo";
            Load += frmshowApplicationInfo_Load;
            ResumeLayout(false);
        }

        #endregion

        private Controls.ctrlApplicationInfo ctrlApplicationInfo1;
    }
}