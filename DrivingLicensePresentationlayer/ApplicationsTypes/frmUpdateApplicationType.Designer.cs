namespace DVLDPresentationLayer.Applications
{
    partial class frmUpdateApplicationType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateApplicationType));
            labelUpdateApplicationType = new Label();
            labelApplicationID = new Label();
            labelApplicationIDR = new Label();
            textBoxTitle = new TextBox();
            textBoxFees = new TextBox();
            buttonSave = new Button();
            labelTitle = new Label();
            labelFees = new Label();
            buttonClose = new Button();
            SuspendLayout();
            // 
            // labelUpdateApplicationType
            // 
            labelUpdateApplicationType.AutoSize = true;
            labelUpdateApplicationType.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUpdateApplicationType.ForeColor = Color.IndianRed;
            labelUpdateApplicationType.Location = new Point(155, 52);
            labelUpdateApplicationType.Name = "labelUpdateApplicationType";
            labelUpdateApplicationType.Size = new Size(501, 50);
            labelUpdateApplicationType.TabIndex = 0;
            labelUpdateApplicationType.Text = "Update Application Type";
            // 
            // labelApplicationID
            // 
            labelApplicationID.AutoSize = true;
            labelApplicationID.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelApplicationID.Location = new Point(146, 197);
            labelApplicationID.Name = "labelApplicationID";
            labelApplicationID.Size = new Size(38, 31);
            labelApplicationID.TabIndex = 1;
            labelApplicationID.Text = "ID";
            // 
            // labelApplicationIDR
            // 
            labelApplicationIDR.AutoSize = true;
            labelApplicationIDR.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelApplicationIDR.Location = new Point(245, 195);
            labelApplicationIDR.Name = "labelApplicationIDR";
            labelApplicationIDR.Size = new Size(74, 31);
            labelApplicationIDR.TabIndex = 4;
            labelApplicationIDR.Text = "??????";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(246, 263);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(391, 27);
            textBoxTitle.TabIndex = 5;
            // 
            // textBoxFees
            // 
            textBoxFees.Location = new Point(246, 323);
            textBoxFees.Name = "textBoxFees";
            textBoxFees.Size = new Size(390, 27);
            textBoxFees.TabIndex = 6;
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSave.Image = (Image)resources.GetObject("buttonSave.Image");
            buttonSave.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSave.Location = new Point(607, 371);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(158, 55);
            buttonSave.TabIndex = 7;
            buttonSave.Text = "Save";
            buttonSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(134, 258);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(62, 31);
            labelTitle.TabIndex = 9;
            labelTitle.Text = "Title";
            // 
            // labelFees
            // 
            labelFees.AutoSize = true;
            labelFees.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFees.Location = new Point(136, 319);
            labelFees.Name = "labelFees";
            labelFees.Size = new Size(60, 31);
            labelFees.TabIndex = 10;
            labelFees.Text = "Fees";
            // 
            // buttonClose
            // 
            buttonClose.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonClose.Image = (Image)resources.GetObject("buttonClose.Image");
            buttonClose.ImageAlign = ContentAlignment.MiddleLeft;
            buttonClose.Location = new Point(438, 371);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(149, 55);
            buttonClose.TabIndex = 11;
            buttonClose.Text = "Close";
            buttonClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // frmUpdateApplicationTypes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 435);
            Controls.Add(buttonClose);
            Controls.Add(labelFees);
            Controls.Add(labelTitle);
            Controls.Add(buttonSave);
            Controls.Add(textBoxFees);
            Controls.Add(textBoxTitle);
            Controls.Add(labelApplicationIDR);
            Controls.Add(labelApplicationID);
            Controls.Add(labelUpdateApplicationType);
            Name = "frmUpdateApplicationTypes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update Application Types";
            Load += frmUpdateApplicationTypes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUpdateApplicationType;
        private Label labelApplicationIDR;
        private Label labelApplicationID;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxTitle;
        private TextBox textBoxFees;
        private Button buttonSave;
        private Label labelTitle;
        private Label labelFees;
        private Button buttonClose;
    }
}