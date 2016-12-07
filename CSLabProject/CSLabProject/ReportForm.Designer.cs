namespace CSLabProject
{
    partial class frmReportForm
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
            this.lblStudentNumber = new System.Windows.Forms.Label();
            this.btnAddStud = new System.Windows.Forms.Button();
            this.tbxStudNum = new System.Windows.Forms.TextBox();
            this.grpbxMedication = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // lblStudentNumber
            // 
            this.lblStudentNumber.AutoSize = true;
            this.lblStudentNumber.Location = new System.Drawing.Point(16, 16);
            this.lblStudentNumber.Name = "lblStudentNumber";
            this.lblStudentNumber.Size = new System.Drawing.Size(87, 13);
            this.lblStudentNumber.TabIndex = 0;
            this.lblStudentNumber.Text = "Student Number:";
            // 
            // btnAddStud
            // 
            this.btnAddStud.Location = new System.Drawing.Point(144, 32);
            this.btnAddStud.Name = "btnAddStud";
            this.btnAddStud.Size = new System.Drawing.Size(75, 23);
            this.btnAddStud.TabIndex = 1;
            this.btnAddStud.Text = "Add Student";
            this.btnAddStud.UseVisualStyleBackColor = true;
            // 
            // tbxStudNum
            // 
            this.tbxStudNum.Location = new System.Drawing.Point(16, 32);
            this.tbxStudNum.MaxLength = 10;
            this.tbxStudNum.Name = "tbxStudNum";
            this.tbxStudNum.Size = new System.Drawing.Size(120, 20);
            this.tbxStudNum.TabIndex = 1;
            this.tbxStudNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxStudNum_KeyPress);
            // 
            // grpbxMedication
            // 
            this.grpbxMedication.Location = new System.Drawing.Point(16, 112);
            this.grpbxMedication.Name = "grpbxMedication";
            this.grpbxMedication.Size = new System.Drawing.Size(312, 216);
            this.grpbxMedication.TabIndex = 2;
            this.grpbxMedication.TabStop = false;
            this.grpbxMedication.Text = "Medical Procedure:";
            // 
            // frmReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 344);
            this.Controls.Add(this.grpbxMedication);
            this.Controls.Add(this.tbxStudNum);
            this.Controls.Add(this.btnAddStud);
            this.Controls.Add(this.lblStudentNumber);
            this.Name = "frmReportForm";
            this.Text = "Report Form";
            this.Load += new System.EventHandler(this.frmReportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentNumber;
        private System.Windows.Forms.Button btnAddStud;
        private System.Windows.Forms.TextBox tbxStudNum;
        private System.Windows.Forms.GroupBox grpbxMedication;
    }
}