namespace CSLabProject
{
    partial class AddToInventoryDialog
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
            this.ItemName_txtbx = new System.Windows.Forms.TextBox();
            this.quantity_txtbx = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.itemName_lbl = new System.Windows.Forms.Label();
            this.quantity_lbl = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.AddingAs_txtbx = new System.Windows.Forms.TextBox();
            this.addingAs_lbl = new System.Windows.Forms.Label();
            this.warnLabel = new System.Windows.Forms.Label();
            this.currentDate_txtbx = new System.Windows.Forms.TextBox();
            this.Position_txtbx = new System.Windows.Forms.TextBox();
            this.Position_lbl = new System.Windows.Forms.Label();
            this.CurrentDate_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMedicineType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ItemName_txtbx
            // 
            this.ItemName_txtbx.BackColor = System.Drawing.Color.White;
            this.ItemName_txtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemName_txtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemName_txtbx.ForeColor = System.Drawing.Color.Black;
            this.ItemName_txtbx.Location = new System.Drawing.Point(173, 25);
            this.ItemName_txtbx.Name = "ItemName_txtbx";
            this.ItemName_txtbx.Size = new System.Drawing.Size(357, 28);
            this.ItemName_txtbx.TabIndex = 0;
            this.ItemName_txtbx.Click += new System.EventHandler(this.ItemName_txtbx_Click);
            this.ItemName_txtbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ItemName_txtbx_KeyPress);
            this.ItemName_txtbx.Leave += new System.EventHandler(this.ItemName_txtbx_Leave);
            // 
            // quantity_txtbx
            // 
            this.quantity_txtbx.BackColor = System.Drawing.Color.White;
            this.quantity_txtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quantity_txtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_txtbx.ForeColor = System.Drawing.Color.Black;
            this.quantity_txtbx.Location = new System.Drawing.Point(173, 57);
            this.quantity_txtbx.Name = "quantity_txtbx";
            this.quantity_txtbx.Size = new System.Drawing.Size(103, 28);
            this.quantity_txtbx.TabIndex = 1;
            this.quantity_txtbx.Click += new System.EventHandler(this.quantity_txtbx_Click);
            this.quantity_txtbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantity_txtbx_KeyPress);
            this.quantity_txtbx.Leave += new System.EventHandler(this.quantity_txtbx_Leave);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_add.Location = new System.Drawing.Point(170, 242);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(86, 37);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // itemName_lbl
            // 
            this.itemName_lbl.AutoSize = true;
            this.itemName_lbl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemName_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.itemName_lbl.Location = new System.Drawing.Point(67, 28);
            this.itemName_lbl.Name = "itemName_lbl";
            this.itemName_lbl.Size = new System.Drawing.Size(90, 21);
            this.itemName_lbl.TabIndex = 3;
            this.itemName_lbl.Text = "Item Name:";
            // 
            // quantity_lbl
            // 
            this.quantity_lbl.AutoSize = true;
            this.quantity_lbl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.quantity_lbl.Location = new System.Drawing.Point(84, 60);
            this.quantity_lbl.Name = "quantity_lbl";
            this.quantity_lbl.Size = new System.Drawing.Size(73, 21);
            this.quantity_lbl.TabIndex = 4;
            this.quantity_lbl.Text = "Quantity:";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cancel.Location = new System.Drawing.Point(356, 242);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(86, 37);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "CANCEL";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // AddingAs_txtbx
            // 
            this.AddingAs_txtbx.BackColor = System.Drawing.Color.White;
            this.AddingAs_txtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddingAs_txtbx.Enabled = false;
            this.AddingAs_txtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddingAs_txtbx.ForeColor = System.Drawing.Color.Black;
            this.AddingAs_txtbx.Location = new System.Drawing.Point(173, 126);
            this.AddingAs_txtbx.Name = "AddingAs_txtbx";
            this.AddingAs_txtbx.Size = new System.Drawing.Size(357, 28);
            this.AddingAs_txtbx.TabIndex = 6;
            // 
            // addingAs_lbl
            // 
            this.addingAs_lbl.AutoSize = true;
            this.addingAs_lbl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addingAs_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addingAs_lbl.Location = new System.Drawing.Point(73, 130);
            this.addingAs_lbl.Name = "addingAs_lbl";
            this.addingAs_lbl.Size = new System.Drawing.Size(84, 21);
            this.addingAs_lbl.TabIndex = 7;
            this.addingAs_lbl.Text = "Adding As:";
            // 
            // warnLabel
            // 
            this.warnLabel.AutoSize = true;
            this.warnLabel.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warnLabel.ForeColor = System.Drawing.Color.Yellow;
            this.warnLabel.Location = new System.Drawing.Point(168, 289);
            this.warnLabel.Name = "warnLabel";
            this.warnLabel.Size = new System.Drawing.Size(0, 25);
            this.warnLabel.TabIndex = 8;
            // 
            // currentDate_txtbx
            // 
            this.currentDate_txtbx.BackColor = System.Drawing.Color.White;
            this.currentDate_txtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentDate_txtbx.Enabled = false;
            this.currentDate_txtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDate_txtbx.ForeColor = System.Drawing.Color.Black;
            this.currentDate_txtbx.Location = new System.Drawing.Point(173, 194);
            this.currentDate_txtbx.Name = "currentDate_txtbx";
            this.currentDate_txtbx.Size = new System.Drawing.Size(357, 28);
            this.currentDate_txtbx.TabIndex = 9;
            // 
            // Position_txtbx
            // 
            this.Position_txtbx.BackColor = System.Drawing.Color.White;
            this.Position_txtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Position_txtbx.Enabled = false;
            this.Position_txtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Position_txtbx.ForeColor = System.Drawing.Color.Black;
            this.Position_txtbx.Location = new System.Drawing.Point(173, 160);
            this.Position_txtbx.Name = "Position_txtbx";
            this.Position_txtbx.Size = new System.Drawing.Size(103, 28);
            this.Position_txtbx.TabIndex = 10;
            // 
            // Position_lbl
            // 
            this.Position_lbl.AutoSize = true;
            this.Position_lbl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Position_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Position_lbl.Location = new System.Drawing.Point(89, 163);
            this.Position_lbl.Name = "Position_lbl";
            this.Position_lbl.Size = new System.Drawing.Size(68, 21);
            this.Position_lbl.TabIndex = 11;
            this.Position_lbl.Text = "Position:";
            // 
            // CurrentDate_lbl
            // 
            this.CurrentDate_lbl.AutoSize = true;
            this.CurrentDate_lbl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentDate_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CurrentDate_lbl.Location = new System.Drawing.Point(55, 197);
            this.CurrentDate_lbl.Name = "CurrentDate_lbl";
            this.CurrentDate_lbl.Size = new System.Drawing.Size(102, 21);
            this.CurrentDate_lbl.TabIndex = 12;
            this.CurrentDate_lbl.Text = "Current Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(112, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Type:";
            // 
            // comboBoxMedicineType
            // 
            this.comboBoxMedicineType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMedicineType.FormattingEnabled = true;
            this.comboBoxMedicineType.Items.AddRange(new object[] {
            "Fuck",
            "This",
            "Shit",
            "Screw",
            "Your",
            "Whole",
            "Family"});
            this.comboBoxMedicineType.Location = new System.Drawing.Point(173, 91);
            this.comboBoxMedicineType.Name = "comboBoxMedicineType";
            this.comboBoxMedicineType.Size = new System.Drawing.Size(121, 28);
            this.comboBoxMedicineType.TabIndex = 15;
            // 
            // AddToInventoryDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(598, 323);
            this.Controls.Add(this.comboBoxMedicineType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CurrentDate_lbl);
            this.Controls.Add(this.Position_lbl);
            this.Controls.Add(this.Position_txtbx);
            this.Controls.Add(this.currentDate_txtbx);
            this.Controls.Add(this.warnLabel);
            this.Controls.Add(this.addingAs_lbl);
            this.Controls.Add(this.AddingAs_txtbx);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.quantity_lbl);
            this.Controls.Add(this.itemName_lbl);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.quantity_txtbx);
            this.Controls.Add(this.ItemName_txtbx);
            this.Name = "AddToInventoryDialog";
            this.Text = "Add To Inventory";
            this.Load += new System.EventHandler(this.AddToInventoryDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ItemName_txtbx;
        private System.Windows.Forms.TextBox quantity_txtbx;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label itemName_lbl;
        private System.Windows.Forms.Label quantity_lbl;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox AddingAs_txtbx;
        private System.Windows.Forms.Label addingAs_lbl;
        private System.Windows.Forms.Label warnLabel;
        private System.Windows.Forms.TextBox currentDate_txtbx;
        private System.Windows.Forms.TextBox Position_txtbx;
        private System.Windows.Forms.Label Position_lbl;
        private System.Windows.Forms.Label CurrentDate_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxMedicineType;
    }
}