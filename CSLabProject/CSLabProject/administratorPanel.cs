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
    public partial class administratorPanel : Form
    {
        public administratorPanel()
        {
            InitializeComponent();
        }

        private void btn_database_Click(object sender, EventArgs e)
        {
            frmInventory inventoryForm = new frmInventory();
            this.Hide();
            inventoryForm.ShowDialog();
            this.Show();
        }

        private void btn_administration_Click(object sender, EventArgs e)
        {

        }

        private void btn_student_Click(object sender, EventArgs e)
        {
            frmStudentDetails studentDetailsForm = new frmStudentDetails();
            Hide();
            studentDetailsForm.ShowDialog();
            Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure that you wish to logout?", "Administration", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Dispose();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void administratorPanel_Load(object sender, EventArgs e)
        {
            ControlBox = false;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
