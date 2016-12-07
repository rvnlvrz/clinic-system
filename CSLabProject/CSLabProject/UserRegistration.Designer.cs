namespace CSLabProject
{
    partial class frmAddUser
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
            this.tbxUser = new System.Windows.Forms.TextBox();
            this.tbxPass = new System.Windows.Forms.TextBox();
            this.tbxConfirm = new System.Windows.Forms.TextBox();
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
            this.titlelbl.ForeColor = System.Drawing.Color.White;
            this.titlelbl.Location = new System.Drawing.Point(16, 12);
            this.titlelbl.Name = "titlelbl";
            this.titlelbl.Size = new System.Drawing.Size(175, 25);
            this.titlelbl.TabIndex = 0;
            this.titlelbl.Text = "Create an Account";
            this.titlelbl.Click += new System.EventHandler(this.titlelbl_Click);
            // 
            // fnametxtBox
            // 
            this.fnametxtBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnametxtBox.Location = new System.Drawing.Point(40, 72);
            this.fnametxtBox.Name = "fnametxtBox";
            this.fnametxtBox.Size = new System.Drawing.Size(151, 20);
            this.fnametxtBox.TabIndex = 1;
            this.fnametxtBox.TextChanged += new System.EventHandler(this.fnametxtBox_TextChanged);
            this.fnametxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputStringHandler);
            // 
            // lastnametxtBox
            // 
            this.lastnametxtBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnametxtBox.Location = new System.Drawing.Point(40, 126);
            this.lastnametxtBox.Name = "lastnametxtBox";
            this.lastnametxtBox.Size = new System.Drawing.Size(151, 20);
            this.lastnametxtBox.TabIndex = 2;
            this.lastnametxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputStringHandler);
            // 
            // middlenametxtBox
            // 
            this.middlenametxtBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middlenametxtBox.Location = new System.Drawing.Point(216, 126);
            this.middlenametxtBox.Name = "middlenametxtBox";
            this.middlenametxtBox.Size = new System.Drawing.Size(42, 20);
            this.middlenametxtBox.TabIndex = 3;
            this.middlenametxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputStringHandler);
            // 
            // tbxUser
            // 
            this.tbxUser.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUser.Location = new System.Drawing.Point(40, 186);
            this.tbxUser.Name = "tbxUser";
            this.tbxUser.Size = new System.Drawing.Size(151, 20);
            this.tbxUser.TabIndex = 4;
            this.tbxUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputStringHandler);
            // 
            // tbxPass
            // 
            this.tbxPass.Location = new System.Drawing.Point(40, 245);
            this.tbxPass.Name = "tbxPass";
            this.tbxPass.PasswordChar = '*';
            this.tbxPass.Size = new System.Drawing.Size(151, 20);
            this.tbxPass.TabIndex = 5;
            // 
            // tbxConfirm
            // 
            this.tbxConfirm.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxConfirm.Location = new System.Drawing.Point(40, 301);
            this.tbxConfirm.Name = "tbxConfirm";
            this.tbxConfirm.PasswordChar = '*';
            this.tbxConfirm.Size = new System.Drawing.Size(151, 20);
            this.tbxConfirm.TabIndex = 6;
            // 
            // lblMiddlename
            // 
            this.lblMiddlename.AutoSize = true;
            this.lblMiddlename.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddlename.ForeColor = System.Drawing.Color.White;
            this.lblMiddlename.Location = new System.Drawing.Point(213, 110);
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
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(37, 170);
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
            this.lblPass.ForeColor = System.Drawing.Color.White;
            this.lblPass.Location = new System.Drawing.Point(37, 229);
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
            this.lblConfirmpass.ForeColor = System.Drawing.Color.White;
            this.lblConfirmpass.Location = new System.Drawing.Point(40, 285);
            this.lblConfirmpass.Name = "lblConfirmpass";
            this.lblConfirmpass.Size = new System.Drawing.Size(113, 13);
            this.lblConfirmpass.TabIndex = 15;
            this.lblConfirmpass.Text = "Confirm Password: *";
            this.lblConfirmpass.Click += new System.EventHandler(this.lblConfirmpass_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnCreate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCreate.Location = new System.Drawing.Point(152, 352);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(101, 29);
            this.btnCreate.TabIndex = 17;
            this.btnCreate.Text = "Create Account";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.Location = new System.Drawing.Point(42, 353);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 29);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFname.ForeColor = System.Drawing.Color.White;
            this.lblFname.Location = new System.Drawing.Point(40, 110);
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
            this.lblLname.ForeColor = System.Drawing.Color.White;
            this.lblLname.Location = new System.Drawing.Point(40, 56);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(73, 13);
            this.lblLname.TabIndex = 20;
            this.lblLname.Text = "Last Name: *";
            this.lblLname.Click += new System.EventHandler(this.lblLname_Click);
            // 
            // frmAddUser
            // 
            this.AcceptButton = this.btnCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(298, 395);
            this.Controls.Add(this.lblLname);
            this.Controls.Add(this.lblFname);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblConfirmpass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblMiddlename);
            this.Controls.Add(this.tbxConfirm);
            this.Controls.Add(this.tbxPass);
            this.Controls.Add(this.tbxUser);
            this.Controls.Add(this.middlenametxtBox);
            this.Controls.Add(this.lastnametxtBox);
            this.Controls.Add(this.fnametxtBox);
            this.Controls.Add(this.titlelbl);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmAddUser";
            this.Text = "Add User";
            this.Load += new System.EventHandler(this.UserRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titlelbl;
        private System.Windows.Forms.TextBox fnametxtBox;
        private System.Windows.Forms.TextBox lastnametxtBox;
        private System.Windows.Forms.TextBox middlenametxtBox;
        private System.Windows.Forms.TextBox tbxUser;
        private System.Windows.Forms.TextBox tbxPass;
        private System.Windows.Forms.TextBox tbxConfirm;
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