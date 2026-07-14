namespace DVLDPresentationLayer.People.Controls
{
    partial class UserControlPersonCardWithFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlPersonCardWithFilter));
            groupBoxFliterBy = new GroupBox();
            buttonAddNewPerson = new Button();
            textBoxFindBy = new TextBox();
            buttonSearch = new Button();
            comboBoxFIndBy = new ComboBox();
            labelFilterBy = new Label();
            userControlPersonCard1 = new DVLDPresentationLayer.UserControls.UserControlPersonCard();
            buttonNext = new Button();
            groupBoxFliterBy.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxFliterBy
            // 
            groupBoxFliterBy.Controls.Add(buttonAddNewPerson);
            groupBoxFliterBy.Controls.Add(textBoxFindBy);
            groupBoxFliterBy.Controls.Add(buttonSearch);
            groupBoxFliterBy.Controls.Add(comboBoxFIndBy);
            groupBoxFliterBy.Controls.Add(labelFilterBy);
            groupBoxFliterBy.Location = new Point(255, 13);
            groupBoxFliterBy.Name = "groupBoxFliterBy";
            groupBoxFliterBy.Size = new Size(713, 97);
            groupBoxFliterBy.TabIndex = 1;
            groupBoxFliterBy.TabStop = false;
            groupBoxFliterBy.Text = "Filter";
            // 
            // buttonAddNewPerson
            // 
            buttonAddNewPerson.BackgroundImage = (Image)resources.GetObject("buttonAddNewPerson.BackgroundImage");
            buttonAddNewPerson.BackgroundImageLayout = ImageLayout.Zoom;
            buttonAddNewPerson.Location = new Point(537, 35);
            buttonAddNewPerson.Name = "buttonAddNewPerson";
            buttonAddNewPerson.Size = new Size(47, 40);
            buttonAddNewPerson.TabIndex = 3;
            buttonAddNewPerson.UseVisualStyleBackColor = true;
            buttonAddNewPerson.Click += buttonAddNewPerson_Click;
            // 
            // textBoxFindBy
            // 
            textBoxFindBy.Location = new Point(290, 40);
            textBoxFindBy.Name = "textBoxFindBy";
            textBoxFindBy.Size = new Size(183, 27);
            textBoxFindBy.TabIndex = 2;
            textBoxFindBy.TextChanged += textBoxFindBy_TextChanged_1;
            textBoxFindBy.KeyPress += textBoxFindBy_KeyPress;
            // 
            // buttonSearch
            // 
            buttonSearch.BackgroundImage = (Image)resources.GetObject("buttonSearch.BackgroundImage");
            buttonSearch.BackgroundImageLayout = ImageLayout.Zoom;
            buttonSearch.Location = new Point(486, 35);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(45, 40);
            buttonSearch.TabIndex = 2;
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // comboBoxFIndBy
            // 
            comboBoxFIndBy.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFIndBy.FormattingEnabled = true;
            comboBoxFIndBy.Items.AddRange(new object[] { "Person_ID", "National_NO" });
            comboBoxFIndBy.Location = new Point(123, 40);
            comboBoxFIndBy.Name = "comboBoxFIndBy";
            comboBoxFIndBy.Size = new Size(151, 28);
            comboBoxFIndBy.TabIndex = 2;
            // 
            // labelFilterBy
            // 
            labelFilterBy.AutoSize = true;
            labelFilterBy.Location = new Point(44, 43);
            labelFilterBy.Name = "labelFilterBy";
            labelFilterBy.Size = new Size(57, 20);
            labelFilterBy.TabIndex = 2;
            labelFilterBy.Text = "Find By";
            // 
            // userControlPersonCard1
            // 
            userControlPersonCard1.Location = new Point(34, 103);
            userControlPersonCard1.Name = "userControlPersonCard1";
            userControlPersonCard1.Size = new Size(1165, 639);
            userControlPersonCard1.TabIndex = 0;
            // 
            // buttonNext
            // 
            buttonNext.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonNext.Image = (Image)resources.GetObject("buttonNext.Image");
            buttonNext.ImageAlign = ContentAlignment.MiddleLeft;
            buttonNext.Location = new Point(1021, 665);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(129, 46);
            buttonNext.TabIndex = 2;
            buttonNext.Text = "Next";
            buttonNext.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // UserControlPersonCardWithFilter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonNext);
            Controls.Add(groupBoxFliterBy);
            Controls.Add(userControlPersonCard1);
            Name = "UserControlPersonCardWithFilter";
            Size = new Size(1234, 756);
            groupBoxFliterBy.ResumeLayout(false);
            groupBoxFliterBy.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBoxFliterBy;
        private Label labelFilterBy;
        private TextBox textBoxFindBy;
        private Button buttonSearch;
        private ComboBox comboBoxFIndBy;
        private Button buttonAddNewPerson;
        private UserControls.UserControlPersonCard userControlPersonCard1;
        private Button buttonNext;
    }
}
