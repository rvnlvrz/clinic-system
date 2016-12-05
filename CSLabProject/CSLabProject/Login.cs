using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

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
            SHA256 myCrypt = SHA256Managed.Create();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bntLogIn_Click(object sender, EventArgs e)
        {
            //frmMain mainForm = new frmMain();
            //GlobalVar.frmCtrSD = 0;
            //this.Hide();
            //mainForm.ShowDialog();
            //this.Show();

            //// test the encrypting process
            //string myHashCode = Encrypt.EncryptString(tbxUser.Text, tbxPass.Text);
            //File.WriteAllText("test.txt", myHashCode);
        }
    }
}
