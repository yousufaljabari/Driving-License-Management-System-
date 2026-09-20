namespace DVLDPresentationLayer.Tests
{
    partial class frmVisionTestAppointments
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
            ctrlApplicationInfo1 = new DVLDPresentationLayer.Applications.Controls.ctrlApplicationInfo();
            label1 = new Label();
            pictureBoxVisionTest = new PictureBox();
            dgvAppointments = new DataGridView();
            cmsTestAppointments = new ContextMenuStrip(components);
            tsmiEditAppointment = new ToolStripMenuItem();
            tsmiTakeTest = new ToolStripMenuItem();
            lblAppointments = new Label();
            btnAddAppointment = new Button();
            lblRecords = new Label();
            btnClose = new Button();
            lblRecordsCount = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVisionTest).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            cmsTestAppointments.SuspendLayout();
            SuspendLayout();
            // 
            // ctrlApplicationInfo1
            // 
            ctrlApplicationInfo1.Location = new Point(26, 149);
            ctrlApplicationInfo1.Name = "ctrlApplicationInfo1";
            ctrlApplicationInfo1.Size = new Size(920, 576);
            ctrlApplicationInfo1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(318, 128);
            label1.Name = "label1";
            label1.Size = new Size(367, 41);
            label1.TabIndex = 1;
            label1.Text = "Vision Test Appoinments";
            // 
            // pictureBoxVisionTest
            // 
            pictureBoxVisionTest.Image = Properties.Resources.icons8_vision_96;
            pictureBoxVisionTest.Location = new Point(440, 16);
            pictureBoxVisionTest.Name = "pictureBoxVisionTest";
            pictureBoxVisionTest.Size = new Size(98, 97);
            pictureBoxVisionTest.TabIndex = 2;
            pictureBoxVisionTest.TabStop = false;
            // 
            // dgvAppointments
            // 
            dgvAppointments.AllowUserToAddRows = false;
            dgvAppointments.AllowUserToDeleteRows = false;
            dgvAppointments.AllowUserToOrderColumns = true;
            dgvAppointments.BackgroundColor = SystemColors.ControlLightLight;
            dgvAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppointments.ContextMenuStrip = cmsTestAppointments;
            dgvAppointments.GridColor = SystemColors.HighlightText;
            dgvAppointments.Location = new Point(-15, 795);
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.ReadOnly = true;
            dgvAppointments.RowHeadersWidth = 51;
            dgvAppointments.Size = new Size(961, 165);
            dgvAppointments.TabIndex = 3;
            // 
            // cmsTestAppointments
            // 
            cmsTestAppointments.ImageScalingSize = new Size(20, 20);
            cmsTestAppointments.Items.AddRange(new ToolStripItem[] { tsmiEditAppointment, tsmiTakeTest });
            cmsTestAppointments.Name = "cmsTestAppointments";
            cmsTestAppointments.Size = new Size(254, 96);
            cmsTestAppointments.Opening += cmsTestAppointments_Opening;
            // 
            // tsmiEditAppointment
            // 
            tsmiEditAppointment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tsmiEditAppointment.Image = Properties.Resources.ApplicationEdit;
            tsmiEditAppointment.Name = "tsmiEditAppointment";
            tsmiEditAppointment.Size = new Size(253, 32);
            tsmiEditAppointment.Text = "Edit Appointment";
            tsmiEditAppointment.Click += tsmiEditAppointment_Click;
            // 
            // tsmiTakeTest
            // 
            tsmiTakeTest.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tsmiTakeTest.Image = Properties.Resources.Schdule;
            tsmiTakeTest.Name = "tsmiTakeTest";
            tsmiTakeTest.Size = new Size(253, 32);
            tsmiTakeTest.Text = "Take Test";
            // 
            // lblAppointments
            // 
            lblAppointments.AutoSize = true;
            lblAppointments.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppointments.Location = new Point(20, 748);
            lblAppointments.Name = "lblAppointments";
            lblAppointments.Size = new Size(148, 25);
            lblAppointments.TabIndex = 4;
            lblAppointments.Text = "Appointments : ";
            // 
            // btnAddAppointment
            // 
            btnAddAppointment.Image = Properties.Resources.addTestAppointment;
            btnAddAppointment.Location = new Point(880, 741);
            btnAddAppointment.Name = "btnAddAppointment";
            btnAddAppointment.Size = new Size(66, 42);
            btnAddAppointment.TabIndex = 5;
            btnAddAppointment.UseVisualStyleBackColor = true;
            btnAddAppointment.Click += btnAddAppointment_Click;
            // 
            // lblRecords
            // 
            lblRecords.AutoSize = true;
            lblRecords.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecords.Location = new Point(26, 986);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new Size(111, 25);
            lblRecords.TabIndex = 7;
            lblRecords.Text = "# Records : ";
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Image = Properties.Resources.icons8_close_48;
            btnClose.Location = new Point(792, 974);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(143, 51);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecordsCount.Location = new Point(143, 986);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(22, 25);
            lblRecordsCount.TabIndex = 9;
            lblRecordsCount.Text = "0";
            // 
            // frmVisionTestAppointments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 1030);
            Controls.Add(lblRecordsCount);
            Controls.Add(btnClose);
            Controls.Add(lblRecords);
            Controls.Add(btnAddAppointment);
            Controls.Add(lblAppointments);
            Controls.Add(dgvAppointments);
            Controls.Add(pictureBoxVisionTest);
            Controls.Add(label1);
            Controls.Add(ctrlApplicationInfo1);
            Name = "frmVisionTestAppointments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vision Test Appointments";
            Load += frmVisionTest_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxVisionTest).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            cmsTestAppointments.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Applications.Controls.ctrlApplicationInfo ctrlApplicationInfo1;
        private Label label1;
        private PictureBox pictureBoxVisionTest;
        private DataGridView dgvAppointments;
        private Label lblAppointments;
        private Button btnAddAppointment;
        private Label lblRecords;
        private Button btnClose;
        private Label lblRecordsCount;
        private ContextMenuStrip cmsTestAppointments;
        private ToolStripMenuItem tsmiEditAppointment;
        private ToolStripMenuItem tsmiTakeTest;
    }
}