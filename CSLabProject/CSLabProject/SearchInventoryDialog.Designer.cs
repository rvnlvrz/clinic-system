namespace CSLabProject
{
    partial class SearchInventoryDialog
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
            this.button_Search = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.searchThisItem_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(117, 94);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(89, 38);
            this.button_Search.TabIndex = 0;
            this.button_Search.Text = "SEARCH";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(271, 94);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(89, 38);
            this.button_Cancel.TabIndex = 1;
            this.button_Cancel.Text = "CANCEL";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // searchThisItem_textBox
            // 
            this.searchThisItem_textBox.Location = new System.Drawing.Point(81, 62);
            this.searchThisItem_textBox.Name = "searchThisItem_textBox";
            this.searchThisItem_textBox.Size = new System.Drawing.Size(300, 26);
            this.searchThisItem_textBox.TabIndex = 2;
            this.searchThisItem_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchThisItem_textBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter the item\'s name: ";
            // 
            // SearchInventoryDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 188);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchThisItem_textBox);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Search);
            this.Name = "SearchInventoryDialog";
            this.Text = "SearchInventoryDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.TextBox searchThisItem_textBox;
        private System.Windows.Forms.Label label1;
    }
}