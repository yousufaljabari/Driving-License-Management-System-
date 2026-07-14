namespace DVLDPresentationLayer.PeopleScreens
{
    partial class frmAddEditPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditPerson));
            labelTitleMode = new Label();
            labelPersonIDText = new Label();
            labelPersonID = new Label();
            pictureBoxPersonID = new PictureBox();
            groupBoxAddEditForm = new GroupBox();
            groupBoxGender = new GroupBox();
            pictureBoxFemale = new PictureBox();
            pictureBoxMale = new PictureBox();
            radioButtonFemale = new RadioButton();
            radioButtonMale = new RadioButton();
            linkLabelSetImage = new LinkLabel();
            btnSave = new Button();
            btnExit = new Button();
            pictureBoxPersonImage = new PictureBox();
            comboBoxCountries = new ComboBox();
            dateTimePickerDateofBirth = new DateTimePicker();
            pictureBoxCountryIcon = new PictureBox();
            pictureBoxPhoneICon = new PictureBox();
            pictureBoxDateOfBirthIcon = new PictureBox();
            textBoxPhone = new TextBox();
            labelCountryText = new Label();
            labelPhoneText = new Label();
            textBoxAddress = new TextBox();
            textBoxEmail = new TextBox();
            pictureBoxAddressIcon = new PictureBox();
            pictureBoxEmailICon = new PictureBox();
            pictureBoxGenderIcon = new PictureBox();
            labelDateOfBirthText = new Label();
            textBoxNationalNo = new TextBox();
            pictureBoxNationalNo = new PictureBox();
            textBoxLastName = new TextBox();
            textBoxThirdName = new TextBox();
            textBoxSecondName = new TextBox();
            textBoxFirstName = new TextBox();
            pictureBoxName = new PictureBox();
            labelLastNameText = new Label();
            labelThirdNameText = new Label();
            labelSecondNameText = new Label();
            labelFirstNameText = new Label();
            labelAdderssText = new Label();
            labelEmailText = new Label();
            labelGenderText = new Label();
            labelNationalNoText = new Label();
            labelNameText = new Label();
            errorProviderForAddEditForm = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxPersonID).BeginInit();
            groupBoxAddEditForm.SuspendLayout();
            groupBoxGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFemale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPersonImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCountryIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoneICon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDateOfBirthIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAddressIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEmailICon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGenderIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNationalNo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderForAddEditForm).BeginInit();
            SuspendLayout();
            // 
            // labelTitleMode
            // 
            labelTitleMode.AutoSize = true;
            labelTitleMode.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitleMode.ForeColor = Color.Brown;
            labelTitleMode.Location = new Point(368, 26);
            labelTitleMode.Name = "labelTitleMode";
            labelTitleMode.Size = new Size(96, 40);
            labelTitleMode.TabIndex = 0;
            labelTitleMode.Text = "????? ";
            labelTitleMode.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelPersonIDText
            // 
            labelPersonIDText.AutoSize = true;
            labelPersonIDText.Font = new Font("Microsoft YaHei", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPersonIDText.Location = new Point(34, 88);
            labelPersonIDText.Name = "labelPersonIDText";
            labelPersonIDText.Size = new Size(121, 30);
            labelPersonIDText.TabIndex = 1;
            labelPersonIDText.Text = "Person ID";
            // 
            // labelPersonID
            // 
            labelPersonID.AutoSize = true;
            labelPersonID.Font = new Font("Microsoft Uighur", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPersonID.Location = new Point(238, 89);
            labelPersonID.Name = "labelPersonID";
            labelPersonID.Size = new Size(43, 31);
            labelPersonID.TabIndex = 2;
            labelPersonID.Text = "N/A";
            // 
            // pictureBoxPersonID
            // 
            pictureBoxPersonID.Image = (Image)resources.GetObject("pictureBoxPersonID.Image");
            pictureBoxPersonID.Location = new Point(182, 88);
            pictureBoxPersonID.Name = "pictureBoxPersonID";
            pictureBoxPersonID.Size = new Size(37, 30);
            pictureBoxPersonID.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPersonID.TabIndex = 3;
            pictureBoxPersonID.TabStop = false;
            // 
            // groupBoxAddEditForm
            // 
            groupBoxAddEditForm.Controls.Add(groupBoxGender);
            groupBoxAddEditForm.Controls.Add(linkLabelSetImage);
            groupBoxAddEditForm.Controls.Add(btnSave);
            groupBoxAddEditForm.Controls.Add(btnExit);
            groupBoxAddEditForm.Controls.Add(pictureBoxPersonImage);
            groupBoxAddEditForm.Controls.Add(comboBoxCountries);
            groupBoxAddEditForm.Controls.Add(dateTimePickerDateofBirth);
            groupBoxAddEditForm.Controls.Add(pictureBoxCountryIcon);
            groupBoxAddEditForm.Controls.Add(pictureBoxPhoneICon);
            groupBoxAddEditForm.Controls.Add(pictureBoxDateOfBirthIcon);
            groupBoxAddEditForm.Controls.Add(textBoxPhone);
            groupBoxAddEditForm.Controls.Add(labelCountryText);
            groupBoxAddEditForm.Controls.Add(labelPhoneText);
            groupBoxAddEditForm.Controls.Add(textBoxAddress);
            groupBoxAddEditForm.Controls.Add(textBoxEmail);
            groupBoxAddEditForm.Controls.Add(pictureBoxAddressIcon);
            groupBoxAddEditForm.Controls.Add(pictureBoxEmailICon);
            groupBoxAddEditForm.Controls.Add(pictureBoxGenderIcon);
            groupBoxAddEditForm.Controls.Add(labelDateOfBirthText);
            groupBoxAddEditForm.Controls.Add(textBoxNationalNo);
            groupBoxAddEditForm.Controls.Add(pictureBoxNationalNo);
            groupBoxAddEditForm.Controls.Add(textBoxLastName);
            groupBoxAddEditForm.Controls.Add(textBoxThirdName);
            groupBoxAddEditForm.Controls.Add(textBoxSecondName);
            groupBoxAddEditForm.Controls.Add(textBoxFirstName);
            groupBoxAddEditForm.Controls.Add(pictureBoxName);
            groupBoxAddEditForm.Controls.Add(labelLastNameText);
            groupBoxAddEditForm.Controls.Add(labelThirdNameText);
            groupBoxAddEditForm.Controls.Add(labelSecondNameText);
            groupBoxAddEditForm.Controls.Add(labelFirstNameText);
            groupBoxAddEditForm.Controls.Add(labelAdderssText);
            groupBoxAddEditForm.Controls.Add(labelEmailText);
            groupBoxAddEditForm.Controls.Add(labelGenderText);
            groupBoxAddEditForm.Controls.Add(labelNationalNoText);
            groupBoxAddEditForm.Controls.Add(labelNameText);
            groupBoxAddEditForm.Location = new Point(-2, 148);
            groupBoxAddEditForm.Name = "groupBoxAddEditForm";
            groupBoxAddEditForm.Size = new Size(1028, 477);
            groupBoxAddEditForm.TabIndex = 4;
            groupBoxAddEditForm.TabStop = false;
            // 
            // groupBoxGender
            // 
            groupBoxGender.Controls.Add(pictureBoxFemale);
            groupBoxGender.Controls.Add(pictureBoxMale);
            groupBoxGender.Controls.Add(radioButtonFemale);
            groupBoxGender.Controls.Add(radioButtonMale);
            groupBoxGender.Location = new Point(190, 166);
            groupBoxGender.Name = "groupBoxGender";
            groupBoxGender.Size = new Size(288, 45);
            groupBoxGender.TabIndex = 37;
            groupBoxGender.TabStop = false;
            // 
            // pictureBoxFemale
            // 
            pictureBoxFemale.Image = (Image)resources.GetObject("pictureBoxFemale.Image");
            pictureBoxFemale.Location = new Point(164, 10);
            pictureBoxFemale.Name = "pictureBoxFemale";
            pictureBoxFemale.Size = new Size(28, 30);
            pictureBoxFemale.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFemale.TabIndex = 39;
            pictureBoxFemale.TabStop = false;
            // 
            // pictureBoxMale
            // 
            pictureBoxMale.Image = (Image)resources.GetObject("pictureBoxMale.Image");
            pictureBoxMale.Location = new Point(31, 13);
            pictureBoxMale.Name = "pictureBoxMale";
            pictureBoxMale.Size = new Size(28, 30);
            pictureBoxMale.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMale.TabIndex = 38;
            pictureBoxMale.TabStop = false;
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.Location = new Point(198, 14);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(78, 24);
            radioButtonFemale.TabIndex = 1;
            radioButtonFemale.TabStop = true;
            radioButtonFemale.Tag = "1";
            radioButtonFemale.Text = "Female";
            radioButtonFemale.UseVisualStyleBackColor = true;
            radioButtonFemale.CheckedChanged += radioButtonFemale_CheckedChanged_1;
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.Location = new Point(72, 15);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(63, 24);
            radioButtonMale.TabIndex = 0;
            radioButtonMale.TabStop = true;
            radioButtonMale.Tag = "0";
            radioButtonMale.Text = "Male";
            radioButtonMale.UseVisualStyleBackColor = true;
            radioButtonMale.CheckedChanged += radioButtonMale_CheckedChanged_1;
            // 
            // linkLabelSetImage
            // 
            linkLabelSetImage.AutoSize = true;
            linkLabelSetImage.Location = new Point(846, 386);
            linkLabelSetImage.Name = "linkLabelSetImage";
            linkLabelSetImage.Size = new Size(76, 20);
            linkLabelSetImage.TabIndex = 36;
            linkLabelSetImage.TabStop = true;
            linkLabelSetImage.Text = "Set Image";
            linkLabelSetImage.LinkClicked += linkLabelSetImage_LinkClicked;
            // 
            // btnSave
            // 
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(570, 386);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(149, 52);
            btnSave.TabIndex = 35;
            btnSave.Text = "Save";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnExit
            // 
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(405, 386);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(137, 52);
            btnExit.TabIndex = 34;
            btnExit.Text = "Exit";
            btnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBoxPersonImage
            // 
            pictureBoxPersonImage.Location = new Point(766, 142);
            pictureBoxPersonImage.Name = "pictureBoxPersonImage";
            pictureBoxPersonImage.Size = new Size(238, 223);
            pictureBoxPersonImage.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPersonImage.TabIndex = 33;
            pictureBoxPersonImage.TabStop = false;
            // 
            // comboBoxCountries
            // 
            comboBoxCountries.FormattingEnabled = true;
            comboBoxCountries.Location = new Point(595, 224);
            comboBoxCountries.Name = "comboBoxCountries";
            comboBoxCountries.Size = new Size(151, 28);
            comboBoxCountries.TabIndex = 32;
            // 
            // dateTimePickerDateofBirth
            // 
            dateTimePickerDateofBirth.CustomFormat = "dd/MM/yyyy";
            dateTimePickerDateofBirth.Format = DateTimePickerFormat.Custom;
            dateTimePickerDateofBirth.Location = new Point(599, 130);
            dateTimePickerDateofBirth.Name = "dateTimePickerDateofBirth";
            dateTimePickerDateofBirth.Size = new Size(147, 27);
            dateTimePickerDateofBirth.TabIndex = 31;
            // 
            // pictureBoxCountryIcon
            // 
            pictureBoxCountryIcon.Image = (Image)resources.GetObject("pictureBoxCountryIcon.Image");
            pictureBoxCountryIcon.Location = new Point(558, 223);
            pictureBoxCountryIcon.Name = "pictureBoxCountryIcon";
            pictureBoxCountryIcon.Size = new Size(28, 26);
            pictureBoxCountryIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCountryIcon.TabIndex = 30;
            pictureBoxCountryIcon.TabStop = false;
            // 
            // pictureBoxPhoneICon
            // 
            pictureBoxPhoneICon.Image = (Image)resources.GetObject("pictureBoxPhoneICon.Image");
            pictureBoxPhoneICon.Location = new Point(558, 176);
            pictureBoxPhoneICon.Name = "pictureBoxPhoneICon";
            pictureBoxPhoneICon.Size = new Size(28, 26);
            pictureBoxPhoneICon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPhoneICon.TabIndex = 29;
            pictureBoxPhoneICon.TabStop = false;
            // 
            // pictureBoxDateOfBirthIcon
            // 
            pictureBoxDateOfBirthIcon.Image = (Image)resources.GetObject("pictureBoxDateOfBirthIcon.Image");
            pictureBoxDateOfBirthIcon.Location = new Point(560, 130);
            pictureBoxDateOfBirthIcon.Name = "pictureBoxDateOfBirthIcon";
            pictureBoxDateOfBirthIcon.Size = new Size(28, 26);
            pictureBoxDateOfBirthIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxDateOfBirthIcon.TabIndex = 28;
            pictureBoxDateOfBirthIcon.TabStop = false;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(598, 176);
            textBoxPhone.Multiline = true;
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(148, 25);
            textBoxPhone.TabIndex = 27;
            // 
            // labelCountryText
            // 
            labelCountryText.AutoSize = true;
            labelCountryText.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCountryText.Location = new Point(468, 219);
            labelCountryText.Name = "labelCountryText";
            labelCountryText.Size = new Size(80, 25);
            labelCountryText.TabIndex = 26;
            labelCountryText.Text = "Country";
            // 
            // labelPhoneText
            // 
            labelPhoneText.AutoSize = true;
            labelPhoneText.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPhoneText.Location = new Point(477, 175);
            labelPhoneText.Name = "labelPhoneText";
            labelPhoneText.Size = new Size(65, 25);
            labelPhoneText.TabIndex = 25;
            labelPhoneText.Text = "Phone";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(216, 273);
            textBoxAddress.Multiline = true;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(471, 92);
            textBoxAddress.TabIndex = 24;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(207, 225);
            textBoxEmail.Multiline = true;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(135, 25);
            textBoxEmail.TabIndex = 23;
            // 
            // pictureBoxAddressIcon
            // 
            pictureBoxAddressIcon.Image = (Image)resources.GetObject("pictureBoxAddressIcon.Image");
            pictureBoxAddressIcon.Location = new Point(156, 273);
            pictureBoxAddressIcon.Name = "pictureBoxAddressIcon";
            pictureBoxAddressIcon.Size = new Size(28, 30);
            pictureBoxAddressIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAddressIcon.TabIndex = 18;
            pictureBoxAddressIcon.TabStop = false;
            // 
            // pictureBoxEmailICon
            // 
            pictureBoxEmailICon.Image = (Image)resources.GetObject("pictureBoxEmailICon.Image");
            pictureBoxEmailICon.Location = new Point(156, 219);
            pictureBoxEmailICon.Name = "pictureBoxEmailICon";
            pictureBoxEmailICon.Size = new Size(28, 30);
            pictureBoxEmailICon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxEmailICon.TabIndex = 17;
            pictureBoxEmailICon.TabStop = false;
            // 
            // pictureBoxGenderIcon
            // 
            pictureBoxGenderIcon.Image = (Image)resources.GetObject("pictureBoxGenderIcon.Image");
            pictureBoxGenderIcon.Location = new Point(155, 176);
            pictureBoxGenderIcon.Name = "pictureBoxGenderIcon";
            pictureBoxGenderIcon.Size = new Size(28, 30);
            pictureBoxGenderIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxGenderIcon.TabIndex = 16;
            pictureBoxGenderIcon.TabStop = false;
            // 
            // labelDateOfBirthText
            // 
            labelDateOfBirthText.AutoSize = true;
            labelDateOfBirthText.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDateOfBirthText.Location = new Point(423, 131);
            labelDateOfBirthText.Name = "labelDateOfBirthText";
            labelDateOfBirthText.Size = new Size(122, 25);
            labelDateOfBirthText.TabIndex = 15;
            labelDateOfBirthText.Text = "Date Of Birth";
            // 
            // textBoxNationalNo
            // 
            textBoxNationalNo.Location = new Point(207, 130);
            textBoxNationalNo.Multiline = true;
            textBoxNationalNo.Name = "textBoxNationalNo";
            textBoxNationalNo.Size = new Size(157, 25);
            textBoxNationalNo.TabIndex = 14;
            // 
            // pictureBoxNationalNo
            // 
            pictureBoxNationalNo.Image = (Image)resources.GetObject("pictureBoxNationalNo.Image");
            pictureBoxNationalNo.Location = new Point(158, 125);
            pictureBoxNationalNo.Name = "pictureBoxNationalNo";
            pictureBoxNationalNo.Size = new Size(28, 30);
            pictureBoxNationalNo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxNationalNo.TabIndex = 13;
            pictureBoxNationalNo.TabStop = false;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(766, 78);
            textBoxLastName.Multiline = true;
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(186, 25);
            textBoxLastName.TabIndex = 12;
            // 
            // textBoxThirdName
            // 
            textBoxThirdName.Location = new Point(570, 79);
            textBoxThirdName.Multiline = true;
            textBoxThirdName.Name = "textBoxThirdName";
            textBoxThirdName.Size = new Size(170, 25);
            textBoxThirdName.TabIndex = 11;
            // 
            // textBoxSecondName
            // 
            textBoxSecondName.Location = new Point(379, 81);
            textBoxSecondName.Multiline = true;
            textBoxSecondName.Name = "textBoxSecondName";
            textBoxSecondName.Size = new Size(172, 25);
            textBoxSecondName.TabIndex = 10;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(207, 82);
            textBoxFirstName.Multiline = true;
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(157, 25);
            textBoxFirstName.TabIndex = 9;
            // 
            // pictureBoxName
            // 
            pictureBoxName.Image = (Image)resources.GetObject("pictureBoxName.Image");
            pictureBoxName.Location = new Point(156, 81);
            pictureBoxName.Name = "pictureBoxName";
            pictureBoxName.Size = new Size(28, 30);
            pictureBoxName.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxName.TabIndex = 5;
            pictureBoxName.TabStop = false;
            // 
            // labelLastNameText
            // 
            labelLastNameText.AutoSize = true;
            labelLastNameText.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLastNameText.Location = new Point(836, 23);
            labelLastNameText.Name = "labelLastNameText";
            labelLastNameText.Size = new Size(45, 25);
            labelLastNameText.TabIndex = 8;
            labelLastNameText.Text = "Last";
            // 
            // labelThirdNameText
            // 
            labelThirdNameText.AutoSize = true;
            labelThirdNameText.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelThirdNameText.Location = new Point(631, 23);
            labelThirdNameText.Name = "labelThirdNameText";
            labelThirdNameText.Size = new Size(55, 25);
            labelThirdNameText.TabIndex = 7;
            labelThirdNameText.Text = "Third";
            // 
            // labelSecondNameText
            // 
            labelSecondNameText.AutoSize = true;
            labelSecondNameText.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSecondNameText.Location = new Point(424, 23);
            labelSecondNameText.Name = "labelSecondNameText";
            labelSecondNameText.Size = new Size(73, 25);
            labelSecondNameText.TabIndex = 6;
            labelSecondNameText.Text = "Second";
            // 
            // labelFirstNameText
            // 
            labelFirstNameText.AutoSize = true;
            labelFirstNameText.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFirstNameText.Location = new Point(252, 23);
            labelFirstNameText.Name = "labelFirstNameText";
            labelFirstNameText.Size = new Size(48, 25);
            labelFirstNameText.TabIndex = 5;
            labelFirstNameText.Text = "First";
            // 
            // labelAdderssText
            // 
            labelAdderssText.AutoSize = true;
            labelAdderssText.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAdderssText.Location = new Point(60, 273);
            labelAdderssText.Name = "labelAdderssText";
            labelAdderssText.Size = new Size(80, 25);
            labelAdderssText.TabIndex = 4;
            labelAdderssText.Text = "Address";
            // 
            // labelEmailText
            // 
            labelEmailText.AutoSize = true;
            labelEmailText.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEmailText.Location = new Point(58, 224);
            labelEmailText.Name = "labelEmailText";
            labelEmailText.Size = new Size(58, 25);
            labelEmailText.TabIndex = 3;
            labelEmailText.Text = "Email";
            // 
            // labelGenderText
            // 
            labelGenderText.AutoSize = true;
            labelGenderText.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelGenderText.Location = new Point(55, 174);
            labelGenderText.Name = "labelGenderText";
            labelGenderText.Size = new Size(74, 25);
            labelGenderText.TabIndex = 2;
            labelGenderText.Text = "Gender";
            // 
            // labelNationalNoText
            // 
            labelNationalNoText.AutoSize = true;
            labelNationalNoText.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNationalNoText.Location = new Point(34, 126);
            labelNationalNoText.Name = "labelNationalNoText";
            labelNationalNoText.Size = new Size(115, 25);
            labelNationalNoText.TabIndex = 1;
            labelNationalNoText.Text = "National No";
            // 
            // labelNameText
            // 
            labelNameText.AutoSize = true;
            labelNameText.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNameText.Location = new Point(54, 79);
            labelNameText.Name = "labelNameText";
            labelNameText.Size = new Size(62, 25);
            labelNameText.TabIndex = 0;
            labelNameText.Text = "Name";
            // 
            // errorProviderForAddEditForm
            // 
            errorProviderForAddEditForm.ContainerControl = this;
            // 
            // frmAddEditPerson
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnSave;
            ClientSize = new Size(1055, 637);
            Controls.Add(groupBoxAddEditForm);
            Controls.Add(pictureBoxPersonID);
            Controls.Add(labelPersonID);
            Controls.Add(labelPersonIDText);
            Controls.Add(labelTitleMode);
            Name = "frmAddEditPerson";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmAddEditPerson";
            Load += frmAddEditPerson_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxPersonID).EndInit();
            groupBoxAddEditForm.ResumeLayout(false);
            groupBoxAddEditForm.PerformLayout();
            groupBoxGender.ResumeLayout(false);
            groupBoxGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFemale).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMale).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPersonImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCountryIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoneICon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDateOfBirthIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAddressIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEmailICon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGenderIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNationalNo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxName).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderForAddEditForm).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitleMode;
        private Label labelPersonIDText;
        private Label labelPersonID;
        private PictureBox pictureBoxPersonID;
        private GroupBox groupBoxAddEditForm;
        private Label labelAdderssText;
        private Label labelEmailText;
        private Label labelGenderText;
        private Label labelNationalNoText;
        private Label labelNameText;
        private Label labelLastNameText;
        private Label labelThirdNameText;
        private Label labelSecondNameText;
        private Label labelFirstNameText;
        private PictureBox pictureBoxName;
        private PictureBox pictureBoxNationalNo;
        private TextBox textBoxLastName;
        private TextBox textBoxThirdName;
        private TextBox textBoxSecondName;
        private TextBox textBoxFirstName;
        private TextBox textBoxNationalNo;
        private Label labelDateOfBirthText;
        private PictureBox pictureBoxAddressIcon;
        private PictureBox pictureBoxEmailICon;
        private PictureBox pictureBoxGenderIcon;
        private TextBox textBoxAddress;
        private TextBox textBoxEmail;
        private Label labelCountryText;
        private Label labelPhoneText;
        private PictureBox pictureBoxCountryIcon;
        private PictureBox pictureBoxPhoneICon;
        private PictureBox pictureBoxDateOfBirthIcon;
        private TextBox textBoxPhone;
        private DateTimePicker dateTimePickerDateofBirth;
        private PictureBox pictureBoxPersonImage;
        private ComboBox comboBoxCountries;
        private Button btnSave;
        private Button btnExit;
        private ErrorProvider errorProviderForAddEditForm;
        private LinkLabel linkLabelSetImage;
        private GroupBox groupBoxGender;
        private PictureBox pictureBoxFemale;
        private PictureBox pictureBoxMale;
        private RadioButton radioButtonFemale;
        private RadioButton radioButtonMale;
    }
}