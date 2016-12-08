using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace CSLabProject
{
    public partial class frmAddUser : Form
    {
        public static string direc = AppDomain.CurrentDomain.BaseDirectory;
        public static string directory = direc.Replace(@"\bin\Debug\", "");
        public static string currentDirectory = directory + @"\Raw Program Data\";
        string password = "";
        ConsoleKeyInfo key;

        public frmAddUser()
        {
            InitializeComponent();
        }

        private void titlelbl_Click(object sender, EventArgs e)
        {

        }

        private void UserRegistration_Load(object sender, EventArgs e)
        {

        }

        private void lblFname_Click(object sender, EventArgs e)
        {
            if (lblFname.Text != string.Empty)
            {
                fnametxtBox.BackColor = Color.Black;
            }
            else if (lblFname.Text == string.Empty)
            {
                fnametxtBox.BackColor = Color.Red;
            }

        }

        private void lblMiddlename_Click(object sender, EventArgs e)
        {

        }

        private void lblLname_Click(object sender, EventArgs e)
        {
            if (lblLname.Text != string.Empty)
            {
                fnametxtBox.BackColor = Color.Black;
            }
            else if (lblLname.Text == string.Empty)
            {
                fnametxtBox.BackColor = Color.Red;
            }

        }

        private void lblUser_Click(object sender, EventArgs e)
        {
            if (lblUser.Text != string.Empty)
            {
                fnametxtBox.BackColor = Color.Black;
            }
            else if (lblUser.Text == string.Empty)
            {
                fnametxtBox.BackColor = Color.Red;
            }

        }

        private void lblPass_Click(object sender, EventArgs e)
        {
            if (lblFname.Text != string.Empty)
            {
                fnametxtBox.BackColor = Color.Black;
                do
                {
                    key = Console.ReadKey(true);
                    if (key.Key != ConsoleKey.Backspace) // Backspace Should Not Work
                    {
                        password += key.KeyChar;
                        Console.Write("*");
                    }
                } while (key.Key != ConsoleKey.Enter);
            }
            else if (lblFname.Text == string.Empty)
            {
                fnametxtBox.BackColor = Color.Red;
            }

        }

        private void lblConfirmpass_Click(object sender, EventArgs e)
        {

            if (lblFname.Text != string.Empty)
            {
                fnametxtBox.BackColor = Color.Black;

            }
            else if (lblFname.Text == string.Empty)
            {
                fnametxtBox.BackColor = Color.Red;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.Compare(tbxPass.Text, tbxConfirm.Text) != 0)
            {
                MessageBox.Show("Paswords don't match.");
                tbxPass.Focus();
                
            }
            else
            {
                string hash = Encrypt.EncryptString(tbxUser.Text, tbxPass.Text);
                File.AppendAllText("accts.txt", hash + Environment.NewLine);

                MessageBox.Show("The account of " + lblLname.Text + " has been added to the system.");
                Dispose();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void fnametxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void InputStringHandler(object sender, KeyPressEventArgs e)
        {
            // generic input filter for string textbox
            TextBox myBox;
            try
            {
                myBox = (TextBox)sender;
            }
            catch (Exception exc)
            {
                return;
            }

            //The user cannot input the characters sepecified below.
            var regex = new Regex(@"[^a-zA-Z\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (myBox.Text != string.Empty)
            {
                myBox.ForeColor = Color.Black;
            }
        }
    }
}
