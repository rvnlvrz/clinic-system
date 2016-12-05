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
            STUD_radioButtonMale.Select();
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
            public static int flag = 0;
            public static bool formElement1 = false;
            public static bool formElement2 = false;
            public static bool formElement3 = false;
            public static bool formElement4 = false;
            public static bool formElement5 = false;
            public static bool formElement6 = false;
            public static bool formElement7 = false;
            public static bool formElement8 = false;
            public static bool formElement9 = false;

            public static bool formElement10 = false;
            public static bool formElement11 = false;
            public static bool formElement12 = false;
            public static bool formElement13 = false;
            public static bool formElement14 = false;
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
            else if (STUD_textBoxMI.Text.Length == 1 && e.KeyChar != 8)
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
            else if(STUD_textBoxMobileNum.Text.Length == 11)
            {
                e.Handled = true;
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
            else if (STUD_textBoxLandLine.Text.Length == 7)
            {
                e.Handled = true;
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

            else if (STUD_textBoxStudentNumber.Text.Length == 10 && e.KeyChar != 8)
            {
                e.Handled = true;
            }

            //if (STUD_textBoxStudentNumber.Text.Length == 10 && e.KeyChar == 8)
            //{
            //    STUD_textBoxStudentNumber.Text = STUD_textBoxStudentNumber.Text.Substring(0,STUD_textBoxStudentNumber.Text.Length-1);
            //}

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
            else if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else if (GRDN_textBoxMI.Text.Length == 1)
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
            else if(GRDN_textBoxMobileNum.Text.Length == 11)
            {
                e.Handled = true;
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
            else if(GRDN_textBoxLandLine.Text.Length == 7)
            {
                e.Handled = true;
            }
            if (GRDN_textBoxLandLine.Text != string.Empty)
            {
                LabelGuardianLandLineNumber.ForeColor = Color.Black;
            }
        }

        private void buttonCLR_Click(object sender, EventArgs e)
        {
            warning_label.Text = string.Empty;
            STUD_textBoxFirstName.Text = string.Empty;
            STUD_textBoxLastName.Text = string.Empty;
            STUD_textBoxMI.Text = string.Empty;
            STUD_textBoxMobileNum.Text = string.Empty;
            STUD_textBoxLandLine.Text = string.Empty;
            STUD_textBoxStudentNumber.Text = string.Empty;
            STUD_textBoxProram.Text = string.Empty;
            STUD_textBoxYrLvl.Text = string.Empty;

            GRDN_textBoxFirstName.Text = string.Empty;
            GRDN_textBoxLastName.Text = string.Empty;
            GRDN_textBoxMI.Text = string.Empty;
            GRDN_textBoxMobileNum.Text = string.Empty;
            GRDN_textBoxLandLine.Text = string.Empty;
            foreach (Control c in guradian_grpbx.Controls)
            {
                if (c.GetType() == typeof(Label))
                    c.ForeColor = Color.Black;
            }
            foreach (Control c in student_grpbx.Controls)
            {
                if (c.GetType() == typeof(Label))
                    c.ForeColor = Color.Black;
            }


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
                && GRDN_textBoxLandLine.Text != string.Empty && GRDN_textBoxMobileNum.Text != string.Empty && STUD_radioButtonMale.Checked || STUD_radioButtonFemale.Checked)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool validateInput()
        {
            //Post-input validation for student related fields.
            if (STUD_textBoxFirstName.Text.Length <= 1)
            {
                LabelStudentFirstName.ForeColor = Color.Red;
                warning_label.Text = "An inputted value appears to be invalid.";
                globals.formElement1 = false;
            }
            else
            {
                LabelStudentFirstName.ForeColor = Color.Black;
                warning_label.Text = string.Empty;
                globals.formElement1 = true;
            }

            if(STUD_textBoxLastName.Text.Length <= 1)
            {
                LabelStudentLastName.ForeColor = Color.Red;
                warning_label.Text = "An inputted value appears to be invalid.";
                globals.formElement2 = false;
            }
            else
            {
                LabelStudentLastName.ForeColor = Color.Black;
                warning_label.Text = string.Empty;
                globals.formElement2 = true; 
            }

            if (STUD_textBoxMI.Text == string.Empty)
            {
                LabelStudentMI.ForeColor = Color.Red;
                warning_label.Text = "An inputted value appears to be invalid.";
                globals.formElement3 = false;
            }
            else
            {
                LabelStudentMI.ForeColor = Color.Black;
                warning_label.Text = string.Empty;
                globals.formElement3 = true;
            }


            if (STUD_textBoxAge.Text == string.Empty)
            {
                LabelStudentAge.ForeColor = Color.Red;
                warning_label.Text = "An inputted value appears to be invalid.";
                globals.formElement4 = false;
            }
            else
            {
                LabelStudentAge.ForeColor = Color.Black;
                warning_label.Text = string.Empty;
                globals.formElement4 = true;
            }

            if (STUD_textBoxStudentNumber.Text.Length < 10)
            {
                LabelStudentNumber.ForeColor = Color.Red;
                warning_label.Text = "An inputted value appears to be invalid.";
                globals.formElement5 = false;
            }
            else
            {
                LabelStudentNumber.ForeColor = Color.Black;
                warning_label.Text = string.Empty;
                globals.formElement5 = true;
            }

            if (STUD_textBoxProram.Text == string.Empty)
            {
                LabelStudentProgram.ForeColor = Color.Red;
                warning_label.Text = "An inputted value appears to be invalid.";
                globals.formElement6 = false;
            }
            else
            {
                LabelStudentProgram.ForeColor = Color.Black;
                warning_label.Text = string.Empty;
                globals.formElement6 = true;
            }


            if (STUD_textBoxYrLvl.Text == string.Empty)
            {
                LabelStudentYearLevel.ForeColor = Color.Red;
                warning_label.Text = "An inputted value appears to be invalid.";
                globals.formElement7 = false;
            }
            else
            {
                LabelStudentAge.ForeColor = Color.Black;
                warning_label.Text = string.Empty;
                globals.formElement7 = true;
            }


            if (STUD_textBoxMobileNum.Text.Length < 11)
            {
                LabelStudentMobileNumber.ForeColor = Color.Red;
                warning_label.Text = "An inputted value appears to be invalid.";
                globals.formElement8 = false;
            }
            else
            {
                LabelStudentMobileNumber.ForeColor = Color.Black;
                warning_label.Text = string.Empty;
                globals.formElement8 = true;
            }

            if(STUD_textBoxLandLine.Text.Length < 7)
            {
                LabelStudentLandLineNumber .ForeColor = Color.Red;
                warning_label.Text = "An inputted value appears to be invalid.";
                globals.formElement9 = false;
            }
            else
            {
                LabelStudentLandLineNumber.ForeColor = Color.Black;
                warning_label.Text = string.Empty;
                globals.formElement9 = true;
            }

            //post-input validation for guardian related fields.

            if (GRDN_textBoxFirstName.Text.Length <= 1)
            {
                LabelGuardianFirstName.ForeColor = Color.Red;
                warning_label.Text = "An inputted value appears to be invalid.";
                globals.formElement10 = false;
            }
            else
            {
                LabelGuardianFirstName.ForeColor = Color.Black;
                warning_label.Text = string.Empty;
                globals.formElement10 = true;
            }

            if (GRDN_textBoxLastName.Text.Length <= 1)
            {
                LabelGuardianLastlName.ForeColor = Color.Red;
                warning_label.Text = "An inputted value appears to be invalid.";
                globals.formElement11 = false;
            }
            else
            {
                LabelGuardianLastlName.ForeColor = Color.Black;
                warning_label.Text = string.Empty;
                globals.formElement11 = true;
            }

            if (GRDN_textBoxMI.Text == string.Empty)
            {
                LabelGuardianMI.ForeColor = Color.Red;
                warning_label.Text = "An inputted value appears to be invalid.";
                globals.formElement12 = false;
            }
            else
            {
                LabelGuardianMI.ForeColor = Color.Black;
                warning_label.Text = string.Empty;
                globals.formElement12 = true;
            }

            if (GRDN_textBoxMobileNum.Text.Length < 11)
            {
                LabelGuardianMobileNumber.ForeColor = Color.Red;
                warning_label.Text = "An inputted value appears to be invalid.";
                globals.formElement13 = false;
            }
            else
            {
                LabelGuardianMobileNumber.ForeColor = Color.Black;
                warning_label.Text = string.Empty;
                globals.formElement13 = true;
            }

            if (GRDN_textBoxLandLine.Text.Length < 7)
            {
                LabelGuardianLandLineNumber.ForeColor = Color.Red;
                warning_label.Text = "An inputted value appears to be invalid.";
                globals.formElement14 = false;
            }
            else
            {
                LabelGuardianLandLineNumber.ForeColor = Color.Black;
                warning_label.Text = string.Empty;
                globals.formElement14 = true;
            }

            if(globals.formElement1 && globals.formElement2 && globals.formElement5 && globals.formElement6 && globals.formElement7 && globals.formElement8 &&
                globals.formElement9 && globals.formElement10 && globals.formElement11 &&
                globals.formElement12 && globals.formElement13 && globals.formElement14)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            bool confirmAllAreValid = validateInput();
            bool confirmNoneAreNull = checkForNullStrings();
           
            if (confirmNoneAreNull && confirmAllAreValid)
            {
                STUD_textBoxMI.Text = STUD_textBoxMI.Text.ToUpper() +  ".";
                GRDN_textBoxMI.Text = GRDN_textBoxMI.Text.ToUpper() + ".";
                globals.currentDirectory += @"\" + STUD_textBoxStudentNumber.Text + @"\";
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

                File.WriteAllText(globals.currentDirectory + "GuardianData.txt", comboBoxRelationship.SelectedItem + Environment.NewLine);
                File.AppendAllText(globals.currentDirectory +"GuardianData.txt", GRDN_textBoxFirstName.Text + Environment.NewLine);
                File.AppendAllText(globals.currentDirectory + "GuardianData.txt", GRDN_textBoxLastName.Text + Environment.NewLine);
                File.AppendAllText(globals.currentDirectory + "GuardianData.txt", GRDN_textBoxMobileNum.Text + Environment.NewLine);
                File.AppendAllText(globals.currentDirectory + "GuardianData.txt", GRDN_textBoxMobileNum.Text + Environment.NewLine);

                MessageBox.Show("The details for " + STUD_textBoxLastName.Text + " has been added to the system.");
                Dispose();
            }
            else if (!confirmAllAreValid)
            {
                warning_label.Text = warning_label.Text = "An inputted value appears to be invalid.";
            }
        }

        private void STUD_textBoxFirstName_MouseClick(object sender, MouseEventArgs e)
        {
            warning_label.Text = string.Empty;
        }

        private void STUD_textBoxLastName_MouseClick(object sender, MouseEventArgs e)
        {
            warning_label.Text = string.Empty;
        }

        private void STUD_textBoxMI_MouseClick(object sender, MouseEventArgs e)
        {
            warning_label.Text = string.Empty;
        }

        private void STUD_textBoxAge_MouseClick(object sender, MouseEventArgs e)
        {
            warning_label.Text = string.Empty;
        }

        private void STUD_textBoxStudentNumber_MouseClick(object sender, MouseEventArgs e)
        {
            warning_label.Text = string.Empty;
        }

        private void STUD_textBoxProram_MouseClick(object sender, MouseEventArgs e)
        {
            warning_label.Text = string.Empty;
        }

        private void STUD_textBoxYrLvl_MouseClick(object sender, MouseEventArgs e)
        {
            warning_label.Text = string.Empty;
        }

        private void STUD_textBoxMobileNum_MouseClick(object sender, MouseEventArgs e)
        {
            warning_label.Text = string.Empty;
        }

        private void STUD_textBoxLandLine_MouseClick(object sender, MouseEventArgs e)
        {
            warning_label.Text = string.Empty;
        }

        private void GRDN_textBoxFirstName_MouseClick(object sender, MouseEventArgs e)
        {
            warning_label.Text = string.Empty;
        }

        private void GRDN_textBoxLastName_MouseClick(object sender, MouseEventArgs e)
        {
            warning_label.Text = string.Empty;
        }

        private void GRDN_textBoxMI_MouseClick(object sender, MouseEventArgs e)
        {
            warning_label.Text = string.Empty;
        }

        private void GRDN_textBoxMobileNum_MouseClick(object sender, MouseEventArgs e)
        {
            warning_label.Text = string.Empty;
        }

        private void GRDN_textBoxLandLine_MouseClick(object sender, MouseEventArgs e)
        {
            warning_label.Text = string.Empty;
        }

        private void STUD_radioButtonMale_Click(object sender, EventArgs e)
        {
            LabelStudentGender.ForeColor = Color.Black;
        }

        private void STUD_radioButtonFemale_Click(object sender, EventArgs e)
        {
            LabelStudentGender.ForeColor = Color.Black;
        }
    }
}
