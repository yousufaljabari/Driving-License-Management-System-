namespace DVLDPresentationLayer.UserControls
{
    partial class UserctrlShowPeople
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserctrlShowPeople));
            dataGridViewShowPeople = new DataGridView();
            contextMenuAddEditDeletePerson = new ContextMenuStrip(components);
            ShowDetailsToolStripMenuItem = new ToolStripMenuItem();
            SeparateOneToolStripMenuItem = new ToolStripSeparator();
            addNewPersonToolStripMenuItem1 = new ToolStripMenuItem();
            EditPersonToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            SeparateTwoToolStripMenuItem = new ToolStripSeparator();
            sendEmailToolStripMenuItem = new ToolStripMenuItem();
            callPhoneToolStripMenuItem1 = new ToolStripMenuItem();
            clsPersonBindingSource = new BindingSource(components);
            pictureBox1 = new PictureBox();
            labelTItleText = new Label();
            labelNumberOfRecord = new Label();
            labelFilterby = new Label();
            comboBoxFilterBy = new ComboBox();
            textBoxFilterBy = new TextBox();
            btnAddNewPerson = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewShowPeople).BeginInit();
            contextMenuAddEditDeletePerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)clsPersonBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewShowPeople
            // 
            dataGridViewShowPeople.AllowUserToAddRows = false;
            dataGridViewShowPeople.AllowUserToOrderColumns = true;
            dataGridViewShowPeople.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewShowPeople.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewShowPeople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewShowPeople.ContextMenuStrip = contextMenuAddEditDeletePerson;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Variable Display Semib", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewShowPeople.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewShowPeople.GridColor = SystemColors.ButtonFace;
            dataGridViewShowPeople.Location = new Point(6, 237);
            dataGridViewShowPeople.Name = "dataGridViewShowPeople";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.InactiveCaptionText;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.InactiveBorder;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewShowPeople.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewShowPeople.RowHeadersWidth = 50;
            dataGridViewShowPeople.Size = new Size(1648, 410);
            dataGridViewShowPeople.TabIndex = 0;
            // 
            // contextMenuAddEditDeletePerson
            // 
            contextMenuAddEditDeletePerson.ImageScalingSize = new Size(20, 20);
            contextMenuAddEditDeletePerson.Items.AddRange(new ToolStripItem[] { ShowDetailsToolStripMenuItem, SeparateOneToolStripMenuItem, addNewPersonToolStripMenuItem1, EditPersonToolStripMenuItem, deleteToolStripMenuItem, SeparateTwoToolStripMenuItem, sendEmailToolStripMenuItem, callPhoneToolStripMenuItem1 });
            contextMenuAddEditDeletePerson.Name = "contextMenuAddEditDeletePerson";
            contextMenuAddEditDeletePerson.Size = new Size(188, 160);
            // 
            // ShowDetailsToolStripMenuItem
            // 
            ShowDetailsToolStripMenuItem.Name = "ShowDetailsToolStripMenuItem";
            ShowDetailsToolStripMenuItem.Size = new Size(187, 24);
            ShowDetailsToolStripMenuItem.Text = "Show Details";
            ShowDetailsToolStripMenuItem.Click += ShowDetailsToolStripMenuItem_Click;
            // 
            // SeparateOneToolStripMenuItem
            // 
            SeparateOneToolStripMenuItem.Name = "SeparateOneToolStripMenuItem";
            SeparateOneToolStripMenuItem.Size = new Size(184, 6);
            // 
            // addNewPersonToolStripMenuItem1
            // 
            addNewPersonToolStripMenuItem1.Name = "addNewPersonToolStripMenuItem1";
            addNewPersonToolStripMenuItem1.Size = new Size(187, 24);
            addNewPersonToolStripMenuItem1.Text = "Add New Person";
            addNewPersonToolStripMenuItem1.Click += addNewPersonToolStripMenuItem1_Click;
            // 
            // EditPersonToolStripMenuItem
            // 
            EditPersonToolStripMenuItem.Name = "EditPersonToolStripMenuItem";
            EditPersonToolStripMenuItem.Size = new Size(187, 24);
            EditPersonToolStripMenuItem.Text = "Edit";
            EditPersonToolStripMenuItem.Click += EditPersonToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(187, 24);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // SeparateTwoToolStripMenuItem
            // 
            SeparateTwoToolStripMenuItem.Name = "SeparateTwoToolStripMenuItem";
            SeparateTwoToolStripMenuItem.Size = new Size(184, 6);
            // 
            // sendEmailToolStripMenuItem
            // 
            sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            sendEmailToolStripMenuItem.Size = new Size(187, 24);
            sendEmailToolStripMenuItem.Text = "Send Email";
            sendEmailToolStripMenuItem.Click += sendEmailToolStripMenuItem_Click;
            // 
            // callPhoneToolStripMenuItem1
            // 
            callPhoneToolStripMenuItem1.Name = "callPhoneToolStripMenuItem1";
            callPhoneToolStripMenuItem1.Size = new Size(187, 24);
            callPhoneToolStripMenuItem1.Text = "Call Phone";
            callPhoneToolStripMenuItem1.Click += callPhoneToolStripMenuItem1_Click;
            // 
            // clsPersonBindingSource
            // 
            clsPersonBindingSource.DataSource = typeof(DVLDBusinessLayer.clsPerson);
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(692, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(276, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // labelTItleText
            // 
            labelTItleText.BorderStyle = BorderStyle.FixedSingle;
            labelTItleText.FlatStyle = FlatStyle.System;
            labelTItleText.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTItleText.ForeColor = Color.IndianRed;
            labelTItleText.Location = new Point(669, 160);
            labelTItleText.Name = "labelTItleText";
            labelTItleText.Size = new Size(313, 50);
            labelTItleText.TabIndex = 2;
            labelTItleText.Text = "Mange People";
            labelTItleText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelNumberOfRecord
            // 
            labelNumberOfRecord.AutoSize = true;
            labelNumberOfRecord.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNumberOfRecord.Location = new Point(49, 650);
            labelNumberOfRecord.Name = "labelNumberOfRecord";
            labelNumberOfRecord.Size = new Size(128, 27);
            labelNumberOfRecord.TabIndex = 3;
            labelNumberOfRecord.Text = "# Records = ";
            labelNumberOfRecord.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelFilterby
            // 
            labelFilterby.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFilterby.Location = new Point(0, 189);
            labelFilterby.Name = "labelFilterby";
            labelFilterby.Size = new Size(192, 45);
            labelFilterby.TabIndex = 4;
            labelFilterby.Text = "Filter By ";
            labelFilterby.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBoxFilterBy
            // 
            comboBoxFilterBy.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilterBy.FormattingEnabled = true;
            comboBoxFilterBy.Items.AddRange(new object[] { "None ", "Person ID ", "National No", "First Name ", "Second Name ", "Third Name ", "Last Name ", "Nationality", "Gender", "Phone", "Email" });
            comboBoxFilterBy.Location = new Point(140, 199);
            comboBoxFilterBy.Name = "comboBoxFilterBy";
            comboBoxFilterBy.Size = new Size(169, 28);
            comboBoxFilterBy.TabIndex = 5;
            comboBoxFilterBy.SelectedIndexChanged += comboBoxFilterBy_SelectedIndexChanged;
            // 
            // textBoxFilterBy
            // 
            textBoxFilterBy.Location = new Point(328, 199);
            textBoxFilterBy.Name = "textBoxFilterBy";
            textBoxFilterBy.Size = new Size(225, 27);
            textBoxFilterBy.TabIndex = 6;
            textBoxFilterBy.Visible = false;
            textBoxFilterBy.TextChanged += textBoxFilterBy_TextChanged;
            textBoxFilterBy.KeyPress += textBoxFilterBy_KeyPress;
            // 
            // btnAddNewPerson
            // 
            btnAddNewPerson.BackgroundImage = (Image)resources.GetObject("btnAddNewPerson.BackgroundImage");
            btnAddNewPerson.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddNewPerson.Location = new Point(1550, 159);
            btnAddNewPerson.Name = "btnAddNewPerson";
            btnAddNewPerson.Size = new Size(84, 75);
            btnAddNewPerson.TabIndex = 7;
            btnAddNewPerson.UseVisualStyleBackColor = true;
            btnAddNewPerson.Click += btnAddNewPerson_Click;
            // 
            // UserctrlShowPeople
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAddNewPerson);
            Controls.Add(textBoxFilterBy);
            Controls.Add(comboBoxFilterBy);
            Controls.Add(labelFilterby);
            Controls.Add(labelNumberOfRecord);
            Controls.Add(labelTItleText);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridViewShowPeople);
            Name = "UserctrlShowPeople";
            Size = new Size(1695, 778);
            Load += UserctrlShowPeople_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewShowPeople).EndInit();
            contextMenuAddEditDeletePerson.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)clsPersonBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewShowPeople;
        private PictureBox pictureBox1;
        private Label labelTItleText;
        private Label labelNumberOfRecord;
        private BindingSource clsPersonBindingSource;
        private Label labelFilterby;
        private ComboBox comboBoxFilterBy;
        private TextBox textBoxFilterBy;
        private Button btnAddNewPerson;
        private ContextMenuStrip contextMenuAddEditDeletePerson;
        private ToolStripMenuItem ShowDetailsToolStripMenuItem;
        private ToolStripMenuItem addNewPersonToolStripMenuItem1;
        private ToolStripMenuItem EditPersonToolStripMenuItem;
        private ToolStripSeparator SeparateOneToolStripMenuItem;
        private ToolStripSeparator SeparateTwoToolStripMenuItem;
        private ToolStripMenuItem sendEmailToolStripMenuItem;
        private ToolStripMenuItem callPhoneToolStripMenuItem1;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}
