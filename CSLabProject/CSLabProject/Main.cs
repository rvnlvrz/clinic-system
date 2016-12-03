using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSLabProject
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            MdiClient ctlMDI;

            // Loop through all of the form's controls looking
            // for the control of type MdiClient.
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    // Attempt to cast the control to type MdiClient.
                    ctlMDI = (MdiClient)ctl;

                    // Set the Properties of the MdiClient control.
                    ctlMDI.BackColor = this.BackColor;
                    menuStrip.BackColor = Color.FromArgb(245, 245, 245);

                    int ctr = 0;
                    foreach (ToolStripMenuItem itm in menuStrip.Items)
                    {
                        itm.BackColor = Color.FromArgb(245, 245, 245);
                        
                        ctr++;
                    }

                }
                catch (InvalidCastException exc)
                {
                    // Catch and ignore the error if casting failed.
                }
            }

            // Display a child form to show this is still an MDI application.
            StudentDetails m = new StudentDetails();
            m.MdiParent = this;
            m.Show();
        }

        private void windowsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void menuWTileV_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void menuWTileH_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void menuWArrange_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
