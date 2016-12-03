using System;
using System.Windows.Forms;

namespace CSLabProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //StudentDetails m = new StudentDetails();
            //m.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bntLogIn_Click(object sender, EventArgs e)
        {
            Main mainForm = new Main();

            this.Hide();
            mainForm.ShowDialog();
            this.Show();
        }
    }
}
