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
            this.add_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ItemName_txtbx
            // 
            this.ItemName_txtbx.BackColor = System.Drawing.Color.White;
            this.ItemName_txtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemName_txtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemName_txtbx.ForeColor = System.Drawing.Color.Black;
            this.ItemName_txtbx.Location = new System.Drawing.Point(170, 71);
            this.ItemName_txtbx.Name = "ItemName_txtbx";
            this.ItemName_txtbx.Size = new System.Drawing.Size(357, 28);
            this.ItemName_txtbx.TabIndex = 0;
            // 
            // quantity_txtbx
            // 
            this.quantity_txtbx.BackColor = System.Drawing.Color.White;
            this.quantity_txtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quantity_txtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_txtbx.ForeColor = System.Drawing.Color.Black;
            this.quantity_txtbx.Location = new System.Drawing.Point(170, 103);
            this.quantity_txtbx.Name = "quantity_txtbx";
            this.quantity_txtbx.Size = new System.Drawing.Size(103, 28);
            this.quantity_txtbx.TabIndex = 1;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_add.Location = new System.Drawing.Point(170, 155);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(86, 37);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = false;
            // 
            // itemName_lbl
            // 
            this.itemName_lbl.AutoSize = true;
            this.itemName_lbl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemName_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.itemName_lbl.Location = new System.Drawing.Point(68, 74);
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
            this.quantity_lbl.Location = new System.Drawing.Point(83, 105);
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
            this.btn_cancel.Location = new System.Drawing.Point(356, 155);
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
            this.AddingAs_txtbx.Location = new System.Drawing.Point(170, 39);
            this.AddingAs_txtbx.Name = "AddingAs_txtbx";
            this.AddingAs_txtbx.Size = new System.Drawing.Size(357, 28);
            this.AddingAs_txtbx.TabIndex = 6;
            // 
            // add_lbl
            // 
            this.add_lbl.AutoSize = true;
            this.add_lbl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add_lbl.Location = new System.Drawing.Point(70, 43);
            this.add_lbl.Name = "add_lbl";
            this.add_lbl.Size = new System.Drawing.Size(84, 21);
            this.add_lbl.TabIndex = 7;
            this.add_lbl.Text = "Adding As:";
            // 
            // AddToInventoryDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(587, 204);
            this.Controls.Add(this.add_lbl);
            this.Controls.Add(this.AddingAs_txtbx);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.quantity_lbl);
            this.Controls.Add(this.itemName_lbl);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.quantity_txtbx);
            this.Controls.Add(this.ItemName_txtbx);
            this.Name = "AddToInventoryDialog";
            this.Text = "Add To Inventory";
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
        private System.Windows.Forms.Label add_lbl;
    }
}