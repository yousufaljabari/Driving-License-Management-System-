namespace DVLDPresentationLayer.Tests
{
    partial class frmMangeTestTypesList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMangeTestTypesList));
            labelTestRecord = new Label();
            buttonClose = new Button();
            dataGridViewTestTypes = new DataGridView();
            labelMangeTestTypes = new Label();
            pictureBoxTestTypes = new PictureBox();
            contextMenuStripTestType = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTestTypes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTestTypes).BeginInit();
            contextMenuStripTestType.SuspendLayout();
            SuspendLayout();
            // 
            // labelTestRecord
            // 
            labelTestRecord.AutoSize = true;
            labelTestRecord.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTestRecord.Location = new Point(24, 733);
            labelTestRecord.Name = "labelTestRecord";
            labelTestRecord.Size = new Size(48, 27);
            labelTestRecord.TabIndex = 9;
            labelTestRecord.Text = "????";
            // 
            // buttonClose
            // 
            buttonClose.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonClose.Image = (Image)resources.GetObject("buttonClose.Image");
            buttonClose.ImageAlign = ContentAlignment.MiddleLeft;
            buttonClose.Location = new Point(737, 718);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(140, 57);
            buttonClose.TabIndex = 8;
            buttonClose.Text = "Close";
            buttonClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // dataGridViewTestTypes
            // 
            dataGridViewTestTypes.AllowUserToAddRows = false;
            dataGridViewTestTypes.AllowUserToDeleteRows = false;
            dataGridViewTestTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTestTypes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewTestTypes.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewTestTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTestTypes.ContextMenuStrip = contextMenuStripTestType;
            dataGridViewTestTypes.GridColor = SystemColors.ButtonShadow;
            dataGridViewTestTypes.Location = new Point(11, 276);
            dataGridViewTestTypes.Name = "dataGridViewTestTypes";
            dataGridViewTestTypes.RowHeadersWidth = 51;
            dataGridViewTestTypes.Size = new Size(886, 426);
            dataGridViewTestTypes.TabIndex = 7;
            // 
            // labelMangeTestTypes
            // 
            labelMangeTestTypes.AutoSize = true;
            labelMangeTestTypes.Font = new Font("Microsoft YaHei UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMangeTestTypes.ForeColor = Color.IndianRed;
            labelMangeTestTypes.Location = new Point(294, 210);
            labelMangeTestTypes.Name = "labelMangeTestTypes";
            labelMangeTestTypes.Size = new Size(333, 45);
            labelMangeTestTypes.TabIndex = 6;
            labelMangeTestTypes.Text = "Mange Test Types";
            // 
            // pictureBoxTestTypes
            // 
            pictureBoxTestTypes.Image = (Image)resources.GetObject("pictureBoxTestTypes.Image");
            pictureBoxTestTypes.Location = new Point(370, 19);
            pictureBoxTestTypes.Name = "pictureBoxTestTypes";
            pictureBoxTestTypes.Size = new Size(172, 172);
            pictureBoxTestTypes.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxTestTypes.TabIndex = 5;
            pictureBoxTestTypes.TabStop = false;
            // 
            // contextMenuStripTestType
            // 
            contextMenuStripTestType.ImageScalingSize = new Size(20, 20);
            contextMenuStripTestType.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem });
            contextMenuStripTestType.Name = "contextMenuStripTestType";
            contextMenuStripTestType.Size = new Size(215, 90);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editToolStripMenuItem.Image = (Image)resources.GetObject("editToolStripMenuItem.Image");
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(214, 30);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // frmMangeTestTypesList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 787);
            Controls.Add(labelTestRecord);
            Controls.Add(buttonClose);
            Controls.Add(dataGridViewTestTypes);
            Controls.Add(labelMangeTestTypes);
            Controls.Add(pictureBoxTestTypes);
            Name = "frmMangeTestTypesList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMangeTestTypesList";
            Load += frmMangeTestTypesList_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTestTypes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTestTypes).EndInit();
            contextMenuStripTestType.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTestRecord;
        private Button buttonClose;
        private DataGridView dataGridViewTestTypes;
        private Label labelMangeTestTypes;
        private PictureBox pictureBoxTestTypes;
        private ContextMenuStrip contextMenuStripTestType;
        private ToolStripMenuItem editToolStripMenuItem;
    }
}