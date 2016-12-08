namespace CSLabProject
{
    partial class EmployeeDetails
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
            this.buttonCNCL = new System.Windows.Forms.Button();
            this.warning_label = new System.Windows.Forms.Label();
            this.buttonCLR = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.student_grpbx = new System.Windows.Forms.GroupBox();
            this.EMP_textBoxMobileNum = new System.Windows.Forms.TextBox();
            this.LabelEmployeeMobileNumber = new System.Windows.Forms.Label();
            this.EMP_textBoxLandLine = new System.Windows.Forms.TextBox();
            this.LabelEmployeeLandLineNumber = new System.Windows.Forms.Label();
            this.EMP_textBoxPosition = new System.Windows.Forms.TextBox();
            this.LabelEmployeePosition = new System.Windows.Forms.Label();
            this.LabelEmployeeGender = new System.Windows.Forms.Label();
            this.EMP_radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.EMP_radioButtonMale = new System.Windows.Forms.RadioButton();
            this.EMP_textBoxFirstName = new System.Windows.Forms.TextBox();
            this.EMP_textBoxEmployeeNumber = new System.Windows.Forms.TextBox();
            this.LabelEmployeeNumber = new System.Windows.Forms.Label();
            this.EMP_textBoxAge = new System.Windows.Forms.TextBox();
            this.LabelEmployeeAge = new System.Windows.Forms.Label();
            this.LabelEmployeeFirstName = new System.Windows.Forms.Label();
            this.EMP_textBoxLastName = new System.Windows.Forms.TextBox();
            this.LabelEmployeeLastName = new System.Windows.Forms.Label();
            this.EMP_textBoxMI = new System.Windows.Forms.TextBox();
            this.LabelEmployeeMI = new System.Windows.Forms.Label();
            this.student_grpbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCNCL
            // 
            this.buttonCNCL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonCNCL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCNCL.Location = new System.Drawing.Point(9, 287);
            this.buttonCNCL.Name = "buttonCNCL";
            this.buttonCNCL.Size = new System.Drawing.Size(108, 32);
            this.buttonCNCL.TabIndex = 25;
            this.buttonCNCL.Text = "Cancel";
            this.buttonCNCL.UseVisualStyleBackColor = true;
            // 
            // warning_label
            // 
            this.warning_label.AutoSize = true;
            this.warning_label.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warning_label.ForeColor = System.Drawing.Color.DarkRed;
            this.warning_label.Location = new System.Drawing.Point(169, 274);
            this.warning_label.Name = "warning_label";
            this.warning_label.Size = new System.Drawing.Size(14, 21);
            this.warning_label.TabIndex = 26;
            this.warning_label.Text = ".";
            // 
            // buttonCLR
            // 
            this.buttonCLR.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCLR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCLR.Location = new System.Drawing.Point(237, 287);
            this.buttonCLR.Name = "buttonCLR";
            this.buttonCLR.Size = new System.Drawing.Size(156, 32);
            this.buttonCLR.TabIndex = 24;
            this.buttonCLR.Text = "Clear All";
            this.buttonCLR.UseVisualStyleBackColor = true;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirm.Location = new System.Drawing.Point(501, 287);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(108, 32);
            this.buttonConfirm.TabIndex = 23;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // student_grpbx
            // 
            this.student_grpbx.BackColor = System.Drawing.Color.Transparent;
            this.student_grpbx.Controls.Add(this.EMP_textBoxMobileNum);
            this.student_grpbx.Controls.Add(this.LabelEmployeeMobileNumber);
            this.student_grpbx.Controls.Add(this.EMP_textBoxLandLine);
            this.student_grpbx.Controls.Add(this.LabelEmployeeLandLineNumber);
            this.student_grpbx.Controls.Add(this.EMP_textBoxPosition);
            this.student_grpbx.Controls.Add(this.LabelEmployeePosition);
            this.student_grpbx.Controls.Add(this.LabelEmployeeGender);
            this.student_grpbx.Controls.Add(this.EMP_radioButtonFemale);
            this.student_grpbx.Controls.Add(this.EMP_radioButtonMale);
            this.student_grpbx.Controls.Add(this.EMP_textBoxFirstName);
            this.student_grpbx.Controls.Add(this.EMP_textBoxEmployeeNumber);
            this.student_grpbx.Controls.Add(this.LabelEmployeeNumber);
            this.student_grpbx.Controls.Add(this.EMP_textBoxAge);
            this.student_grpbx.Controls.Add(this.LabelEmployeeAge);
            this.student_grpbx.Controls.Add(this.LabelEmployeeFirstName);
            this.student_grpbx.Controls.Add(this.EMP_textBoxLastName);
            this.student_grpbx.Controls.Add(this.LabelEmployeeLastName);
            this.student_grpbx.Controls.Add(this.EMP_textBoxMI);
            this.student_grpbx.Controls.Add(this.LabelEmployeeMI);
            this.student_grpbx.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_grpbx.Location = new System.Drawing.Point(8, 0);
            this.student_grpbx.Name = "student_grpbx";
            this.student_grpbx.Size = new System.Drawing.Size(600, 258);
            this.student_grpbx.TabIndex = 21;
            this.student_grpbx.TabStop = false;
            this.student_grpbx.Text = "PATIENT INFORMATION";
            // 
            // EMP_textBoxMobileNum
            // 
            this.EMP_textBoxMobileNum.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMP_textBoxMobileNum.Location = new System.Drawing.Point(24, 209);
            this.EMP_textBoxMobileNum.Name = "EMP_textBoxMobileNum";
            this.EMP_textBoxMobileNum.Size = new System.Drawing.Size(238, 26);
            this.EMP_textBoxMobileNum.TabIndex = 10;
            this.EMP_textBoxMobileNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EMP_textBoxMobileNum_KeyPress);
            this.EMP_textBoxMobileNum.Leave += new System.EventHandler(this.EMP_textBoxMobileNum_Leave);
            // 
            // LabelEmployeeMobileNumber
            // 
            this.LabelEmployeeMobileNumber.AutoSize = true;
            this.LabelEmployeeMobileNumber.Font = new System.Drawing.Font("Segoe UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEmployeeMobileNumber.Location = new System.Drawing.Point(24, 185);
            this.LabelEmployeeMobileNumber.Name = "LabelEmployeeMobileNumber";
            this.LabelEmployeeMobileNumber.Size = new System.Drawing.Size(138, 21);
            this.LabelEmployeeMobileNumber.TabIndex = 17;
            this.LabelEmployeeMobileNumber.Text = "MOBILE NUMBER";
            // 
            // EMP_textBoxLandLine
            // 
            this.EMP_textBoxLandLine.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMP_textBoxLandLine.Location = new System.Drawing.Point(276, 209);
            this.EMP_textBoxLandLine.Name = "EMP_textBoxLandLine";
            this.EMP_textBoxLandLine.Size = new System.Drawing.Size(236, 26);
            this.EMP_textBoxLandLine.TabIndex = 11;
            this.EMP_textBoxLandLine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EMP_textBoxLandLine_KeyPress);
            this.EMP_textBoxLandLine.Leave += new System.EventHandler(this.EMP_textBoxLandLine_Leave);
            // 
            // LabelEmployeeLandLineNumber
            // 
            this.LabelEmployeeLandLineNumber.AutoSize = true;
            this.LabelEmployeeLandLineNumber.Font = new System.Drawing.Font("Segoe UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEmployeeLandLineNumber.Location = new System.Drawing.Point(276, 185);
            this.LabelEmployeeLandLineNumber.Name = "LabelEmployeeLandLineNumber";
            this.LabelEmployeeLandLineNumber.Size = new System.Drawing.Size(88, 21);
            this.LabelEmployeeLandLineNumber.TabIndex = 19;
            this.LabelEmployeeLandLineNumber.Text = "LANDLINE";
            // 
            // EMP_textBoxPosition
            // 
            this.EMP_textBoxPosition.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMP_textBoxPosition.Location = new System.Drawing.Point(276, 135);
            this.EMP_textBoxPosition.Name = "EMP_textBoxPosition";
            this.EMP_textBoxPosition.Size = new System.Drawing.Size(82, 26);
            this.EMP_textBoxPosition.TabIndex = 6;
            this.EMP_textBoxPosition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EMP_textBoxPosition_KeyPress);
            this.EMP_textBoxPosition.Leave += new System.EventHandler(this.EMP_textBoxPosition_Leave);
            // 
            // LabelEmployeePosition
            // 
            this.LabelEmployeePosition.AutoSize = true;
            this.LabelEmployeePosition.Font = new System.Drawing.Font("Segoe UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEmployeePosition.Location = new System.Drawing.Point(276, 111);
            this.LabelEmployeePosition.Name = "LabelEmployeePosition";
            this.LabelEmployeePosition.Size = new System.Drawing.Size(71, 21);
            this.LabelEmployeePosition.TabIndex = 15;
            this.LabelEmployeePosition.Text = "Position";
            // 
            // LabelEmployeeGender
            // 
            this.LabelEmployeeGender.AutoSize = true;
            this.LabelEmployeeGender.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEmployeeGender.Location = new System.Drawing.Point(384, 111);
            this.LabelEmployeeGender.Name = "LabelEmployeeGender";
            this.LabelEmployeeGender.Size = new System.Drawing.Size(65, 21);
            this.LabelEmployeeGender.TabIndex = 12;
            this.LabelEmployeeGender.Text = "Gender";
            // 
            // EMP_radioButtonFemale
            // 
            this.EMP_radioButtonFemale.AutoSize = true;
            this.EMP_radioButtonFemale.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMP_radioButtonFemale.Location = new System.Drawing.Point(475, 136);
            this.EMP_radioButtonFemale.Name = "EMP_radioButtonFemale";
            this.EMP_radioButtonFemale.Size = new System.Drawing.Size(90, 25);
            this.EMP_radioButtonFemale.TabIndex = 9;
            this.EMP_radioButtonFemale.TabStop = true;
            this.EMP_radioButtonFemale.Text = "Female";
            this.EMP_radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // EMP_radioButtonMale
            // 
            this.EMP_radioButtonMale.AutoSize = true;
            this.EMP_radioButtonMale.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMP_radioButtonMale.Location = new System.Drawing.Point(388, 136);
            this.EMP_radioButtonMale.Name = "EMP_radioButtonMale";
            this.EMP_radioButtonMale.Size = new System.Drawing.Size(73, 25);
            this.EMP_radioButtonMale.TabIndex = 8;
            this.EMP_radioButtonMale.TabStop = true;
            this.EMP_radioButtonMale.Text = "Male";
            this.EMP_radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // EMP_textBoxFirstName
            // 
            this.EMP_textBoxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EMP_textBoxFirstName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMP_textBoxFirstName.Location = new System.Drawing.Point(24, 62);
            this.EMP_textBoxFirstName.Name = "EMP_textBoxFirstName";
            this.EMP_textBoxFirstName.Size = new System.Drawing.Size(239, 26);
            this.EMP_textBoxFirstName.TabIndex = 1;
            this.EMP_textBoxFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EMP_textBoxFirstName_KeyPress);
            this.EMP_textBoxFirstName.Leave += new System.EventHandler(this.EMP_textBoxFirstName_Leave);
            // 
            // EMP_textBoxEmployeeNumber
            // 
            this.EMP_textBoxEmployeeNumber.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMP_textBoxEmployeeNumber.Location = new System.Drawing.Point(96, 135);
            this.EMP_textBoxEmployeeNumber.Name = "EMP_textBoxEmployeeNumber";
            this.EMP_textBoxEmployeeNumber.Size = new System.Drawing.Size(166, 26);
            this.EMP_textBoxEmployeeNumber.TabIndex = 5;
            this.EMP_textBoxEmployeeNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EMP_textBoxEmployeeNumber_KeyPress);
            this.EMP_textBoxEmployeeNumber.Leave += new System.EventHandler(this.EMP_textBoxEmployeeNumber_Leave);
            // 
            // LabelEmployeeNumber
            // 
            this.LabelEmployeeNumber.AutoSize = true;
            this.LabelEmployeeNumber.Font = new System.Drawing.Font("Segoe UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEmployeeNumber.Location = new System.Drawing.Point(96, 111);
            this.LabelEmployeeNumber.Name = "LabelEmployeeNumber";
            this.LabelEmployeeNumber.Size = new System.Drawing.Size(146, 21);
            this.LabelEmployeeNumber.TabIndex = 6;
            this.LabelEmployeeNumber.Text = "Employee Number";
            // 
            // EMP_textBoxAge
            // 
            this.EMP_textBoxAge.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMP_textBoxAge.Location = new System.Drawing.Point(24, 135);
            this.EMP_textBoxAge.Name = "EMP_textBoxAge";
            this.EMP_textBoxAge.Size = new System.Drawing.Size(58, 26);
            this.EMP_textBoxAge.TabIndex = 4;
            this.EMP_textBoxAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EMP_textBoxAge_KeyPress);
            this.EMP_textBoxAge.Leave += new System.EventHandler(this.EMP_textBoxAge_Leave);
            // 
            // LabelEmployeeAge
            // 
            this.LabelEmployeeAge.AutoSize = true;
            this.LabelEmployeeAge.Font = new System.Drawing.Font("Segoe UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEmployeeAge.Location = new System.Drawing.Point(24, 111);
            this.LabelEmployeeAge.Name = "LabelEmployeeAge";
            this.LabelEmployeeAge.Size = new System.Drawing.Size(38, 21);
            this.LabelEmployeeAge.TabIndex = 8;
            this.LabelEmployeeAge.Text = "Age";
            // 
            // LabelEmployeeFirstName
            // 
            this.LabelEmployeeFirstName.AutoSize = true;
            this.LabelEmployeeFirstName.Font = new System.Drawing.Font("Segoe UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEmployeeFirstName.Location = new System.Drawing.Point(24, 37);
            this.LabelEmployeeFirstName.Name = "LabelEmployeeFirstName";
            this.LabelEmployeeFirstName.Size = new System.Drawing.Size(91, 21);
            this.LabelEmployeeFirstName.TabIndex = 0;
            this.LabelEmployeeFirstName.Text = "First Name";
            // 
            // EMP_textBoxLastName
            // 
            this.EMP_textBoxLastName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMP_textBoxLastName.Location = new System.Drawing.Point(276, 62);
            this.EMP_textBoxLastName.Name = "EMP_textBoxLastName";
            this.EMP_textBoxLastName.Size = new System.Drawing.Size(238, 26);
            this.EMP_textBoxLastName.TabIndex = 2;
            this.EMP_textBoxLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EMP_textBoxLastName_KeyPress);
            this.EMP_textBoxLastName.Leave += new System.EventHandler(this.EMP_textBoxLastName_Leave);
            // 
            // LabelEmployeeLastName
            // 
            this.LabelEmployeeLastName.AutoSize = true;
            this.LabelEmployeeLastName.Font = new System.Drawing.Font("Segoe UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEmployeeLastName.Location = new System.Drawing.Point(288, 37);
            this.LabelEmployeeLastName.Name = "LabelEmployeeLastName";
            this.LabelEmployeeLastName.Size = new System.Drawing.Size(89, 21);
            this.LabelEmployeeLastName.TabIndex = 3;
            this.LabelEmployeeLastName.Text = "Last Name";
            // 
            // EMP_textBoxMI
            // 
            this.EMP_textBoxMI.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMP_textBoxMI.Location = new System.Drawing.Point(528, 62);
            this.EMP_textBoxMI.Name = "EMP_textBoxMI";
            this.EMP_textBoxMI.Size = new System.Drawing.Size(46, 26);
            this.EMP_textBoxMI.TabIndex = 3;
            this.EMP_textBoxMI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EMP_textBoxMI_KeyPress);
            this.EMP_textBoxMI.Leave += new System.EventHandler(this.EMP_textBoxMI_Leave);
            // 
            // LabelEmployeeMI
            // 
            this.LabelEmployeeMI.AutoSize = true;
            this.LabelEmployeeMI.Font = new System.Drawing.Font("Segoe UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEmployeeMI.Location = new System.Drawing.Point(528, 37);
            this.LabelEmployeeMI.Name = "LabelEmployeeMI";
            this.LabelEmployeeMI.Size = new System.Drawing.Size(37, 21);
            this.LabelEmployeeMI.TabIndex = 2;
            this.LabelEmployeeMI.Text = "M.I.";
            // 
            // EmployeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 341);
            this.Controls.Add(this.buttonCNCL);
            this.Controls.Add(this.warning_label);
            this.Controls.Add(this.buttonCLR);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.student_grpbx);
            this.Name = "EmployeeDetails";
            this.Text = "EmployeeDetails";
            this.Load += new System.EventHandler(this.EmployeeDetails_Load);
            this.student_grpbx.ResumeLayout(false);
            this.student_grpbx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCNCL;
        private System.Windows.Forms.Label warning_label;
        private System.Windows.Forms.Button buttonCLR;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.GroupBox student_grpbx;
        private System.Windows.Forms.TextBox EMP_textBoxMobileNum;
        private System.Windows.Forms.Label LabelEmployeeMobileNumber;
        private System.Windows.Forms.TextBox EMP_textBoxLandLine;
        private System.Windows.Forms.Label LabelEmployeeLandLineNumber;
        private System.Windows.Forms.TextBox EMP_textBoxPosition;
        private System.Windows.Forms.Label LabelEmployeePosition;
        private System.Windows.Forms.Label LabelEmployeeGender;
        private System.Windows.Forms.RadioButton EMP_radioButtonFemale;
        private System.Windows.Forms.RadioButton EMP_radioButtonMale;
        private System.Windows.Forms.TextBox EMP_textBoxFirstName;
        private System.Windows.Forms.TextBox EMP_textBoxEmployeeNumber;
        private System.Windows.Forms.Label LabelEmployeeNumber;
        private System.Windows.Forms.TextBox EMP_textBoxAge;
        private System.Windows.Forms.Label LabelEmployeeAge;
        private System.Windows.Forms.Label LabelEmployeeFirstName;
        private System.Windows.Forms.TextBox EMP_textBoxLastName;
        private System.Windows.Forms.Label LabelEmployeeLastName;
        private System.Windows.Forms.TextBox EMP_textBoxMI;
        private System.Windows.Forms.Label LabelEmployeeMI;
    }
}