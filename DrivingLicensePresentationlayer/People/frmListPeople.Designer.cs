namespace DVDLPresentationLayer.ListScreen
{
    partial class frmListPeople
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
            userctrlShowPeople1 = new DVLDPresentationLayer.UserControls.UserctrlShowPeople();
            SuspendLayout();
            // 
            // userctrlShowPeople1
            // 
            userctrlShowPeople1.Location = new Point(12, -1);
            userctrlShowPeople1.Name = "userctrlShowPeople1";
            userctrlShowPeople1.Size = new Size(1638, 764);
            userctrlShowPeople1.TabIndex = 0;
            userctrlShowPeople1.Load += userctrlShowPeople1_Load;
            // 
            // frmListPeople
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1644, 764);
            Controls.Add(userctrlShowPeople1);
            Name = "frmListPeople";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "People List";
            Load += frmListPeople_Load;
            ResumeLayout(false);
        }

        #endregion

        private DVLDPresentationLayer.UserControls.UserctrlShowPeople userctrlShowPeople1;
    }
}