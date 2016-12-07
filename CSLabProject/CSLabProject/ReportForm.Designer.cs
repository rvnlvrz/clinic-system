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
            this.components = new System.ComponentModel.Container();
            this.lblIDNumber = new System.Windows.Forms.Label();
            this.btnAddDB = new System.Windows.Forms.Button();
            this.tbxIDNum = new System.Windows.Forms.TextBox();
            this.grpbxMedication = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxIn = new System.Windows.Forms.TextBox();
            this.lblSlash = new System.Windows.Forms.Label();
            this.tbxDia = new System.Windows.Forms.TextBox();
            this.tbxFt = new System.Windows.Forms.TextBox();
            this.lblHt = new System.Windows.Forms.Label();
            this.tbxSys = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxWeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.grpbxProcedure = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.toolTipInit = new System.Windows.Forms.ToolTip(this.components);
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.grpbxMedication.SuspendLayout();
            this.grpbxProcedure.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIDNumber
            // 
            this.lblIDNumber.AutoSize = true;
            this.lblIDNumber.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDNumber.Location = new System.Drawing.Point(16, 16);
            this.lblIDNumber.Name = "lblIDNumber";
            this.lblIDNumber.Size = new System.Drawing.Size(122, 13);
            this.lblIDNumber.TabIndex = 0;
            this.lblIDNumber.Text = "Identification Number";
            // 
            // btnAddDB
            // 
            this.btnAddDB.Location = new System.Drawing.Point(144, 32);
            this.btnAddDB.Name = "btnAddDB";
            this.btnAddDB.Size = new System.Drawing.Size(75, 23);
            this.btnAddDB.TabIndex = 1;
            this.btnAddDB.Text = "Add to DB";
            this.btnAddDB.UseVisualStyleBackColor = true;
            // 
            // tbxIDNum
            // 
            this.tbxIDNum.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxIDNum.Location = new System.Drawing.Point(16, 32);
            this.tbxIDNum.MaxLength = 10;
            this.tbxIDNum.Name = "tbxIDNum";
            this.tbxIDNum.Size = new System.Drawing.Size(120, 20);
            this.tbxIDNum.TabIndex = 1;
            this.tbxIDNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxStudNum_KeyPress);
            // 
            // grpbxMedication
            // 
            this.grpbxMedication.Controls.Add(this.label4);
            this.grpbxMedication.Controls.Add(this.label3);
            this.grpbxMedication.Controls.Add(this.label1);
            this.grpbxMedication.Controls.Add(this.tbxIn);
            this.grpbxMedication.Controls.Add(this.lblSlash);
            this.grpbxMedication.Controls.Add(this.tbxDia);
            this.grpbxMedication.Controls.Add(this.tbxFt);
            this.grpbxMedication.Controls.Add(this.lblHt);
            this.grpbxMedication.Controls.Add(this.tbxSys);
            this.grpbxMedication.Controls.Add(this.label2);
            this.grpbxMedication.Controls.Add(this.tbxWeight);
            this.grpbxMedication.Controls.Add(this.lblWeight);
            this.grpbxMedication.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxMedication.Location = new System.Drawing.Point(16, 64);
            this.grpbxMedication.Name = "grpbxMedication";
            this.grpbxMedication.Size = new System.Drawing.Size(232, 176);
            this.grpbxMedication.TabIndex = 2;
            this.grpbxMedication.TabStop = false;
            this.grpbxMedication.Text = "Initial Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(180, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ft, In";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sys/Dia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "in kilograms";
            // 
            // tbxIn
            // 
            this.tbxIn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxIn.Location = new System.Drawing.Point(200, 40);
            this.tbxIn.Name = "tbxIn";
            this.tbxIn.Size = new System.Drawing.Size(24, 20);
            this.tbxIn.TabIndex = 8;
            // 
            // lblSlash
            // 
            this.lblSlash.AutoSize = true;
            this.lblSlash.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblSlash.Location = new System.Drawing.Point(115, 43);
            this.lblSlash.Name = "lblSlash";
            this.lblSlash.Size = new System.Drawing.Size(11, 13);
            this.lblSlash.TabIndex = 7;
            this.lblSlash.Text = "/";
            // 
            // tbxDia
            // 
            this.tbxDia.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDia.Location = new System.Drawing.Point(133, 40);
            this.tbxDia.Name = "tbxDia";
            this.tbxDia.Size = new System.Drawing.Size(24, 20);
            this.tbxDia.TabIndex = 6;
            // 
            // tbxFt
            // 
            this.tbxFt.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFt.Location = new System.Drawing.Point(168, 40);
            this.tbxFt.Name = "tbxFt";
            this.tbxFt.Size = new System.Drawing.Size(24, 20);
            this.tbxFt.TabIndex = 5;
            // 
            // lblHt
            // 
            this.lblHt.AutoSize = true;
            this.lblHt.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHt.Location = new System.Drawing.Point(174, 24);
            this.lblHt.Name = "lblHt";
            this.lblHt.Size = new System.Drawing.Size(42, 13);
            this.lblHt.TabIndex = 4;
            this.lblHt.Text = "Height";
            // 
            // tbxSys
            // 
            this.tbxSys.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSys.Location = new System.Drawing.Point(85, 40);
            this.tbxSys.Name = "tbxSys";
            this.tbxSys.Size = new System.Drawing.Size(24, 20);
            this.tbxSys.TabIndex = 3;
            this.tbxSys.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Blood Pressure";
            // 
            // tbxWeight
            // 
            this.tbxWeight.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxWeight.Location = new System.Drawing.Point(8, 40);
            this.tbxWeight.Name = "tbxWeight";
            this.tbxWeight.Size = new System.Drawing.Size(64, 20);
            this.tbxWeight.TabIndex = 1;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(18, 24);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(45, 13);
            this.lblWeight.TabIndex = 0;
            this.lblWeight.Text = "Weight";
            // 
            // grpbxProcedure
            // 
            this.grpbxProcedure.Controls.Add(this.label6);
            this.grpbxProcedure.Controls.Add(this.label5);
            this.grpbxProcedure.Controls.Add(this.listBox1);
            this.grpbxProcedure.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxProcedure.Location = new System.Drawing.Point(256, 16);
            this.grpbxProcedure.Name = "grpbxProcedure";
            this.grpbxProcedure.Size = new System.Drawing.Size(424, 192);
            this.grpbxProcedure.TabIndex = 3;
            this.grpbxProcedure.TabStop = false;
            this.grpbxProcedure.Text = "Medical Procedure";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Symptoms Experienced: ";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Headache",
            "Cold",
            "Dizziness",
            "Muscle Pain",
            "Nausea",
            "Blocked sight",
            "Fever"});
            this.listBox1.Location = new System.Drawing.Point(8, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(176, 95);
            this.listBox1.TabIndex = 0;
            // 
            // toolTipInit
            // 
            this.toolTipInit.ToolTipTitle = "rh";
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(440, 216);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Location = new System.Drawing.Point(608, 216);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 6;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(256, 216);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "label6";
            // 
            // frmReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 246);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grpbxProcedure);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.grpbxMedication);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbxIDNum);
            this.Controls.Add(this.btnAddDB);
            this.Controls.Add(this.lblIDNumber);
            this.Name = "frmReportForm";
            this.Text = "Report Form";
            this.Load += new System.EventHandler(this.frmReportForm_Load);
            this.grpbxMedication.ResumeLayout(false);
            this.grpbxMedication.PerformLayout();
            this.grpbxProcedure.ResumeLayout(false);
            this.grpbxProcedure.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIDNumber;
        private System.Windows.Forms.Button btnAddDB;
        private System.Windows.Forms.TextBox tbxIDNum;
        private System.Windows.Forms.GroupBox grpbxMedication;
        private System.Windows.Forms.TextBox tbxDia;
        private System.Windows.Forms.TextBox tbxFt;
        private System.Windows.Forms.Label lblHt;
        private System.Windows.Forms.TextBox tbxSys;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblSlash;
        private System.Windows.Forms.TextBox tbxIn;
        private System.Windows.Forms.GroupBox grpbxProcedure;
        private System.Windows.Forms.ToolTip toolTipInit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label6;
    }
}