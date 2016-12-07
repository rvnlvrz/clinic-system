using System;
using System.Windows.Forms;
using System.IO;

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
            
        }

        private void bntLogIn_Click(object sender, EventArgs e)
        {
            //// test the encrypting process
            //string myHashCode = Encrypt.EncryptString(tbxUser.Text, tbxPass.Text);
            //File.WriteAllText("test.txt", myHashCode);

            string defCode = "UJifg1yjRhG9l4RoYkZm+w==";

            if (!File.Exists(@"accts.txt"))
            {
                File.WriteAllText(@"accts.txt", defCode);
            }

            // check login
            string userCipher = Encrypt.EncryptString(tbxUser.Text, tbxPass.Text);
            string[] definedCipher = File.ReadAllLines(@"accts.txt");
            Form activeForm = Form.ActiveForm;
            
            for (int x = 0; x < definedCipher.Length; x++)
            {
                if (string.Compare(userCipher, definedCipher[0]) == 0)
                {
                    MessageBox.Show("Access granted as admin.", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GlobalVar.accessUser = tbxUser.Text;

                    administratorPanel mainForm = new administratorPanel();
                    GlobalVar.frmCtrSD = 0;
                    this.Hide();
                    mainForm.ShowDialog();
                    this.Show();

                    foreach (Control ctrl in activeForm.Controls)
                    {
                        if (ctrl is TextBox)
                            ctrl.ResetText();
                    }
                    return;
                }
                if (string.Compare(userCipher, definedCipher[x]) == 0)
                {
                    MessageBox.Show("Access granted as a user.", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GlobalVar.accessUser = tbxUser.Text;

                    frmMain mainForm = new frmMain();
                    GlobalVar.frmCtrSD = 0;
                    this.Hide();
                    mainForm.ShowDialog();
                    this.Show();

                    foreach (Control ctrl in activeForm.Controls)
                    {
                        if (ctrl is TextBox)
                            ctrl.ResetText();
                    }
                    return;
                }
            }

            // this code will only be reached if the credentials are invalid
            MessageBox.Show("The credentials you have typed doesn't exist in the accounts list.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            foreach (Control ctrl in activeForm.Controls)
            {
                if (ctrl is TextBox)
                    ctrl.ResetText();

                if (ctrl.Name == "tbxUser")
                    ctrl.Focus();
            }

            
        }


    }
}
