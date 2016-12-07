using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace CSLabProject
{
    public partial class frmStudentDetails : Form
    {
        public frmStudentDetails()
        {
            InitializeComponent();
        }

        private void StudentDetails_Load(object sender, EventArgs e)
        {
            MinimizeBox = false;
            MaximizeBox = false;
            comboBoxRelationship.SelectedIndex = 1;
            string direc = AppDomain.CurrentDomain.BaseDirectory;
            string directory = direc.Replace(@"\bin\Debug\", "");
            globals.directory = directory;
            globals.currentDirectory = directory + @"\Raw Program Data\";
            STUD_radioButtonMale.Select();
            
            
            // added for default name
            globals.defName = this.Text;

            // set default focus
            STUD_textBoxFirstName.Focus();
        }

        public class globals
        {
            public static string currentDirectory = ""; /*Helps the program identify where to store obtained data.*/
            public static string currentDirectoryCopy = ""; /*Helps the program identify where to store obtained data.*/
            public static string directory = string.Empty;
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
            public static string defName = "";
        }
        private void STUD_textBoxFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //The user cannot input the characters sepecified below.
            var regex = new Regex(@"[^a-zA-Z\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (STUD_textBoxFirstName.Text != string.Empty)
            {
                STUD_textBoxFirstName.ForeColor = Color.Black;
            }
        }       

        private void STUD_textBoxFLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //The user cannot input the characters sepecified below.
            var regex = new Regex(@"[^a-zA-Z\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar))
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
            var regex = new Regex(@"[^a-zA-Z\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar))
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
            var regex = new Regex(@"[^0-9\b\s]");
            if (regex.IsMatch(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (STUD_textBoxMobileNum.Text.Length == 11 && e.KeyChar != 8 && !char.IsControl(e.KeyChar))
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
            var regex = new Regex(@"[^0-9\b\s]");
            if (regex.IsMatch(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (STUD_textBoxLandLine.Text.Length == 7 && e.KeyChar != 8 && !char.IsControl(e.KeyChar))
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
            var regex = new Regex(@"[^0-9\b\s]");
            if (regex.IsMatch(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (STUD_textBoxAge.Text.Length == 2 && e.KeyChar != 8 && !char.IsControl(e.KeyChar))
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
            var regex = new Regex(@"[^0-9\b\s]");
            if (regex.IsMatch(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (STUD_textBoxYrLvl.Text.Length == 1 && e.KeyChar != 8 && !char.IsControl(e.KeyChar))
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
            var regex = new Regex(@"[^0-9\b\s]");
            if (regex.IsMatch(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (STUD_textBoxStudentNumber.Text.Length == 10 && e.KeyChar != 8 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
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
            var regex = new Regex(@"[^a-zA-Z\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar))
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
            var regex = new Regex(@"[^a-zA-Z\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar))
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
            var regex = new Regex(@"[^a-zA-Z\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (GRDN_textBoxMI.Text.Length == 1 && e.KeyChar != 8 && !char.IsControl(e.KeyChar))
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
            var regex = new Regex(@"[^0-9\b\s]");
            if (regex.IsMatch(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (GRDN_textBoxMobileNum.Text.Length == 11 && e.KeyChar != 8 && !char.IsControl(e.KeyChar))
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
            var regex = new Regex(@"[^0-9\b\s]");
            if (regex.IsMatch(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (GRDN_textBoxLandLine.Text.Length == 7 && e.KeyChar != 8 && !char.IsControl(e.KeyChar))
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

            // sets focus to the default tbx
            STUD_textBoxFirstName.Focus();
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
            if (STUD_textBoxFirstName.Text != string.Empty && STUD_textBoxLastName.Text != string.Empty
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

            if (STUD_textBoxLastName.Text.Length <= 1)
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

            if (STUD_textBoxLandLine.Text.Length < 7)
            {
                LabelStudentLandLineNumber.ForeColor = Color.Red;
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

            if (globals.formElement1 && globals.formElement2 && globals.formElement5 && globals.formElement6 && globals.formElement7 && globals.formElement8 &&
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
            Name studentName = new Name(STUD_textBoxFirstName.Text, STUD_textBoxLastName.Text, STUD_textBoxMI.Text);
            Name guardianName = new Name(GRDN_textBoxFirstName.Text, GRDN_textBoxLastName.Text, GRDN_textBoxMI.Text);
            Height studentHeight = new Height(0, 0);
            Guardian studentGuardian = new Guardian(guardianName, GRDN_textBoxMobileNum.Text, GRDN_textBoxLandLine.Text);
            Student student = new Student(studentName, int.Parse(STUD_textBoxAge.Text), 0, studentHeight, STUD_radioButtonMale.Text, STUD_textBoxStudentNumber.Text, STUD_textBoxProram.Text,int.Parse(STUD_textBoxYrLvl.Text), STUD_textBoxMobileNum.Text, STUD_textBoxLandLine.Text, studentGuardian);
            bool confirmAllAreValid = validateInput();
            bool confirmNoneAreNull = checkForNullStrings();
            Name myName = student.GetName();

            if (confirmNoneAreNull && confirmAllAreValid)
            {
                STUD_textBoxMI.Text = STUD_textBoxMI.Text.ToUpper() + ".";
                GRDN_textBoxMI.Text = GRDN_textBoxMI.Text.ToUpper() + ".";
                globals.currentDirectory += @"\" + STUD_textBoxStudentNumber.Text + @"\";
                Directory.CreateDirectory(globals.currentDirectory);
                File.WriteAllText(globals.currentDirectory + myName.FLame + ".txt", myName.FName+ Environment.NewLine);
                File.AppendAllText(globals.currentDirectory + myName.FLame + ".txt", myName.FLame + Environment.NewLine);
                File.AppendAllText(globals.currentDirectory + myName.FLame + ".txt", myName.MInitial + Environment.NewLine);
                File.AppendAllText(globals.currentDirectory + myName.FLame + ".txt", student.Age + Environment.NewLine);
                File.AppendAllText(globals.currentDirectory + myName.FLame + ".txt", student.StudentNumber + Environment.NewLine);
                File.AppendAllText(globals.currentDirectory + myName.FLame + ".txt", student.Program + Environment.NewLine);
                File.AppendAllText(globals.currentDirectory + myName.FLame + ".txt", student.YearLevel + Environment.NewLine);
                File.AppendAllText(globals.currentDirectory + myName.FLame + ".txt", student.CellNo + Environment.NewLine);
                File.AppendAllText(globals.currentDirectory + myName.FLame + ".txt", student.LandLine + Environment.NewLine);

                File.WriteAllText(globals.currentDirectory + "GuardianData.txt", comboBoxRelationship.SelectedItem + Environment.NewLine);
                File.AppendAllText(globals.currentDirectory + "GuardianData.txt", studentGuardian.Name.FName + Environment.NewLine);
                File.AppendAllText(globals.currentDirectory + "GuardianData.txt", studentGuardian.Name.FLame + Environment.NewLine);
                File.AppendAllText(globals.currentDirectory + "GuardianData.txt", studentGuardian.Name.MInitial + Environment.NewLine);
                File.AppendAllText(globals.currentDirectory + "GuardianData.txt", studentGuardian.LandLine + Environment.NewLine);
                File.AppendAllText(globals.currentDirectory + "GuardianData.txt", GRDN_textBoxMobileNum.Text + Environment.NewLine);

                MessageBox.Show("The details for " + myName.FLame + " has been added to the system.");
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

        private void buttonCNCL_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void STUD_textBoxLastName_TextChanged(object sender, EventArgs e)
        {

            if (STUD_textBoxLastName.Text == "")
            {
                this.Text = globals.defName;
            }
            else
                this.Text = "Student Details -" + " " + STUD_textBoxLastName.Text;
        }
    }
}
