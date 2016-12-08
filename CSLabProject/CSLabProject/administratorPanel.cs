using System;
using System.Windows.Forms;

namespace CSLabProject
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void btn_database_Click(object sender, EventArgs e)
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
            invForm.MdiParent = frmMain.ActiveForm;
            invForm.Show();
        }

        private void btn_administration_Click(object sender, EventArgs e)
        {
            frmAddUser myAddForm = new frmAddUser();
            myAddForm.Show();

        }

        private void btn_student_Click(object sender, EventArgs e)
        {
            frmStudentDetails studentDetailsForm = new frmStudentDetails();
            studentDetailsForm.Show();

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure that you wish to logout?", "Administration", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Form parent = frmMain.ActiveForm;
                parent.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                ;
            }
        }

        private void administratorPanel_Load(object sender, EventArgs e)
        {
            ControlBox = false;
            lblUser.Text = GlobalVar.accessUser;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_employee_Click(object sender, EventArgs e)
        {
            frmEmployee myEmp = new frmEmployee();
            myEmp.Show();

        }

        private void frmAdmin_ResizeEnd(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }
    }
}
