namespace CSLabProject
{
    partial class Main
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWTileH = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWTileV = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWArrange = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.menuWindow});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(699, 24);
            this.menuStrip.TabIndex = 1;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // menuWindow
            // 
            this.menuWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuWCascade,
            this.menuWTileH,
            this.menuWTileV,
            this.menuWArrange,
            this.toolStripSeparator1});
            this.menuWindow.Name = "menuWindow";
            this.menuWindow.Size = new System.Drawing.Size(63, 20);
            this.menuWindow.Text = "&Window";
            this.menuWindow.Click += new System.EventHandler(this.windowsToolStripMenuItem_Click);
            // 
            // menuWCascade
            // 
            this.menuWCascade.Name = "menuWCascade";
            this.menuWCascade.Size = new System.Drawing.Size(152, 22);
            this.menuWCascade.Text = "Cascade";
            this.menuWCascade.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // menuWTileH
            // 
            this.menuWTileH.Name = "menuWTileH";
            this.menuWTileH.Size = new System.Drawing.Size(152, 22);
            this.menuWTileH.Text = "Tile &Horizontal";
            this.menuWTileH.Click += new System.EventHandler(this.menuWTileH_Click);
            // 
            // menuWTileV
            // 
            this.menuWTileV.Name = "menuWTileV";
            this.menuWTileV.Size = new System.Drawing.Size(152, 22);
            this.menuWTileV.Text = "Tile &Vertical";
            this.menuWTileV.Click += new System.EventHandler(this.menuWTileV_Click);
            // 
            // menuWArrange
            // 
            this.menuWArrange.Name = "menuWArrange";
            this.menuWArrange.Size = new System.Drawing.Size(152, 22);
            this.menuWArrange.Text = "&Arrange Icons";
            this.menuWArrange.Click += new System.EventHandler(this.menuWArrange_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(699, 327);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Main";
            this.Text = "MAPÚA - Clinic Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuWindow;
        private System.Windows.Forms.ToolStripMenuItem menuWCascade;
        private System.Windows.Forms.ToolStripMenuItem menuWTileH;
        private System.Windows.Forms.ToolStripMenuItem menuWTileV;
        private System.Windows.Forms.ToolStripMenuItem menuWArrange;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}