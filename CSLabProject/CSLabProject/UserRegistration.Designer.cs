namespace CSLabProject
{
    partial class UserRegistration
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
            this.titlelbl = new System.Windows.Forms.Label();
            this.fnametxtBox = new System.Windows.Forms.TextBox();
            this.lastnametxtBox = new System.Windows.Forms.TextBox();
            this.middlenametxtBox = new System.Windows.Forms.TextBox();
            this.usertxtBox = new System.Windows.Forms.TextBox();
            this.passtxtBox = new System.Windows.Forms.TextBox();
            this.confirmpasstxtBox = new System.Windows.Forms.TextBox();
            this.lblMiddlename = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblConfirmpass = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblFname = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titlelbl
            // 
            this.titlelbl.AutoSize = true;
            this.titlelbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelbl.Location = new System.Drawing.Point(30, 35);
            this.titlelbl.Name = "titlelbl";
            this.titlelbl.Size = new System.Drawing.Size(175, 25);
            this.titlelbl.TabIndex = 0;
            this.titlelbl.Text = "Create an Account";
            this.titlelbl.Click += new System.EventHandler(this.titlelbl_Click);
            // 
            // fnametxtBox
            // 
            this.fnametxtBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnametxtBox.Location = new System.Drawing.Point(54, 95);
            this.fnametxtBox.Name = "fnametxtBox";
            this.fnametxtBox.Size = new System.Drawing.Size(151, 20);
            this.fnametxtBox.TabIndex = 1;
            this.fnametxtBox.TextChanged += new System.EventHandler(this.fnametxtBox_TextChanged);
            // 
            // lastnametxtBox
            // 
            this.lastnametxtBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnametxtBox.Location = new System.Drawing.Point(54, 149);
            this.lastnametxtBox.Name = "lastnametxtBox";
            this.lastnametxtBox.Size = new System.Drawing.Size(151, 20);
            this.lastnametxtBox.TabIndex = 2;
            // 
            // middlenametxtBox
            // 
            this.middlenametxtBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middlenametxtBox.Location = new System.Drawing.Point(230, 149);
            this.middlenametxtBox.Name = "middlenametxtBox";
            this.middlenametxtBox.Size = new System.Drawing.Size(42, 20);
            this.middlenametxtBox.TabIndex = 3;
            // 
            // usertxtBox
            // 
            this.usertxtBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertxtBox.Location = new System.Drawing.Point(54, 209);
            this.usertxtBox.Name = "usertxtBox";
            this.usertxtBox.Size = new System.Drawing.Size(151, 20);
            this.usertxtBox.TabIndex = 4;
            // 
            // passtxtBox
            // 
            this.passtxtBox.Location = new System.Drawing.Point(54, 268);
            this.passtxtBox.Name = "passtxtBox";
            this.passtxtBox.Size = new System.Drawing.Size(151, 20);
            this.passtxtBox.TabIndex = 5;
            // 
            // confirmpasstxtBox
            // 
            this.confirmpasstxtBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmpasstxtBox.Location = new System.Drawing.Point(54, 324);
            this.confirmpasstxtBox.Name = "confirmpasstxtBox";
            this.confirmpasstxtBox.Size = new System.Drawing.Size(151, 20);
            this.confirmpasstxtBox.TabIndex = 6;
            // 
            // lblMiddlename
            // 
            this.lblMiddlename.AutoSize = true;
            this.lblMiddlename.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddlename.Location = new System.Drawing.Point(227, 133);
            this.lblMiddlename.Name = "lblMiddlename";
            this.lblMiddlename.Size = new System.Drawing.Size(27, 13);
            this.lblMiddlename.TabIndex = 12;
            this.lblMiddlename.Text = "M.I.";
            this.lblMiddlename.Click += new System.EventHandler(this.lblMiddlename_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(51, 193);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(70, 13);
            this.lblUser.TabIndex = 13;
            this.lblUser.Text = "Username: *";
            this.lblUser.Click += new System.EventHandler(this.lblUser_Click);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(51, 252);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(68, 13);
            this.lblPass.TabIndex = 14;
            this.lblPass.Text = "Password: *";
            this.lblPass.Click += new System.EventHandler(this.lblPass_Click);
            // 
            // lblConfirmpass
            // 
            this.lblConfirmpass.AutoSize = true;
            this.lblConfirmpass.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmpass.Location = new System.Drawing.Point(54, 308);
            this.lblConfirmpass.Name = "lblConfirmpass";
            this.lblConfirmpass.Size = new System.Drawing.Size(113, 13);
            this.lblConfirmpass.TabIndex = 15;
            this.lblConfirmpass.Text = "Confirm Password: *";
            this.lblConfirmpass.Click += new System.EventHandler(this.lblConfirmpass_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(54, 376);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(101, 29);
            this.btnCreate.TabIndex = 17;
            this.btnCreate.Text = "Create Account";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(193, 376);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 29);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFname.Location = new System.Drawing.Point(54, 133);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(74, 13);
            this.lblFname.TabIndex = 19;
            this.lblFname.Text = "First Name: *";
            this.lblFname.Click += new System.EventHandler(this.lblFname_Click);
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLname.Location = new System.Drawing.Point(54, 79);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(73, 13);
            this.lblLname.TabIndex = 20;
            this.lblLname.Text = "Last Name: *";
            this.lblLname.Click += new System.EventHandler(this.lblLname_Click);
            // 
            // UserRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 438);
            this.Controls.Add(this.lblLname);
            this.Controls.Add(this.lblFname);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblConfirmpass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblMiddlename);
            this.Controls.Add(this.confirmpasstxtBox);
            this.Controls.Add(this.passtxtBox);
            this.Controls.Add(this.usertxtBox);
            this.Controls.Add(this.middlenametxtBox);
            this.Controls.Add(this.lastnametxtBox);
            this.Controls.Add(this.fnametxtBox);
            this.Controls.Add(this.titlelbl);
            this.Name = "UserRegistration";
            this.Text = "User Registration";
            this.Load += new System.EventHandler(this.UserRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titlelbl;
        private System.Windows.Forms.TextBox fnametxtBox;
        private System.Windows.Forms.TextBox lastnametxtBox;
        private System.Windows.Forms.TextBox middlenametxtBox;
        private System.Windows.Forms.TextBox usertxtBox;
        private System.Windows.Forms.TextBox passtxtBox;
        private System.Windows.Forms.TextBox confirmpasstxtBox;
        private System.Windows.Forms.Label lblMiddlename;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblConfirmpass;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lblLname;
    }
}