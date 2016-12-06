using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Text;

namespace CSLabProject
{
    public partial class frmLogin : Form
    {
        public frmLogin()
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
            //// test the encrypting process
            //string myHashCode = Encrypt.EncryptString(tbxUser.Text, tbxPass.Text);
            //File.WriteAllText("test.txt", myHashCode);

            // check login
            string userCipher = Encrypt.EncryptString(tbxUser.Text, tbxPass.Text);
            string[] definedCipher = File.ReadAllLines(@"test.txt");

            for (int x = 0; x < definedCipher.Length; x++)
            {
                if (string.Compare(userCipher, definedCipher[x]) == 0)
                {
                    MessageBox.Show("Access granted as [ADMIN]", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frmMain mainForm = new frmMain();
                    GlobalVar.frmCtrSD = 0;
                    this.Hide();
                    mainForm.ShowDialog();
                    this.Show();
                    return;
                }
            }

            // this code will only be reached if the credentials are invalid
            MessageBox.Show("The credentials you have typed doesn't exist in the accounts list.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Form activeForm = Form.ActiveForm;

            foreach(Control ctrl in activeForm.Controls)
            {
                if (ctrl is TextBox)
                    ctrl.ResetText();
            }
        }
    }
}
