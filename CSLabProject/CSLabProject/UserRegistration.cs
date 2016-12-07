using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CSLabProject
{
    public partial class UserRegistration : Form
    {
        public static string direc = AppDomain.CurrentDomain.BaseDirectory;
        public static string directory = direc.Replace(@"\bin\Debug\", "");
        public static string currentDirectory = directory + @"\Raw Program Data\";
        string password = "";
        ConsoleKeyInfo key;

        public UserRegistration()
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
           if(lblFname.Text != string.Empty)
            {
                fnametxtBox.BackColor = Color.Black;
            }
           else if(lblFname.Text == string.Empty)
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
            currentDirectory += @"\" + lblLname.Text + @"\";
            Directory.CreateDirectory(currentDirectory);
            File.WriteAllText(currentDirectory + lblLname.Text + ".txt", lblLname.Text + Environment.NewLine);
            File.AppendAllText(currentDirectory + lblLname.Text + ".txt", lblFname.Text + Environment.NewLine);
            File.AppendAllText(currentDirectory + lblLname.Text + ".txt", lblMiddlename.Text + Environment.NewLine);
            File.AppendAllText(currentDirectory + lblLname.Text + ".txt", lblUser.Text + Environment.NewLine);
            File.AppendAllText(currentDirectory + lblLname.Text + ".txt", lblConfirmpass.Text + Environment.NewLine);

            MessageBox.Show("The account of " + lblLname.Text + " has been added to the system.");
            Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void fnametxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
