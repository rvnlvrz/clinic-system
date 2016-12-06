namespace CSLabProject
{
    partial class Inventory
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
            this.inventoryGrid = new System.Windows.Forms.ListView();
            this.NameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QuantityHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unitHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserAssignmentHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserTypeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpbxInventoryTools = new System.Windows.Forms.GroupBox();
            this.BTNdeleteItem = new System.Windows.Forms.Button();
            this.BTNModifyItem = new System.Windows.Forms.Button();
            this.BTNdsearchItem = new System.Windows.Forms.Button();
            this.BTNcreateNew = new System.Windows.Forms.Button();
            this.UserName = new System.Windows.Forms.Label();
            this.userPosition = new System.Windows.Forms.Label();
            this.grpbxUserDetails = new System.Windows.Forms.GroupBox();
            this.userAvatar = new System.Windows.Forms.PictureBox();
            this.CreateTT = new System.Windows.Forms.ToolTip(this.components);
            this.RemoveTT = new System.Windows.Forms.ToolTip(this.components);
            this.EditTT = new System.Windows.Forms.ToolTip(this.components);
            this.SearchTT = new System.Windows.Forms.ToolTip(this.components);
            this.commenceSearch_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.BTNclose = new System.Windows.Forms.Button();
            this.searchKey_txtbox = new System.Windows.Forms.TextBox();
            this.grpbxInventoryTools.SuspendLayout();
            this.grpbxUserDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userAvatar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inventoryGrid
            // 
            this.inventoryGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryGrid.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameHeader,
            this.QuantityHeader,
            this.unitHeader,
            this.DateHeader,
            this.UserAssignmentHeader,
            this.UserTypeHeader});
            this.inventoryGrid.GridLines = true;
            this.inventoryGrid.Location = new System.Drawing.Point(0, 108);
            this.inventoryGrid.Name = "inventoryGrid";
            this.inventoryGrid.Scrollable = false;
            this.inventoryGrid.Size = new System.Drawing.Size(1276, 498);
            this.inventoryGrid.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.inventoryGrid.TabIndex = 4;
            this.inventoryGrid.UseCompatibleStateImageBehavior = false;
            this.inventoryGrid.View = System.Windows.Forms.View.Details;
            // 
            // NameHeader
            // 
            this.NameHeader.Text = "Item Name";
            this.NameHeader.Width = 314;
            // 
            // QuantityHeader
            // 
            this.QuantityHeader.Text = "Item Quantity";
            this.QuantityHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.QuantityHeader.Width = 143;
            // 
            // unitHeader
            // 
            this.unitHeader.Text = "Type";
            this.unitHeader.Width = 140;
            // 
            // DateHeader
            // 
            this.DateHeader.Text = "Date Added";
            this.DateHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DateHeader.Width = 344;
            // 
            // UserAssignmentHeader
            // 
            this.UserAssignmentHeader.Text = "Added By";
            this.UserAssignmentHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UserAssignmentHeader.Width = 191;
            // 
            // UserTypeHeader
            // 
            this.UserTypeHeader.Text = "Position";
            this.UserTypeHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UserTypeHeader.Width = 142;
            // 
            // grpbxInventoryTools
            // 
            this.grpbxInventoryTools.Controls.Add(this.BTNdeleteItem);
            this.grpbxInventoryTools.Controls.Add(this.BTNModifyItem);
            this.grpbxInventoryTools.Controls.Add(this.BTNdsearchItem);
            this.grpbxInventoryTools.Controls.Add(this.BTNcreateNew);
            this.grpbxInventoryTools.Location = new System.Drawing.Point(23, 11);
            this.grpbxInventoryTools.Name = "grpbxInventoryTools";
            this.grpbxInventoryTools.Size = new System.Drawing.Size(209, 74);
            this.grpbxInventoryTools.TabIndex = 5;
            this.grpbxInventoryTools.TabStop = false;
            this.grpbxInventoryTools.Text = "Inventory Tools";
            // 
            // BTNdeleteItem
            // 
            this.BTNdeleteItem.Image = global::CSLabProject.Properties.Resources.ic_remove_circle_outline_black_18dp_1x;
            this.BTNdeleteItem.Location = new System.Drawing.Point(61, 25);
            this.BTNdeleteItem.Name = "BTNdeleteItem";
            this.BTNdeleteItem.Size = new System.Drawing.Size(43, 38);
            this.BTNdeleteItem.TabIndex = 7;
            this.RemoveTT.SetToolTip(this.BTNdeleteItem, "Remove an existing inventory record.");
            this.BTNdeleteItem.UseVisualStyleBackColor = true;
            this.BTNdeleteItem.Click += new System.EventHandler(this.BTNdeleteItem_Click);
            // 
            // BTNModifyItem
            // 
            this.BTNModifyItem.Image = global::CSLabProject.Properties.Resources.ic_create_black_18dp_1x;
            this.BTNModifyItem.Location = new System.Drawing.Point(107, 25);
            this.BTNModifyItem.Name = "BTNModifyItem";
            this.BTNModifyItem.Size = new System.Drawing.Size(43, 38);
            this.BTNModifyItem.TabIndex = 6;
            this.EditTT.SetToolTip(this.BTNModifyItem, "Edit an existing inventory record.");
            this.BTNModifyItem.UseVisualStyleBackColor = true;
            // 
            // BTNdsearchItem
            // 
            this.BTNdsearchItem.Image = global::CSLabProject.Properties.Resources.ic_search_black_18dp_1x;
            this.BTNdsearchItem.Location = new System.Drawing.Point(153, 25);
            this.BTNdsearchItem.Name = "BTNdsearchItem";
            this.BTNdsearchItem.Size = new System.Drawing.Size(42, 38);
            this.BTNdsearchItem.TabIndex = 5;
            this.SearchTT.SetToolTip(this.BTNdsearchItem, "Search the inventory for an existing record.");
            this.BTNdsearchItem.UseVisualStyleBackColor = true;
            this.BTNdsearchItem.Click += new System.EventHandler(this.BTNdsearchItem_Click);
            // 
            // BTNcreateNew
            // 
            this.BTNcreateNew.Image = global::CSLabProject.Properties.Resources.ic_note_add_black_18dp_1x;
            this.BTNcreateNew.Location = new System.Drawing.Point(16, 25);
            this.BTNcreateNew.Name = "BTNcreateNew";
            this.BTNcreateNew.Size = new System.Drawing.Size(43, 38);
            this.BTNcreateNew.TabIndex = 4;
            this.CreateTT.SetToolTip(this.BTNcreateNew, "Add a new record to the inventory.");
            this.BTNcreateNew.UseVisualStyleBackColor = true;
            this.BTNcreateNew.Click += new System.EventHandler(this.BTNcreateNew_Click);
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(10, 26);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(206, 21);
            this.UserName.TabIndex = 8;
            this.UserName.Text = "This is where the name goes";
            // 
            // userPosition
            // 
            this.userPosition.AutoSize = true;
            this.userPosition.Location = new System.Drawing.Point(12, 49);
            this.userPosition.Name = "userPosition";
            this.userPosition.Size = new System.Drawing.Size(105, 21);
            this.userPosition.TabIndex = 9;
            this.userPosition.Text = "Nurse/Doctor";
            // 
            // grpbxUserDetails
            // 
            this.grpbxUserDetails.Controls.Add(this.userPosition);
            this.grpbxUserDetails.Controls.Add(this.UserName);
            this.grpbxUserDetails.Controls.Add(this.userAvatar);
            this.grpbxUserDetails.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxUserDetails.Location = new System.Drawing.Point(968, 12);
            this.grpbxUserDetails.Name = "grpbxUserDetails";
            this.grpbxUserDetails.Size = new System.Drawing.Size(291, 74);
            this.grpbxUserDetails.TabIndex = 6;
            this.grpbxUserDetails.TabStop = false;
            this.grpbxUserDetails.Text = "Logged in as";
            // 
            // userAvatar
            // 
            this.userAvatar.Location = new System.Drawing.Point(231, 15);
            this.userAvatar.Name = "userAvatar";
            this.userAvatar.Size = new System.Drawing.Size(52, 54);
            this.userAvatar.TabIndex = 7;
            this.userAvatar.TabStop = false;
            // 
            // CreateTT
            // 
            this.CreateTT.IsBalloon = true;
            // 
            // RemoveTT
            // 
            this.RemoveTT.IsBalloon = true;
            // 
            // EditTT
            // 
            this.EditTT.IsBalloon = true;
            // 
            // SearchTT
            // 
            this.SearchTT.IsBalloon = true;
            // 
            // commenceSearch_btn
            // 
            this.commenceSearch_btn.Image = global::CSLabProject.Properties.Resources.ic_search_black_18dp_1x;
            this.commenceSearch_btn.Location = new System.Drawing.Point(806, 35);
            this.commenceSearch_btn.Name = "commenceSearch_btn";
            this.commenceSearch_btn.Size = new System.Drawing.Size(42, 38);
            this.commenceSearch_btn.TabIndex = 8;
            this.SearchTT.SetToolTip(this.commenceSearch_btn, "Search the inventory for an existing record.");
            this.commenceSearch_btn.UseVisualStyleBackColor = true;
            this.commenceSearch_btn.Click += new System.EventHandler(this.commenceSearch_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Confirm);
            this.groupBox1.Controls.Add(this.BTNclose);
            this.groupBox1.Location = new System.Drawing.Point(238, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 74);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Window Options";
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Confirm.Image = global::CSLabProject.Properties.Resources.ic_check_black_18dp_1x;
            this.btn_Confirm.Location = new System.Drawing.Point(71, 23);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(43, 38);
            this.btn_Confirm.TabIndex = 8;
            this.btn_Confirm.UseVisualStyleBackColor = false;
            // 
            // BTNclose
            // 
            this.BTNclose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNclose.Image = global::CSLabProject.Properties.Resources.ic_close_black_18dp_1x;
            this.BTNclose.Location = new System.Drawing.Point(22, 23);
            this.BTNclose.Name = "BTNclose";
            this.BTNclose.Size = new System.Drawing.Size(43, 38);
            this.BTNclose.TabIndex = 7;
            this.BTNclose.UseVisualStyleBackColor = false;
            this.BTNclose.Click += new System.EventHandler(this.BTNclose_Click);
            // 
            // searchKey_txtbox
            // 
            this.searchKey_txtbox.Location = new System.Drawing.Point(478, 42);
            this.searchKey_txtbox.Name = "searchKey_txtbox";
            this.searchKey_txtbox.Size = new System.Drawing.Size(322, 26);
            this.searchKey_txtbox.TabIndex = 9;
            this.searchKey_txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchKey_txtbox_KeyPress);
            this.searchKey_txtbox.Leave += new System.EventHandler(this.searchKey_txtbox_Leave);
            // 
            // Inventory
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1276, 608);
            this.Controls.Add(this.commenceSearch_btn);
            this.Controls.Add(this.searchKey_txtbox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpbxUserDetails);
            this.Controls.Add(this.grpbxInventoryTools);
            this.Controls.Add(this.inventoryGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.grpbxInventoryTools.ResumeLayout(false);
            this.grpbxUserDetails.ResumeLayout(false);
            this.grpbxUserDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userAvatar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView inventoryGrid;
        private System.Windows.Forms.ColumnHeader NameHeader;
        private System.Windows.Forms.ColumnHeader QuantityHeader;
        private System.Windows.Forms.ColumnHeader DateHeader;
        private System.Windows.Forms.ColumnHeader UserAssignmentHeader;
        private System.Windows.Forms.ColumnHeader UserTypeHeader;
        private System.Windows.Forms.GroupBox grpbxInventoryTools;
        private System.Windows.Forms.Button BTNdsearchItem;
        private System.Windows.Forms.Button BTNcreateNew;
        private System.Windows.Forms.Button BTNModifyItem;
        private System.Windows.Forms.Button BTNdeleteItem;
        private System.Windows.Forms.PictureBox userAvatar;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label userPosition;
        private System.Windows.Forms.GroupBox grpbxUserDetails;
        private System.Windows.Forms.ToolTip CreateTT;
        private System.Windows.Forms.ToolTip RemoveTT;
        private System.Windows.Forms.ToolTip EditTT;
        private System.Windows.Forms.ToolTip SearchTT;
        private System.Windows.Forms.Button BTNclose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.ColumnHeader unitHeader;
        private System.Windows.Forms.TextBox searchKey_txtbox;
        private System.Windows.Forms.Button commenceSearch_btn;
    }
}