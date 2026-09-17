namespace DVLDPresentationLayer.Tests
{
    partial class frmUpdateTestType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateTestType));
            buttonClose = new Button();
            labelFees = new Label();
            labelTitle = new Label();
            buttonSave = new Button();
            textBoxFees = new TextBox();
            textBoxTitle = new TextBox();
            labelTestIDR = new Label();
            labelTestID = new Label();
            labelUpdateApplicationType = new Label();
            textBoxTestTitle = new TextBox();
            textBoxDescription = new TextBox();
            labelDescription = new Label();
            SuspendLayout();
            // 
            // buttonClose
            // 
            buttonClose.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonClose.Image = (Image)resources.GetObject("buttonClose.Image");
            buttonClose.ImageAlign = ContentAlignment.MiddleLeft;
            buttonClose.Location = new Point(447, 472);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(149, 55);
            buttonClose.TabIndex = 20;
            buttonClose.Text = "Close";
            buttonClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // labelFees
            // 
            labelFees.AutoSize = true;
            labelFees.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFees.Location = new Point(97, 415);
            labelFees.Name = "labelFees";
            labelFees.Size = new Size(60, 31);
            labelFees.TabIndex = 19;
            labelFees.Text = "Fees";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(95, 254);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(62, 31);
            labelTitle.TabIndex = 18;
            labelTitle.Text = "Title";
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSave.Image = (Image)resources.GetObject("buttonSave.Image");
            buttonSave.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSave.Location = new Point(613, 472);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(158, 57);
            buttonSave.TabIndex = 17;
            buttonSave.Text = "Save";
            buttonSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxFees
            // 
            textBoxFees.Location = new Point(208, 417);
            textBoxFees.Name = "textBoxFees";
            textBoxFees.Size = new Size(390, 27);
            textBoxFees.TabIndex = 16;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(207, 259);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(391, 27);
            textBoxTitle.TabIndex = 15;
            // 
            // labelTestIDR
            // 
            labelTestIDR.AutoSize = true;
            labelTestIDR.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTestIDR.Location = new Point(206, 191);
            labelTestIDR.Name = "labelTestIDR";
            labelTestIDR.Size = new Size(74, 31);
            labelTestIDR.TabIndex = 14;
            labelTestIDR.Text = "??????";
            // 
            // labelTestID
            // 
            labelTestID.AutoSize = true;
            labelTestID.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTestID.Location = new Point(107, 193);
            labelTestID.Name = "labelTestID";
            labelTestID.Size = new Size(38, 31);
            labelTestID.TabIndex = 13;
            labelTestID.Text = "ID";
            // 
            // labelUpdateApplicationType
            // 
            labelUpdateApplicationType.AutoSize = true;
            labelUpdateApplicationType.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUpdateApplicationType.ForeColor = Color.IndianRed;
            labelUpdateApplicationType.Location = new Point(207, 45);
            labelUpdateApplicationType.Name = "labelUpdateApplicationType";
            labelUpdateApplicationType.Size = new Size(360, 50);
            labelUpdateApplicationType.TabIndex = 12;
            labelUpdateApplicationType.Text = "Update Test Type";
            // 
            // textBoxTestTitle
            // 
            textBoxTestTitle.Location = new Point(202, 258);
            textBoxTestTitle.Name = "textBoxTestTitle";
            textBoxTestTitle.Size = new Size(391, 27);
            textBoxTestTitle.TabIndex = 21;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(202, 304);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(394, 93);
            textBoxDescription.TabIndex = 22;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDescription.Location = new Point(56, 328);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(138, 31);
            labelDescription.TabIndex = 23;
            labelDescription.Text = "Description";
            // 
            // frmUpdateTestType
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 542);
            Controls.Add(labelDescription);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxTestTitle);
            Controls.Add(buttonClose);
            Controls.Add(labelFees);
            Controls.Add(labelTitle);
            Controls.Add(buttonSave);
            Controls.Add(textBoxFees);
            Controls.Add(textBoxTitle);
            Controls.Add(labelTestIDR);
            Controls.Add(labelTestID);
            Controls.Add(labelUpdateApplicationType);
            Name = "frmUpdateTestType";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmUpdateTestType";
            Load += frmUpdateTestType_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonClose;
        private Label labelFees;
        private Label labelTitle;
        private Button buttonSave;
        private TextBox textBoxFees;
        private TextBox textBoxTitle;
        private Label labelTestIDR;
        private Label labelTestID;
        private Label labelUpdateApplicationType;
        private TextBox textBoxTestTitle;
        private TextBox textBoxDescription;
        private Label labelDescription;
    }
}