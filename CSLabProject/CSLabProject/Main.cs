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
    public partial class frmMain : Form
    {
        public frmMain()
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

            // display intial forms

            //frmStudentDetails m = new frmStudentDetails();
            //m.MdiParent = this;
            //GlobalVar.frmCtrSD++;
            //m.Text += " " + GlobalVar.frmCtrSD.ToString();
            //m.Show();

            //frmStudentDetails m = new frmStudentDetails();
            //m.MdiParent = this;
            //m.Show();

            //frmReportForm myReport = new frmReportForm();
            //myReport.MdiParent = this;
            //myReport.Show();
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
            frmStudentDetails studForm = new frmStudentDetails();
            studForm.MdiParent = this;

            studForm.Show();
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuVInventory_Click(object sender, EventArgs e)
        {
            // checks whether the form is already open and maximizes it
            FormCollection frms = Application.OpenForms;
            foreach (Form frm in frms)
            {
                if (frm.Name == "frmInventory")
                {
                    frm.WindowState = FormWindowState.Maximized;
                    return;
                }
            }

            frmInventory invForm = new frmInventory();
            invForm.MdiParent = this;
            invForm.Show();

        }

        private void menuVDetails_Click(object sender, EventArgs e)
        {
            frmStudentDetails studDet = new frmStudentDetails();
            studDet.MdiParent = this;
            GlobalVar.frmCtrSD++;
            studDet.Text += " " + GlobalVar.frmCtrSD.ToString();
            studDet.Show();
        }

        private void menuVReport_Click(object sender, EventArgs e)
        {
            frmReportForm repForm = new frmReportForm();
            repForm.MdiParent = this;
            repForm.Show();
        }
    }

    public static class GlobalVar
    {
        public static int frmCtrSD = 0;
    }
}
