namespace DVLDPresentationLayer
{
    partial class FrmMangeApplicationTypeList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMangeApplicationTypeList));
            pictureBoxApplicationTypes = new PictureBox();
            labelMangeApplicationTypes = new Label();
            dataGridViewApplicationTypes = new DataGridView();
            contextmenustripEditApplicationTypes = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            buttonClose = new Button();
            labelApplictionRecord = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxApplicationTypes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewApplicationTypes).BeginInit();
            contextmenustripEditApplicationTypes.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxApplicationTypes
            // 
            pictureBoxApplicationTypes.Image = (Image)resources.GetObject("pictureBoxApplicationTypes.Image");
            pictureBoxApplicationTypes.Location = new Point(379, 11);
            pictureBoxApplicationTypes.Name = "pictureBoxApplicationTypes";
            pictureBoxApplicationTypes.Size = new Size(180, 172);
            pictureBoxApplicationTypes.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxApplicationTypes.TabIndex = 0;
            pictureBoxApplicationTypes.TabStop = false;
            // 
            // labelMangeApplicationTypes
            // 
            labelMangeApplicationTypes.AutoSize = true;
            labelMangeApplicationTypes.Font = new Font("Microsoft YaHei UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMangeApplicationTypes.ForeColor = Color.IndianRed;
            labelMangeApplicationTypes.Location = new Point(237, 202);
            labelMangeApplicationTypes.Name = "labelMangeApplicationTypes";
            labelMangeApplicationTypes.Size = new Size(459, 45);
            labelMangeApplicationTypes.TabIndex = 1;
            labelMangeApplicationTypes.Text = "Mange Application Types";
            // 
            // dataGridViewApplicationTypes
            // 
            dataGridViewApplicationTypes.AllowUserToAddRows = false;
            dataGridViewApplicationTypes.AllowUserToDeleteRows = false;
            dataGridViewApplicationTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewApplicationTypes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewApplicationTypes.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewApplicationTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewApplicationTypes.ContextMenuStrip = contextmenustripEditApplicationTypes;
            dataGridViewApplicationTypes.GridColor = SystemColors.ButtonShadow;
            dataGridViewApplicationTypes.Location = new Point(12, 266);
            dataGridViewApplicationTypes.Name = "dataGridViewApplicationTypes";
            dataGridViewApplicationTypes.RowHeadersWidth = 51;
            dataGridViewApplicationTypes.Size = new Size(886, 426);
            dataGridViewApplicationTypes.TabIndex = 2;
            // 
            // contextmenustripEditApplicationTypes
            // 
            contextmenustripEditApplicationTypes.ImageScalingSize = new Size(20, 20);
            contextmenustripEditApplicationTypes.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem });
            contextmenustripEditApplicationTypes.Name = "contextmenustripEditApplicationTypes";
            contextmenustripEditApplicationTypes.Size = new Size(117, 32);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editToolStripMenuItem.Image = (Image)resources.GetObject("editToolStripMenuItem.Image");
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(116, 28);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // buttonClose
            // 
            buttonClose.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonClose.Image = (Image)resources.GetObject("buttonClose.Image");
            buttonClose.ImageAlign = ContentAlignment.MiddleLeft;
            buttonClose.Location = new Point(732, 707);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(140, 57);
            buttonClose.TabIndex = 3;
            buttonClose.Text = "Close";
            buttonClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // labelApplictionRecord
            // 
            labelApplictionRecord.AutoSize = true;
            labelApplictionRecord.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelApplictionRecord.Location = new Point(57, 723);
            labelApplictionRecord.Name = "labelApplictionRecord";
            labelApplictionRecord.Size = new Size(48, 27);
            labelApplictionRecord.TabIndex = 4;
            labelApplictionRecord.Text = "????";
            // 
            // FrmApplicationTypes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 775);
            Controls.Add(labelApplictionRecord);
            Controls.Add(buttonClose);
            Controls.Add(dataGridViewApplicationTypes);
            Controls.Add(labelMangeApplicationTypes);
            Controls.Add(pictureBoxApplicationTypes);
            Name = "FrmApplicationTypes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmApplicationTypes";
            Load += FrmApplicationTypes_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxApplicationTypes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewApplicationTypes).EndInit();
            contextmenustripEditApplicationTypes.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxApplicationTypes;
        private Label labelMangeApplicationTypes;
        private DataGridView dataGridViewApplicationTypes;
        private Button buttonClose;
        private Label labelApplictionRecord;
        private ContextMenuStrip contextmenustripEditApplicationTypes;
        private ToolStripMenuItem editToolStripMenuItem;
    }
}