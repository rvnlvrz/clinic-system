namespace CSLabProject
{
    partial class StudentDetails
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
            this.guradian_grpbx = new System.Windows.Forms.GroupBox();
            this.LabelGuardianRel = new System.Windows.Forms.Label();
            this.comboBoxRelationship = new System.Windows.Forms.ComboBox();
            this.GRDN_textBoxMobileNum = new System.Windows.Forms.TextBox();
            this.LabelGuardianMobileNumber = new System.Windows.Forms.Label();
            this.GRDN_textBoxLandLine = new System.Windows.Forms.TextBox();
            this.LabelGuardianLandLineNumber = new System.Windows.Forms.Label();
            this.GRDN_textBoxFirstName = new System.Windows.Forms.TextBox();
            this.LabelGuardianFirstName = new System.Windows.Forms.Label();
            this.GRDN_textBoxLastName = new System.Windows.Forms.TextBox();
            this.LabelGuardianLastlName = new System.Windows.Forms.Label();
            this.GRDN_textBoxMI = new System.Windows.Forms.TextBox();
            this.LabelGuardianMI = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonCLR = new System.Windows.Forms.Button();
            this.student_grpbx = new System.Windows.Forms.GroupBox();
            this.STUD_textBoxMobileNum = new System.Windows.Forms.TextBox();
            this.LabelStudentMobileNumber = new System.Windows.Forms.Label();
            this.STUD_textBoxLandLine = new System.Windows.Forms.TextBox();
            this.LabelStudentLandLineNumber = new System.Windows.Forms.Label();
            this.STUD_textBoxYrLvl = new System.Windows.Forms.TextBox();
            this.LabelStudentYearLevel = new System.Windows.Forms.Label();
            this.STUD_textBoxProram = new System.Windows.Forms.TextBox();
            this.LabelStudentProgram = new System.Windows.Forms.Label();
            this.LabelStudentGender = new System.Windows.Forms.Label();
            this.STUD_radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.STUD_radioButtonMale = new System.Windows.Forms.RadioButton();
            this.STUD_textBoxFirstName = new System.Windows.Forms.TextBox();
            this.STUD_textBoxStudentNumber = new System.Windows.Forms.TextBox();
            this.LabelStudentNumber = new System.Windows.Forms.Label();
            this.STUD_textBoxAge = new System.Windows.Forms.TextBox();
            this.LabelStudentAge = new System.Windows.Forms.Label();
            this.LabelStudentFirstName = new System.Windows.Forms.Label();
            this.STUD_textBoxLastName = new System.Windows.Forms.TextBox();
            this.LabelStudentLastName = new System.Windows.Forms.Label();
            this.STUD_textBoxMI = new System.Windows.Forms.TextBox();
            this.LabelStudentMI = new System.Windows.Forms.Label();
            this.warning_label = new System.Windows.Forms.Label();
            this.buttonCNCL = new System.Windows.Forms.Button();
            this.guradian_grpbx.SuspendLayout();
            this.student_grpbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // guradian_grpbx
            // 
            this.guradian_grpbx.Controls.Add(this.LabelGuardianRel);
            this.guradian_grpbx.Controls.Add(this.comboBoxRelationship);
            this.guradian_grpbx.Controls.Add(this.GRDN_textBoxMobileNum);
            this.guradian_grpbx.Controls.Add(this.LabelGuardianMobileNumber);
            this.guradian_grpbx.Controls.Add(this.GRDN_textBoxLandLine);
            this.guradian_grpbx.Controls.Add(this.LabelGuardianLandLineNumber);
            this.guradian_grpbx.Controls.Add(this.GRDN_textBoxFirstName);
            this.guradian_grpbx.Controls.Add(this.LabelGuardianFirstName);
            this.guradian_grpbx.Controls.Add(this.GRDN_textBoxLastName);
            this.guradian_grpbx.Controls.Add(this.LabelGuardianLastlName);
            this.guradian_grpbx.Controls.Add(this.GRDN_textBoxMI);
            this.guradian_grpbx.Controls.Add(this.LabelGuardianMI);
            this.guradian_grpbx.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guradian_grpbx.Location = new System.Drawing.Point(32, 308);
            this.guradian_grpbx.Name = "guradian_grpbx";
            this.guradian_grpbx.Size = new System.Drawing.Size(596, 212);
            this.guradian_grpbx.TabIndex = 19;
            this.guradian_grpbx.TabStop = false;
            this.guradian_grpbx.Text = "GUARDIAN INFORMATION";
            // 
            // LabelGuardianRel
            // 
            this.LabelGuardianRel.AutoSize = true;
            this.LabelGuardianRel.Font = new System.Drawing.Font("Segoe UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGuardianRel.Location = new System.Drawing.Point(12, 145);
            this.LabelGuardianRel.Name = "LabelGuardianRel";
            this.LabelGuardianRel.Size = new System.Drawing.Size(103, 21);
            this.LabelGuardianRel.TabIndex = 10;
            this.LabelGuardianRel.Text = "Relationship";
            // 
            // comboBoxRelationship
            // 
            this.comboBoxRelationship.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRelationship.FormattingEnabled = true;
            this.comboBoxRelationship.Items.AddRange(new object[] {
            "FATHER",
            "MOTHER",
            "GRANDMOTHER",
            "GRANDFATHER",
            "AUNT",
            "UNCLE",
            "SISTER",
            "BROTHER",
            "OTHERS"});
            this.comboBoxRelationship.Location = new System.Drawing.Point(15, 166);
            this.comboBoxRelationship.Name = "comboBoxRelationship";
            this.comboBoxRelationship.Size = new System.Drawing.Size(234, 27);
            this.comboBoxRelationship.TabIndex = 17;
            // 
            // GRDN_textBoxMobileNum
            // 
            this.GRDN_textBoxMobileNum.Location = new System.Drawing.Point(15, 106);
            this.GRDN_textBoxMobileNum.Name = "GRDN_textBoxMobileNum";
            this.GRDN_textBoxMobileNum.Size = new System.Drawing.Size(232, 26);
            this.GRDN_textBoxMobileNum.TabIndex = 15;
            this.GRDN_textBoxMobileNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GRDN_textBoxMobileNum_KeyPress);
            this.GRDN_textBoxMobileNum.Leave += new System.EventHandler(this.GRDN_textBoxMobileNum_Leave);
            // 
            // LabelGuardianMobileNumber
            // 
            this.LabelGuardianMobileNumber.AutoSize = true;
            this.LabelGuardianMobileNumber.Font = new System.Drawing.Font("Segoe UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGuardianMobileNumber.Location = new System.Drawing.Point(10, 85);
            this.LabelGuardianMobileNumber.Name = "LabelGuardianMobileNumber";
            this.LabelGuardianMobileNumber.Size = new System.Drawing.Size(138, 21);
            this.LabelGuardianMobileNumber.TabIndex = 5;
            this.LabelGuardianMobileNumber.Text = "MOBILE NUMBER";
            // 
            // GRDN_textBoxLandLine
            // 
            this.GRDN_textBoxLandLine.Location = new System.Drawing.Point(262, 105);
            this.GRDN_textBoxLandLine.Name = "GRDN_textBoxLandLine";
            this.GRDN_textBoxLandLine.Size = new System.Drawing.Size(156, 26);
            this.GRDN_textBoxLandLine.TabIndex = 16;
            this.GRDN_textBoxLandLine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GRDN_textBoxLandLine_KeyPress);
            this.GRDN_textBoxLandLine.Leave += new System.EventHandler(this.GRDN_textBoxLandLine_Leave);
            // 
            // LabelGuardianLandLineNumber
            // 
            this.LabelGuardianLandLineNumber.AutoSize = true;
            this.LabelGuardianLandLineNumber.Font = new System.Drawing.Font("Segoe UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGuardianLandLineNumber.Location = new System.Drawing.Point(258, 82);
            this.LabelGuardianLandLineNumber.Name = "LabelGuardianLandLineNumber";
            this.LabelGuardianLandLineNumber.Size = new System.Drawing.Size(88, 21);
            this.LabelGuardianLandLineNumber.TabIndex = 7;
            this.LabelGuardianLandLineNumber.Text = "LANDLINE";
            // 
            // GRDN_textBoxFirstName
            // 
            this.GRDN_textBoxFirstName.Location = new System.Drawing.Point(15, 52);
            this.GRDN_textBoxFirstName.Name = "GRDN_textBoxFirstName";
            this.GRDN_textBoxFirstName.Size = new System.Drawing.Size(232, 26);
            this.GRDN_textBoxFirstName.TabIndex = 12;
            this.GRDN_textBoxFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GRDN_textBoxFirstName_KeyPress);
            this.GRDN_textBoxFirstName.Leave += new System.EventHandler(this.GRDN_textBoxFirstName_Leave);
            // 
            // LabelGuardianFirstName
            // 
            this.LabelGuardianFirstName.AutoSize = true;
            this.LabelGuardianFirstName.Font = new System.Drawing.Font("Segoe UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGuardianFirstName.Location = new System.Drawing.Point(10, 31);
            this.LabelGuardianFirstName.Name = "LabelGuardianFirstName";
            this.LabelGuardianFirstName.Size = new System.Drawing.Size(91, 21);
            this.LabelGuardianFirstName.TabIndex = 0;
            this.LabelGuardianFirstName.Text = "First Name";
            // 
            // GRDN_textBoxLastName
            // 
            this.GRDN_textBoxLastName.Location = new System.Drawing.Point(262, 51);
            this.GRDN_textBoxLastName.Name = "GRDN_textBoxLastName";
            this.GRDN_textBoxLastName.Size = new System.Drawing.Size(236, 26);
            this.GRDN_textBoxLastName.TabIndex = 13;
            this.GRDN_textBoxLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GRDN_textBoxLastName_KeyPress);
            this.GRDN_textBoxLastName.Leave += new System.EventHandler(this.GRDN_textBoxLastName_Leave);
            // 
            // LabelGuardianLastlName
            // 
            this.LabelGuardianLastlName.AutoSize = true;
            this.LabelGuardianLastlName.Font = new System.Drawing.Font("Segoe UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGuardianLastlName.Location = new System.Drawing.Point(258, 29);
            this.LabelGuardianLastlName.Name = "LabelGuardianLastlName";
            this.LabelGuardianLastlName.Size = new System.Drawing.Size(89, 21);
            this.LabelGuardianLastlName.TabIndex = 3;
            this.LabelGuardianLastlName.Text = "Last Name";
            // 
            // GRDN_textBoxMI
            // 
            this.GRDN_textBoxMI.Location = new System.Drawing.Point(508, 52);
            this.GRDN_textBoxMI.Name = "GRDN_textBoxMI";
            this.GRDN_textBoxMI.Size = new System.Drawing.Size(48, 26);
            this.GRDN_textBoxMI.TabIndex = 14;
            this.GRDN_textBoxMI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GRDN_textBoxMI_KeyPress);
            this.GRDN_textBoxMI.Leave += new System.EventHandler(this.GRDN_textBoxMI_Leave);
            // 
            // LabelGuardianMI
            // 
            this.LabelGuardianMI.AutoSize = true;
            this.LabelGuardianMI.Font = new System.Drawing.Font("Segoe UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGuardianMI.Location = new System.Drawing.Point(508, 29);
            this.LabelGuardianMI.Name = "LabelGuardianMI";
            this.LabelGuardianMI.Size = new System.Drawing.Size(37, 21);
            this.LabelGuardianMI.TabIndex = 2;
            this.LabelGuardianMI.Text = "M.I.";
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(87, 553);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(123, 32);
            this.buttonConfirm.TabIndex = 18;
            this.buttonConfirm.Text = "CONFIRM";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonCLR
            // 
            this.buttonCLR.Location = new System.Drawing.Point(268, 553);
            this.buttonCLR.Name = "buttonCLR";
            this.buttonCLR.Size = new System.Drawing.Size(170, 32);
            this.buttonCLR.TabIndex = 19;
            this.buttonCLR.Text = "CLEAR ALL FIELDS";
            this.buttonCLR.UseVisualStyleBackColor = true;
            this.buttonCLR.Click += new System.EventHandler(this.buttonCLR_Click);
            // 
            // student_grpbx
            // 
            this.student_grpbx.Controls.Add(this.STUD_textBoxMobileNum);
            this.student_grpbx.Controls.Add(this.LabelStudentMobileNumber);
            this.student_grpbx.Controls.Add(this.STUD_textBoxLandLine);
            this.student_grpbx.Controls.Add(this.LabelStudentLandLineNumber);
            this.student_grpbx.Controls.Add(this.STUD_textBoxYrLvl);
            this.student_grpbx.Controls.Add(this.LabelStudentYearLevel);
            this.student_grpbx.Controls.Add(this.STUD_textBoxProram);
            this.student_grpbx.Controls.Add(this.LabelStudentProgram);
            this.student_grpbx.Controls.Add(this.LabelStudentGender);
            this.student_grpbx.Controls.Add(this.STUD_radioButtonFemale);
            this.student_grpbx.Controls.Add(this.STUD_radioButtonMale);
            this.student_grpbx.Controls.Add(this.STUD_textBoxFirstName);
            this.student_grpbx.Controls.Add(this.STUD_textBoxStudentNumber);
            this.student_grpbx.Controls.Add(this.LabelStudentNumber);
            this.student_grpbx.Controls.Add(this.STUD_textBoxAge);
            this.student_grpbx.Controls.Add(this.LabelStudentAge);
            this.student_grpbx.Controls.Add(this.LabelStudentFirstName);
            this.student_grpbx.Controls.Add(this.STUD_textBoxLastName);
            this.student_grpbx.Controls.Add(this.LabelStudentLastName);
            this.student_grpbx.Controls.Add(this.STUD_textBoxMI);
            this.student_grpbx.Controls.Add(this.LabelStudentMI);
            this.student_grpbx.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_grpbx.Location = new System.Drawing.Point(32, 28);
            this.student_grpbx.Name = "student_grpbx";
            this.student_grpbx.Size = new System.Drawing.Size(596, 255);
            this.student_grpbx.TabIndex = 18;
            this.student_grpbx.TabStop = false;
            this.student_grpbx.Text = "PATIENT INFORMATION";
            // 
            // STUD_textBoxMobileNum
            // 
            this.STUD_textBoxMobileNum.Location = new System.Drawing.Point(16, 218);
            this.STUD_textBoxMobileNum.Name = "STUD_textBoxMobileNum";
            this.STUD_textBoxMobileNum.Size = new System.Drawing.Size(232, 26);
            this.STUD_textBoxMobileNum.TabIndex = 10;
            this.STUD_textBoxMobileNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.STUD_textBoxMobileNum_KeyPress);
            this.STUD_textBoxMobileNum.Leave += new System.EventHandler(this.STUD_textBoxMobileNum_Leave);
            // 
            // LabelStudentMobileNumber
            // 
            this.LabelStudentMobileNumber.AutoSize = true;
            this.LabelStudentMobileNumber.Font = new System.Drawing.Font("Segoe UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStudentMobileNumber.Location = new System.Drawing.Point(12, 195);
            this.LabelStudentMobileNumber.Name = "LabelStudentMobileNumber";
            this.LabelStudentMobileNumber.Size = new System.Drawing.Size(138, 21);
            this.LabelStudentMobileNumber.TabIndex = 17;
            this.LabelStudentMobileNumber.Text = "MOBILE NUMBER";
            // 
            // STUD_textBoxLandLine
            // 
            this.STUD_textBoxLandLine.Location = new System.Drawing.Point(262, 217);
            this.STUD_textBoxLandLine.Name = "STUD_textBoxLandLine";
            this.STUD_textBoxLandLine.Size = new System.Drawing.Size(236, 26);
            this.STUD_textBoxLandLine.TabIndex = 11;
            this.STUD_textBoxLandLine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.STUD_textBoxLandLine_KeyPress);
            this.STUD_textBoxLandLine.Leave += new System.EventHandler(this.STUD_textBoxLandLine_Leave);
            // 
            // LabelStudentLandLineNumber
            // 
            this.LabelStudentLandLineNumber.AutoSize = true;
            this.LabelStudentLandLineNumber.Font = new System.Drawing.Font("Segoe UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStudentLandLineNumber.Location = new System.Drawing.Point(260, 194);
            this.LabelStudentLandLineNumber.Name = "LabelStudentLandLineNumber";
            this.LabelStudentLandLineNumber.Size = new System.Drawing.Size(88, 21);
            this.LabelStudentLandLineNumber.TabIndex = 19;
            this.LabelStudentLandLineNumber.Text = "LANDLINE";
            // 
            // STUD_textBoxYrLvl
            // 
            this.STUD_textBoxYrLvl.Location = new System.Drawing.Point(386, 114);
            this.STUD_textBoxYrLvl.Name = "STUD_textBoxYrLvl";
            this.STUD_textBoxYrLvl.Size = new System.Drawing.Size(62, 26);
            this.STUD_textBoxYrLvl.TabIndex = 7;
            this.STUD_textBoxYrLvl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.STUD_textBoxYrLvl_KeyPress);
            this.STUD_textBoxYrLvl.Leave += new System.EventHandler(this.STUD_textBoxYrLvl_Leave);
            // 
            // LabelStudentYearLevel
            // 
            this.LabelStudentYearLevel.AutoSize = true;
            this.LabelStudentYearLevel.Font = new System.Drawing.Font("Segoe UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStudentYearLevel.Location = new System.Drawing.Point(382, 91);
            this.LabelStudentYearLevel.Name = "LabelStudentYearLevel";
            this.LabelStudentYearLevel.Size = new System.Drawing.Size(85, 21);
            this.LabelStudentYearLevel.TabIndex = 13;
            this.LabelStudentYearLevel.Text = "Year Level";
            // 
            // STUD_textBoxProram
            // 
            this.STUD_textBoxProram.Location = new System.Drawing.Point(284, 114);
            this.STUD_textBoxProram.Name = "STUD_textBoxProram";
            this.STUD_textBoxProram.Size = new System.Drawing.Size(54, 26);
            this.STUD_textBoxProram.TabIndex = 6;
            this.STUD_textBoxProram.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.STUD_textBoxProram_KeyPress);
            this.STUD_textBoxProram.Leave += new System.EventHandler(this.STUD_textBoxProram_Leave);
            // 
            // LabelStudentProgram
            // 
            this.LabelStudentProgram.AutoSize = true;
            this.LabelStudentProgram.Font = new System.Drawing.Font("Segoe UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStudentProgram.Location = new System.Drawing.Point(279, 91);
            this.LabelStudentProgram.Name = "LabelStudentProgram";
            this.LabelStudentProgram.Size = new System.Drawing.Size(74, 21);
            this.LabelStudentProgram.TabIndex = 15;
            this.LabelStudentProgram.Text = "Program";
            // 
            // LabelStudentGender
            // 
            this.LabelStudentGender.AutoSize = true;
            this.LabelStudentGender.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStudentGender.Location = new System.Drawing.Point(188, 162);
            this.LabelStudentGender.Name = "LabelStudentGender";
            this.LabelStudentGender.Size = new System.Drawing.Size(65, 21);
            this.LabelStudentGender.TabIndex = 12;
            this.LabelStudentGender.Text = "Gender";
            // 
            // STUD_radioButtonFemale
            // 
            this.STUD_radioButtonFemale.AutoSize = true;
            this.STUD_radioButtonFemale.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STUD_radioButtonFemale.Location = new System.Drawing.Point(338, 158);
            this.STUD_radioButtonFemale.Name = "STUD_radioButtonFemale";
            this.STUD_radioButtonFemale.Size = new System.Drawing.Size(90, 25);
            this.STUD_radioButtonFemale.TabIndex = 9;
            this.STUD_radioButtonFemale.TabStop = true;
            this.STUD_radioButtonFemale.Text = "Female";
            this.STUD_radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // STUD_radioButtonMale
            // 
            this.STUD_radioButtonMale.AutoSize = true;
            this.STUD_radioButtonMale.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STUD_radioButtonMale.Location = new System.Drawing.Point(262, 160);
            this.STUD_radioButtonMale.Name = "STUD_radioButtonMale";
            this.STUD_radioButtonMale.Size = new System.Drawing.Size(73, 25);
            this.STUD_radioButtonMale.TabIndex = 8;
            this.STUD_radioButtonMale.TabStop = true;
            this.STUD_radioButtonMale.Text = "Male";
            this.STUD_radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // STUD_textBoxFirstName
            // 
            this.STUD_textBoxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.STUD_textBoxFirstName.Location = new System.Drawing.Point(16, 58);
            this.STUD_textBoxFirstName.Name = "STUD_textBoxFirstName";
            this.STUD_textBoxFirstName.Size = new System.Drawing.Size(232, 26);
            this.STUD_textBoxFirstName.TabIndex = 1;
            this.STUD_textBoxFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.STUD_textBoxFirstName_KeyPress);
            this.STUD_textBoxFirstName.Leave += new System.EventHandler(this.STUD_textBoxFirstName_Leave);
            // 
            // STUD_textBoxStudentNumber
            // 
            this.STUD_textBoxStudentNumber.Location = new System.Drawing.Point(94, 114);
            this.STUD_textBoxStudentNumber.Name = "STUD_textBoxStudentNumber";
            this.STUD_textBoxStudentNumber.Size = new System.Drawing.Size(168, 26);
            this.STUD_textBoxStudentNumber.TabIndex = 5;
            this.STUD_textBoxStudentNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.STUD_textBoxStudentNumber_KeyPress);
            this.STUD_textBoxStudentNumber.Leave += new System.EventHandler(this.STUD_textBoxStudentNumber_Leave);
            // 
            // LabelStudentNumber
            // 
            this.LabelStudentNumber.AutoSize = true;
            this.LabelStudentNumber.Font = new System.Drawing.Font("Segoe UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStudentNumber.Location = new System.Drawing.Point(90, 91);
            this.LabelStudentNumber.Name = "LabelStudentNumber";
            this.LabelStudentNumber.Size = new System.Drawing.Size(133, 21);
            this.LabelStudentNumber.TabIndex = 6;
            this.LabelStudentNumber.Text = "Student Number";
            // 
            // STUD_textBoxAge
            // 
            this.STUD_textBoxAge.Location = new System.Drawing.Point(16, 114);
            this.STUD_textBoxAge.Name = "STUD_textBoxAge";
            this.STUD_textBoxAge.Size = new System.Drawing.Size(54, 26);
            this.STUD_textBoxAge.TabIndex = 4;
            this.STUD_textBoxAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.STUD_textBoxAge_KeyPress);
            this.STUD_textBoxAge.Leave += new System.EventHandler(this.STUD_textBoxAge_Leave);
            // 
            // LabelStudentAge
            // 
            this.LabelStudentAge.AutoSize = true;
            this.LabelStudentAge.Font = new System.Drawing.Font("Segoe UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStudentAge.Location = new System.Drawing.Point(12, 91);
            this.LabelStudentAge.Name = "LabelStudentAge";
            this.LabelStudentAge.Size = new System.Drawing.Size(38, 21);
            this.LabelStudentAge.TabIndex = 8;
            this.LabelStudentAge.Text = "Age";
            // 
            // LabelStudentFirstName
            // 
            this.LabelStudentFirstName.AutoSize = true;
            this.LabelStudentFirstName.Font = new System.Drawing.Font("Segoe UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStudentFirstName.Location = new System.Drawing.Point(12, 37);
            this.LabelStudentFirstName.Name = "LabelStudentFirstName";
            this.LabelStudentFirstName.Size = new System.Drawing.Size(91, 21);
            this.LabelStudentFirstName.TabIndex = 0;
            this.LabelStudentFirstName.Text = "First Name";
            // 
            // STUD_textBoxLastName
            // 
            this.STUD_textBoxLastName.Location = new System.Drawing.Point(262, 58);
            this.STUD_textBoxLastName.Name = "STUD_textBoxLastName";
            this.STUD_textBoxLastName.Size = new System.Drawing.Size(236, 26);
            this.STUD_textBoxLastName.TabIndex = 2;
            this.STUD_textBoxLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.STUD_textBoxFLastName_KeyPress);
            this.STUD_textBoxLastName.Leave += new System.EventHandler(this.STUD_textBoxLastName_Leave);
            // 
            // LabelStudentLastName
            // 
            this.LabelStudentLastName.AutoSize = true;
            this.LabelStudentLastName.Font = new System.Drawing.Font("Segoe UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStudentLastName.Location = new System.Drawing.Point(260, 35);
            this.LabelStudentLastName.Name = "LabelStudentLastName";
            this.LabelStudentLastName.Size = new System.Drawing.Size(89, 21);
            this.LabelStudentLastName.TabIndex = 3;
            this.LabelStudentLastName.Text = "Last Name";
            // 
            // STUD_textBoxMI
            // 
            this.STUD_textBoxMI.Location = new System.Drawing.Point(510, 55);
            this.STUD_textBoxMI.Name = "STUD_textBoxMI";
            this.STUD_textBoxMI.Size = new System.Drawing.Size(48, 26);
            this.STUD_textBoxMI.TabIndex = 3;
            this.STUD_textBoxMI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.STUD_textBoxMI_KeyPress);
            this.STUD_textBoxMI.Leave += new System.EventHandler(this.STUD_textBoxMI_Leave);
            // 
            // LabelStudentMI
            // 
            this.LabelStudentMI.AutoSize = true;
            this.LabelStudentMI.Font = new System.Drawing.Font("Segoe UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStudentMI.Location = new System.Drawing.Point(508, 35);
            this.LabelStudentMI.Name = "LabelStudentMI";
            this.LabelStudentMI.Size = new System.Drawing.Size(37, 21);
            this.LabelStudentMI.TabIndex = 2;
            this.LabelStudentMI.Text = "M.I.";
            // 
            // warning_label
            // 
            this.warning_label.AutoSize = true;
            this.warning_label.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warning_label.ForeColor = System.Drawing.Color.DarkRed;
            this.warning_label.Location = new System.Drawing.Point(172, 529);
            this.warning_label.Name = "warning_label";
            this.warning_label.Size = new System.Drawing.Size(14, 21);
            this.warning_label.TabIndex = 20;
            this.warning_label.Text = ".";
            // 
            // buttonCNCL
            // 
            this.buttonCNCL.Location = new System.Drawing.Point(480, 553);
            this.buttonCNCL.Name = "buttonCNCL";
            this.buttonCNCL.Size = new System.Drawing.Size(123, 32);
            this.buttonCNCL.TabIndex = 21;
            this.buttonCNCL.Text = "CANCEL";
            this.buttonCNCL.UseVisualStyleBackColor = true;
            this.buttonCNCL.Click += new System.EventHandler(this.buttonCNCL_Click);
            // 
            // StudentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(660, 614);
            this.Controls.Add(this.buttonCNCL);
            this.Controls.Add(this.warning_label);
            this.Controls.Add(this.buttonCLR);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.guradian_grpbx);
            this.Controls.Add(this.student_grpbx);
            this.Name = "StudentDetails";
            this.Text = "Student Details";
            this.Load += new System.EventHandler(this.StudentDetails_Load);
            this.guradian_grpbx.ResumeLayout(false);
            this.guradian_grpbx.PerformLayout();
            this.student_grpbx.ResumeLayout(false);
            this.student_grpbx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox guradian_grpbx;
        private System.Windows.Forms.Label LabelGuardianRel;
        private System.Windows.Forms.ComboBox comboBoxRelationship;
        private System.Windows.Forms.TextBox GRDN_textBoxMobileNum;
        private System.Windows.Forms.Label LabelGuardianMobileNumber;
        private System.Windows.Forms.TextBox GRDN_textBoxLandLine;
        private System.Windows.Forms.Label LabelGuardianLandLineNumber;
        private System.Windows.Forms.TextBox GRDN_textBoxFirstName;
        private System.Windows.Forms.Label LabelGuardianFirstName;
        private System.Windows.Forms.TextBox GRDN_textBoxLastName;
        private System.Windows.Forms.Label LabelGuardianLastlName;
        private System.Windows.Forms.TextBox GRDN_textBoxMI;
        private System.Windows.Forms.Label LabelGuardianMI;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonCLR;
        private System.Windows.Forms.GroupBox student_grpbx;
        private System.Windows.Forms.TextBox STUD_textBoxMobileNum;
        private System.Windows.Forms.Label LabelStudentMobileNumber;
        private System.Windows.Forms.TextBox STUD_textBoxLandLine;
        private System.Windows.Forms.Label LabelStudentLandLineNumber;
        private System.Windows.Forms.TextBox STUD_textBoxYrLvl;
        private System.Windows.Forms.Label LabelStudentYearLevel;
        private System.Windows.Forms.TextBox STUD_textBoxProram;
        private System.Windows.Forms.Label LabelStudentProgram;
        private System.Windows.Forms.Label LabelStudentGender;
        private System.Windows.Forms.RadioButton STUD_radioButtonFemale;
        private System.Windows.Forms.RadioButton STUD_radioButtonMale;
        private System.Windows.Forms.TextBox STUD_textBoxFirstName;
        private System.Windows.Forms.TextBox STUD_textBoxStudentNumber;
        private System.Windows.Forms.Label LabelStudentNumber;
        private System.Windows.Forms.TextBox STUD_textBoxAge;
        private System.Windows.Forms.Label LabelStudentAge;
        private System.Windows.Forms.Label LabelStudentFirstName;
        private System.Windows.Forms.TextBox STUD_textBoxLastName;
        private System.Windows.Forms.Label LabelStudentLastName;
        private System.Windows.Forms.TextBox STUD_textBoxMI;
        private System.Windows.Forms.Label LabelStudentMI;
        private System.Windows.Forms.Label warning_label;
        private System.Windows.Forms.Button buttonCNCL;
    }
}