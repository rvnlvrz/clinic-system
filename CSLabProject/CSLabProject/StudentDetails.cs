using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace CSLabProject
{
    public partial class StudentDetails : Form
    {
        public StudentDetails()
        {
            InitializeComponent();
        }

        private void StudentDetails_Load(object sender, EventArgs e)
        {   
            //Do not allow the user to leave a textbox empty.
            ControlBox = false;
            comboBoxRelationship.SelectedIndex = 1;
            string direc = AppDomain.CurrentDomain.BaseDirectory;
            string directory = direc.Replace(@"\bin\Debug\", "");
            globals.currentDirectory = directory + @"\Raw Program Data\";
            //MessageBox.Show(directory);

            //foreach (TextBox tb in student_grpbx.Controls.OfType<TextBox>().Where(x => x.CausesValidation == true))
            //{
            //    tb.Validating += textBox_Validating;
            //}
            //foreach (TextBox tb in guradian_grpbx.Controls.OfType<TextBox>().Where(x => x.CausesValidation == true))
            //{
            //    tb.Validating += textBox_Validating;
            //}
        }

        public class globals
        {
            public static string currentDirectory = ""; /*Helps the program identify where to store obtained data.*/
        }

        private void textBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox currenttb = (TextBox)sender;
            if (currenttb.Text == "")
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                warning_label.Text = string.Empty;
            }
        }

        private void STUD_textBoxFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //The user cannot input the characters sepecified below.
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[^?:\\/:*?\""<>|0-9]"))
            {
                e.Handled = true;
            }
            else if (STUD_textBoxFirstName.Text != string.Empty)
            {
                LabelStudentFirstName.ForeColor = Color.Black;

            }
        }

        private void STUD_textBoxFLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //The user cannot input the characters sepecified below.
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[^?:\\/:*?\""<>|0-9]"))
            {
                e.Handled = true;
            }
            else if (STUD_textBoxLastName.Text != string.Empty)
            {
                LabelStudentLastName.ForeColor = Color.Black;
            }
        }

        private void STUD_textBoxMI_KeyPress(object sender, KeyPressEventArgs e)
        {
            //The user cannot input the characters sepecified below.
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[^?:\\/:*?\""<>|0-9]"))
            {
                e.Handled = true;
            }
            else if (STUD_textBoxMI.Text != string.Empty)
            {
                LabelStudentMI.ForeColor = Color.Black;
            }
        }

        private void STUD_textBoxMobileNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[^?:\\/:*?\""<>|a-zA-Z]"))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
            if (STUD_textBoxMobileNum.Text != string.Empty)
            {
                LabelStudentMobileNumber.ForeColor = Color.Black;
            }
        }

        private void STUD_textBoxLandLine_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[^?:\\/:*?\""<>|a-zA-Z+[$]"))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else if (STUD_textBoxLandLine.Text != string.Empty)
            {
                LabelStudentLandLineNumber.ForeColor = Color.Black;
            }
        }

        private void STUD_textBoxAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[^?:\\/:*?\""<>|a-zA-Z+[$]"))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else if (STUD_textBoxAge.Text.Length == 2)
            {
                e.Handled = true;
            }
            else if (STUD_textBoxAge.Text != string.Empty)
            {
                LabelStudentAge.ForeColor = Color.Black;
            }
        }

        private void STUD_textBoxYrLvl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[^?:\\/:*?\""<>|a-zA-Z+[$]"))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else if (STUD_textBoxYrLvl.Text.Length == 1)
            {
                e.Handled = true;
            }
            if (STUD_textBoxYrLvl.Text != string.Empty)
            {
                LabelStudentYearLevel.ForeColor = Color.Black;
            }
        }

        private void STUD_textBoxStudentNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[^?:\\/:*?\""<>|a-zA-Z+[$]"))
            {
                e.Handled = true;
            }

            else if (STUD_textBoxStudentNumber.Text.Length == 10)
            {
                e.Handled = true;
            }

            else if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
            if (STUD_textBoxStudentNumber.Text != string.Empty)
            {
                LabelStudentNumber.ForeColor = Color.Black;
            }
        }

        private void STUD_textBoxFirstName_Leave(object sender, EventArgs e)
        {
            if (STUD_textBoxFirstName.Text == string.Empty)
            {
                LabelStudentFirstName.ForeColor = Color.Red;

            }
            else
            {
                LabelStudentFirstName.ForeColor = Color.Black;
            }
        }

        private void STUD_textBoxLastName_Leave(object sender, EventArgs e)
        {
            if (STUD_textBoxLastName.Text == string.Empty)
            {
                LabelStudentLastName.ForeColor = Color.Red;
            }
            else
            {
                LabelStudentLastName.ForeColor = Color.Black;
            }
        }

        private void STUD_textBoxMI_Leave(object sender, EventArgs e)
        {
            if (STUD_textBoxMI.Text == string.Empty)
            {
                LabelStudentMI.ForeColor = Color.Red;
            }
            else
            {
                LabelStudentMI.ForeColor = Color.Black;
            }
        }

        private void STUD_textBoxAge_Leave(object sender, EventArgs e)
        {
            if (STUD_textBoxAge.Text == string.Empty)
            {
                LabelStudentAge.ForeColor = Color.Red;
            }
            else
            {
                LabelStudentAge.ForeColor = Color.Black;
            }
        }

        private void STUD_textBoxStudentNumber_Leave(object sender, EventArgs e)
        {
            if (STUD_textBoxStudentNumber.Text == string.Empty)
            {
                LabelStudentNumber.ForeColor = Color.Red;
            }
            else
            {
                LabelStudentNumber.ForeColor = Color.Black;
            }
        }

        private void STUD_textBoxProram_Leave(object sender, EventArgs e)
        {
            if (STUD_textBoxProram.Text == string.Empty)
            {
                LabelStudentProgram.ForeColor = Color.Red;
            }
            else
            {
                LabelStudentProgram.ForeColor = Color.Black;
            }
        }

        private void STUD_textBoxYrLvl_Leave(object sender, EventArgs e)
        {
            if (STUD_textBoxYrLvl.Text == string.Empty)
            {
                LabelStudentYearLevel.ForeColor = Color.Red;
            }
            else
            {
                LabelStudentYearLevel.ForeColor = Color.Black;
            }
        }

        private void STUD_textBoxMobileNum_Leave(object sender, EventArgs e)
        {
            if (STUD_textBoxMobileNum.Text == string.Empty)
            {
                LabelStudentMobileNumber.ForeColor = Color.Red;
            }
            else
            {
                LabelStudentMobileNumber.ForeColor = Color.Black;
            }
        }

        private void STUD_textBoxLandLine_Leave(object sender, EventArgs e)
        {
            if (STUD_textBoxLandLine.Text == string.Empty)
            {
                LabelStudentLandLineNumber.ForeColor = Color.Red;
            }
            else
            {
                LabelStudentLandLineNumber.ForeColor = Color.Black;
            }
        }

        private void STUD_textBoxProram_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[^?:\\/:*?\""<>|0-9]"))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else if (STUD_textBoxProram.Text.Length == 4)
            {
                e.Handled = true;
            }
        }

        private void GRDN_textBoxFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //The user cannot input the characters sepecified below.
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[^?:\\/:*?\""<>|0-9]"))
            {
                e.Handled = true;
            }
            if (GRDN_textBoxFirstName.Text != string.Empty)
            {
                LabelGuardianFirstName.ForeColor = Color.Black;
            }
        }

        private void GRDN_textBoxLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //The user cannot input the characters sepecified below.
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[^?:\\/:*?\""<>|0-9]"))
            {
                e.Handled = true;
            }
            if (GRDN_textBoxLastName.Text != string.Empty)
            {
                LabelGuardianLastlName.ForeColor = Color.Black;
            }
        }

        private void GRDN_textBoxMI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[^?:\\/:*?\""<>|0-9]"))
            {
                e.Handled = true;
            }
            if (GRDN_textBoxMI.Text != string.Empty)
            {
                LabelGuardianMI.ForeColor = Color.Black;
            }
        }

        private void GRDN_textBoxMobileNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[^?:\\/:*?\""<>|a-zA-Z+$]"))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
            if (GRDN_textBoxMobileNum.Text != string.Empty)
            {
                LabelGuardianMobileNumber.ForeColor = Color.Black;
            }
        }

        private void GRDN_textBoxLandLine_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[^?:\\/:*?\""<>|a-zA-Z+$]"))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
            if (GRDN_textBoxLandLine.Text != string.Empty)
            {
                LabelGuardianLandLineNumber.ForeColor = Color.Black;
            }
        }

        private void buttonCLR_Click(object sender, EventArgs e)
        {
            STUD_textBoxFirstName.Text = string.Empty;
            STUD_textBoxLastName.Text = string.Empty;
            STUD_textBoxMI.Text = string.Empty;
            STUD_textBoxMobileNum.Text = string.Empty;
            STUD_textBoxLandLine.Text = string.Empty;

            GRDN_textBoxFirstName.Text = string.Empty;
            GRDN_textBoxLastName.Text = string.Empty;
            GRDN_textBoxMI.Text = string.Empty;
            GRDN_textBoxMobileNum.Text = string.Empty;
            GRDN_textBoxLandLine.Text = string.Empty;
        }

        private void GRDN_textBoxFirstName_Leave(object sender, EventArgs e)
        {
            if (GRDN_textBoxFirstName.Text == string.Empty)
            {
                LabelGuardianFirstName.ForeColor = Color.Red;
            }
            else
            {
                LabelGuardianFirstName.ForeColor = Color.Black;
            }
        }

        private void GRDN_textBoxLastName_Leave(object sender, EventArgs e)
        {
            if (GRDN_textBoxLastName.Text == string.Empty)
            {
                LabelGuardianLastlName.ForeColor = Color.Red;
            }
            else
            {
                LabelGuardianLastlName.ForeColor = Color.Black;
            }
        }

        private void GRDN_textBoxMobileNum_Leave(object sender, EventArgs e)
        {
            if (GRDN_textBoxMobileNum.Text == string.Empty)
            {
                LabelGuardianMobileNumber.ForeColor = Color.Red;
            }
            else
            {
                LabelGuardianMobileNumber.ForeColor = Color.Black;
            }
        }

        private void GRDN_textBoxLandLine_Leave(object sender, EventArgs e)
        {
            if (GRDN_textBoxLandLine.Text == string.Empty)
            {
                LabelGuardianLandLineNumber.ForeColor = Color.Red;
            }
            else
            {
                LabelGuardianLandLineNumber.ForeColor = Color.Black;
            }
        }

        private void GRDN_textBoxMI_Leave(object sender, EventArgs e)
        {
            if (GRDN_textBoxMI.Text == string.Empty)
            {
                LabelGuardianMI.ForeColor = Color.Red;
            }
            else
            {
                LabelGuardianMI.ForeColor = Color.Black;
            }
        }

        public bool checkForNullStrings()
        {
            if(STUD_textBoxFirstName.Text != string.Empty && STUD_textBoxLastName.Text != string.Empty 
                && STUD_textBoxMI.Text != string.Empty && STUD_textBoxLandLine.Text != string.Empty 
                && STUD_textBoxMobileNum.Text != string.Empty && GRDN_textBoxFirstName.Text != string.Empty 
                && GRDN_textBoxLastName.Text != string.Empty && GRDN_textBoxMI.Text != string.Empty 
                && GRDN_textBoxLandLine.Text != string.Empty && GRDN_textBoxMobileNum.Text != string.Empty)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public void highlightNullTextBox()
        {

        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            bool confirmNoneAreNull = checkForNullStrings();
            if (STUD_textBoxFirstName.Text.Length == 1)
            {
                warning_label.Text = "First name must consist of Two or more characters.";
            }
            else
            {
                warning_label.Text = string.Empty;
            }
            if (confirmNoneAreNull)
            {
                globals.currentDirectory += @"\" + STUD_textBoxLastName.Text + @"\";
                Directory.CreateDirectory(globals.currentDirectory);
                File.WriteAllText(globals.currentDirectory + STUD_textBoxLastName.Text + ".txt", STUD_textBoxFirstName.Text + Environment.NewLine);
                File.AppendAllText(globals.currentDirectory + STUD_textBoxLastName.Text + ".txt", STUD_textBoxLastName.Text + Environment.NewLine);
                File.AppendAllText(globals.currentDirectory + STUD_textBoxLastName.Text + ".txt", STUD_textBoxMI.Text + Environment.NewLine);
                File.AppendAllText(globals.currentDirectory + STUD_textBoxLastName.Text + ".txt", STUD_textBoxAge.Text + Environment.NewLine);
                File.AppendAllText(globals.currentDirectory + STUD_textBoxLastName.Text + ".txt", STUD_textBoxStudentNumber.Text + Environment.NewLine);
                File.AppendAllText(globals.currentDirectory + STUD_textBoxLastName.Text + ".txt", STUD_textBoxProram.Text + Environment.NewLine);
                File.AppendAllText(globals.currentDirectory + STUD_textBoxLastName.Text + ".txt", STUD_textBoxYrLvl.Text + Environment.NewLine);
                File.AppendAllText(globals.currentDirectory + STUD_textBoxLastName.Text + ".txt", STUD_textBoxMobileNum.Text + Environment.NewLine);
                File.AppendAllText(globals.currentDirectory + STUD_textBoxLastName.Text + ".txt", STUD_textBoxLandLine.Text + Environment.NewLine);
                MessageBox.Show("TADA.");
                Environment.Exit(0);
            }
        }

    }
}
