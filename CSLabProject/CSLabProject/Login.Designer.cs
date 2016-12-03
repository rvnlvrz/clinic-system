namespace CSLabProject
{
    partial class LoginForm
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
            this.lblMapua = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblClinic = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPasscode = new System.Windows.Forms.Label();
            this.tbxPass = new System.Windows.Forms.TextBox();
            this.bntLogIn = new System.Windows.Forms.Button();
            this.tbxUser = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMapua
            // 
            this.lblMapua.AutoSize = true;
            this.lblMapua.BackColor = System.Drawing.Color.Transparent;
            this.lblMapua.Font = new System.Drawing.Font("Constantia", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMapua.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMapua.Location = new System.Drawing.Point(264, 40);
            this.lblMapua.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMapua.Name = "lblMapua";
            this.lblMapua.Size = new System.Drawing.Size(155, 46);
            this.lblMapua.TabIndex = 1;
            this.lblMapua.Text = "MAPÚA";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblDesc.Font = new System.Drawing.Font("Constantia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDesc.Location = new System.Drawing.Point(280, 80);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(116, 13);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Institute of Technology";
            // 
            // lblClinic
            // 
            this.lblClinic.AutoSize = true;
            this.lblClinic.BackColor = System.Drawing.Color.Transparent;
            this.lblClinic.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClinic.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblClinic.Location = new System.Drawing.Point(272, 96);
            this.lblClinic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClinic.Name = "lblClinic";
            this.lblClinic.Size = new System.Drawing.Size(137, 15);
            this.lblClinic.TabIndex = 3;
            this.lblClinic.Text = "Clinic Management System";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.ForeColor = System.Drawing.Color.Transparent;
            this.lblUser.Location = new System.Drawing.Point(200, 152);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(58, 13);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "Username:";
            this.lblUser.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPasscode
            // 
            this.lblPasscode.AutoSize = true;
            this.lblPasscode.ForeColor = System.Drawing.Color.Transparent;
            this.lblPasscode.Location = new System.Drawing.Point(200, 208);
            this.lblPasscode.Name = "lblPasscode";
            this.lblPasscode.Size = new System.Drawing.Size(56, 13);
            this.lblPasscode.TabIndex = 5;
            this.lblPasscode.Text = "Password:";
            // 
            // tbxPass
            // 
            this.tbxPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPass.Location = new System.Drawing.Point(200, 224);
            this.tbxPass.Name = "tbxPass";
            this.tbxPass.PasswordChar = '*';
            this.tbxPass.Size = new System.Drawing.Size(184, 23);
            this.tbxPass.TabIndex = 2;
            // 
            // bntLogIn
            // 
            this.bntLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.bntLogIn.FlatAppearance.BorderSize = 0;
            this.bntLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntLogIn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bntLogIn.Location = new System.Drawing.Point(312, 264);
            this.bntLogIn.Name = "bntLogIn";
            this.bntLogIn.Size = new System.Drawing.Size(72, 23);
            this.bntLogIn.TabIndex = 3;
            this.bntLogIn.Text = "Log In";
            this.bntLogIn.UseVisualStyleBackColor = false;
            this.bntLogIn.Click += new System.EventHandler(this.bntLogIn_Click);
            // 
            // tbxUser
            // 
            this.tbxUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUser.Location = new System.Drawing.Point(200, 168);
            this.tbxUser.Name = "tbxUser";
            this.tbxUser.Size = new System.Drawing.Size(184, 23);
            this.tbxUser.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CSLabProject.Properties.Resources.MIT_Logo_100px;
            this.pictureBox1.Location = new System.Drawing.Point(160, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(596, 361);
            this.Controls.Add(this.tbxUser);
            this.Controls.Add(this.bntLogIn);
            this.Controls.Add(this.tbxPass);
            this.Controls.Add(this.lblPasscode);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblClinic);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblMapua);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximumSize = new System.Drawing.Size(612, 400);
            this.MinimumSize = new System.Drawing.Size(612, 400);
            this.Name = "LoginForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAPÚA - Clinic Management System";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMapua;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblClinic;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPasscode;
        private System.Windows.Forms.TextBox tbxPass;
        private System.Windows.Forms.Button bntLogIn;
        private System.Windows.Forms.TextBox tbxUser;
    }
}

