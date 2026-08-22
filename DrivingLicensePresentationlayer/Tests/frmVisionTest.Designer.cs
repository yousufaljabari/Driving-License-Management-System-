namespace DVLDPresentationLayer.Tests
{
    partial class frmVisionTest
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
            label1 = new Label();
            pictureBoxVisionTest = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVisionTest).BeginInit();
            SuspendLayout();
            // 
            // ctrlApplicationInfo1
            // 
            ctrlApplicationInfo1.Location = new Point(38, 186);
            ctrlApplicationInfo1.Name = "ctrlApplicationInfo1";
            ctrlApplicationInfo1.Size = new Size(905, 613);
            ctrlApplicationInfo1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(318, 132);
            label1.Name = "label1";
            label1.Size = new Size(354, 41);
            label1.TabIndex = 1;
            label1.Text = "Vision Test Appoinment";
            // 
            // pictureBoxVisionTest
            // 
            pictureBoxVisionTest.Image = Properties.Resources.icons8_vision_96;
            pictureBoxVisionTest.Location = new Point(440, 16);
            pictureBoxVisionTest.Name = "pictureBoxVisionTest";
            pictureBoxVisionTest.Size = new Size(98, 99);
            pictureBoxVisionTest.TabIndex = 2;
            pictureBoxVisionTest.TabStop = false;
            // 
            // frmVisionTest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 1055);
            Controls.Add(pictureBoxVisionTest);
            Controls.Add(label1);
            Controls.Add(ctrlApplicationInfo1);
            Name = "frmVisionTest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmVisionTest";
            Load += frmVisionTest_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxVisionTest).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Applications.Controls.ctrlApplicationInfo ctrlApplicationInfo1;
        private Label label1;
        private PictureBox pictureBoxVisionTest;
    }
}