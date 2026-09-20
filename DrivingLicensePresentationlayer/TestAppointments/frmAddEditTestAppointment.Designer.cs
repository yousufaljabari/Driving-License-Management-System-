namespace DVLDPresentationLayer.TestAppointments
{
    partial class frmAddEditTestAppointment
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
            components = new System.ComponentModel.Container();
            pictureBoxVisionPicture = new PictureBox();
            labelScheduleTest = new Label();
            buttonSave = new Button();
            ctrlScheduleTest1 = new ctrlScheduleTest();
            buttonClose = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxVisionPicture).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxVisionPicture
            // 
            pictureBoxVisionPicture.Image = Properties.Resources.icons8_vision_96;
            pictureBoxVisionPicture.Location = new Point(319, 12);
            pictureBoxVisionPicture.Name = "pictureBoxVisionPicture";
            pictureBoxVisionPicture.Size = new Size(100, 101);
            pictureBoxVisionPicture.TabIndex = 0;
            pictureBoxVisionPicture.TabStop = false;
            // 
            // labelScheduleTest
            // 
            labelScheduleTest.AutoSize = true;
            labelScheduleTest.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelScheduleTest.ForeColor = Color.IndianRed;
            labelScheduleTest.Location = new Point(263, 135);
            labelScheduleTest.Name = "labelScheduleTest";
            labelScheduleTest.Size = new Size(209, 41);
            labelScheduleTest.TabIndex = 1;
            labelScheduleTest.Text = "Schedule Test";
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSave.Image = Properties.Resources.icons8_save_50;
            buttonSave.Location = new Point(379, 813);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(126, 56);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Save";
            buttonSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // ctrlScheduleTest1
            // 
            ctrlScheduleTest1.Location = new Point(21, 194);
            ctrlScheduleTest1.Name = "ctrlScheduleTest1";
            ctrlScheduleTest1.Size = new Size(691, 613);
            ctrlScheduleTest1.TabIndex = 4;
            // 
            // buttonClose
            // 
            buttonClose.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonClose.Image = Properties.Resources.icons8_close_48;
            buttonClose.Location = new Point(239, 813);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(125, 52);
            buttonClose.TabIndex = 5;
            buttonClose.Text = "Close";
            buttonClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // frmAddEditTestAppointment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 893);
            Controls.Add(buttonClose);
            Controls.Add(ctrlScheduleTest1);
            Controls.Add(buttonSave);
            Controls.Add(labelScheduleTest);
            Controls.Add(pictureBoxVisionPicture);
            Name = "frmAddEditTestAppointment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAddEditTestAppointment";
            Load += frmAddEditTestAppointment_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxVisionPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxVisionPicture;
        private Label labelScheduleTest;
        private Button buttonSave;
        private ctrlScheduleTest ctrlScheduleTest1;
        private Button buttonClose;
        private ContextMenuStrip contextMenuStrip1;
    }
}