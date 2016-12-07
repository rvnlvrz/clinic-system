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
                    //menuStrip.BackColor = Color.FromArgb(245, 245, 245);

                }
                catch (InvalidCastException exc)
                {
                    // Catch and ignore the error if casting failed.
                }
            }

            frmReportForm myReport = new frmReportForm();
            myReport.MdiParent = this;
            myReport.Show();

           
            StudentDetails m = new StudentDetails();
            m.MdiParent = this;
            GlobalVar.frmCtrSD++;
            m.Text += " " + GlobalVar.frmCtrSD.ToString();
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
            Dispose();
        }

        private void studentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentDetails studForm = new StudentDetails();
            studForm.MdiParent = this;
            GlobalVar.frmCtrSD++;
            studForm.Text += " " + GlobalVar.frmCtrSD.ToString();
            studForm.Show();
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventory inventoryForm = new Inventory();
            inventoryForm.MdiParent = this;
            GlobalVar.frmCtrSD++;
            inventoryForm.Text += " " + GlobalVar.frmCtrSD.ToString();
            inventoryForm.Show();
        }
    }

    public static class GlobalVar
    {
        public static int frmCtrSD = 0;
    }
}
