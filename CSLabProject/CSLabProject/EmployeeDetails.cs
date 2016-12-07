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
    public partial class EmployeeDetails : Form
    {
        public EmployeeDetails()
        {
            InitializeComponent();
        }

        private void EMP_textBoxFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (EMP_textBoxFirstName.Text != string.Empty)
            {
                EMP_textBoxFirstName.ForeColor = Color.Black;
            }
        }

        private void EMP_textBoxLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (EMP_textBoxLastName.Text != string.Empty)
            {
                LabelEmployeeLastName.ForeColor = Color.Black;
            }
        }

        private void EMP_textBoxAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^0-9\b\s]");
            if (regex.IsMatch(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (EMP_textBoxAge.Text.Length == 2 && e.KeyChar != 8 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (EMP_textBoxAge.Text != string.Empty)
            {
                LabelEmployeeAge.ForeColor = Color.Black;
            }
        }

        private void EMP_textBoxMI_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (EMP_textBoxMI.Text.Length == 1 && e.KeyChar != 8 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void EMP_textBoxEmployeeNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^0-9\b\s]");
            if (regex.IsMatch(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (EMP_textBoxEmployeeNumber.Text.Length == 10 && e.KeyChar != 8 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (EMP_textBoxEmployeeNumber.Text != string.Empty)
            {
                LabelEmployeeNumber.ForeColor = Color.Black;
            }
        }

        private void EMP_textBoxPosition_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (EMP_textBoxFirstName.Text != string.Empty)
            {
                LabelEmployeeFirstName.ForeColor = Color.Black;
            }
        }

        private void EMP_textBoxMobileNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^0-9\b\s]");
            if (regex.IsMatch(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (EMP_textBoxMobileNum.Text.Length == 11 && e.KeyChar != 8 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (EMP_textBoxMobileNum.Text != string.Empty)
            {
                LabelEmployeeMobileNumber.ForeColor = Color.Black;
            }
        }

        private void EMP_textBoxLandLine_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^0-9\b\s]");
            if (regex.IsMatch(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (EMP_textBoxLandLine.Text.Length == 7 && e.KeyChar != 8 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (EMP_textBoxMobileNum.Text != string.Empty)
            {
                LabelEmployeeLandLineNumber.ForeColor = Color.Black;
            }
        }

        private void EmployeeDetails_Load(object sender, EventArgs e)
        {
            EMP_radioButtonMale.Select();
            EMP_textBoxFirstName.Select();
            globals.currentDirectory += @"\" + EMP_textBoxEmployeeNumber.Text + @"\";
            Directory.CreateDirectory(globals.currentDirectory);
        }

        private void EMP_textBoxFirstName_Leave(object sender, EventArgs e)
        {
            if (EMP_textBoxFirstName.Text == string.Empty)
            {
                LabelEmployeeFirstName.ForeColor = Color.Red;

            }
            else
            {
                LabelEmployeeFirstName.ForeColor = Color.Black;
            }
        }

        private void EMP_textBoxLastName_Leave(object sender, EventArgs e)
        {
            if (EMP_textBoxLastName.Text == string.Empty)
            {
                LabelEmployeeLastName.ForeColor = Color.Red;
            }
            else
            {
                LabelEmployeeLastName.ForeColor = Color.Black;
            }
        }

        private void EMP_textBoxMI_Leave(object sender, EventArgs e)
        {
            if (EMP_textBoxMI.Text == string.Empty)
            {
                LabelEmployeeMI.ForeColor = Color.Red;
            }
            else
            {
                LabelEmployeeMI.ForeColor = Color.Black;
            }
        }

        private void EMP_textBoxAge_Leave(object sender, EventArgs e)
        {
            if (EMP_textBoxAge.Text == string.Empty)
            {
                LabelEmployeeAge.ForeColor = Color.Red;
            }
            else
            {
                LabelEmployeeAge.ForeColor = Color.Black;
            }
        }

        private void EMP_textBoxEmployeeNumber_Leave(object sender, EventArgs e)
        {
            if (EMP_textBoxEmployeeNumber.Text == string.Empty)
            {
                LabelEmployeeNumber.ForeColor = Color.Red;
            }
            else
            {
                LabelEmployeeNumber.ForeColor = Color.Black;
            }
        }

        private void EMP_textBoxPosition_Leave(object sender, EventArgs e)
        {
            if (EMP_textBoxPosition.Text == string.Empty)
            {
                LabelEmployeePosition.ForeColor = Color.Red;
            }
            else
            {
                LabelEmployeePosition.ForeColor = Color.Black;
            }
        }

        private void EMP_textBoxMobileNum_Leave(object sender, EventArgs e)
        {
            if (EMP_textBoxMobileNum.Text == string.Empty)
            {
                LabelEmployeeMobileNumber.ForeColor = Color.Red;
            }
            else
            {
                LabelEmployeeMobileNumber.ForeColor = Color.Black;
            }
        }

        private void EMP_textBoxLandLine_Leave(object sender, EventArgs e)
        {
            if (EMP_textBoxLandLine.Text == string.Empty)
            {
                LabelEmployeeLandLineNumber.ForeColor = Color.Red;
            }
            else
            {
                LabelEmployeeLandLineNumber.ForeColor = Color.Black;
            }
        }

        public bool validateInput()
        {
            //Post-input validation for Employee related fields.
            if (EMP_textBoxFirstName.Text.Length <= 1)
            {
                LabelEmployeeFirstName.ForeColor = Color.Red;
                warning_label.Text = "An inputted value appears to be invalid.";
                globals.formElement1 = false;
            }
            else
            {
                LabelEmployeeFirstName.ForeColor = Color.Black;
                warning_label.Text = string.Empty;
                globals.formElement1 = true;
            }

            if (EMP_textBoxLastName.Text.Length <= 1)
            {
                LabelEmployeeLastName.ForeColor = Color.Red;
                warning_label.Text = "An inputted value appears to be invalid.";
                globals.formElement2 = false;
            }
            else
            {
                LabelEmployeeLastName.ForeColor = Color.Black;
                warning_label.Text = string.Empty;
                globals.formElement2 = true;
            }

            if (EMP_textBoxMI.Text == string.Empty)
            {
                LabelEmployeeMI.ForeColor = Color.Red;
                warning_label.Text = "An inputted value appears to be invalid.";
                globals.formElement3 = false;
            }
            else
            {
                LabelEmployeeMI.ForeColor = Color.Black;
                warning_label.Text = string.Empty;
                globals.formElement3 = true;
            }


            if (EMP_textBoxAge.Text == string.Empty)
            {
                LabelEmployeeAge.ForeColor = Color.Red;
                warning_label.Text = "An inputted value appears to be invalid.";
                globals.formElement4 = false;
            }
            else
            {
                LabelEmployeeAge.ForeColor = Color.Black;
                warning_label.Text = string.Empty;
                globals.formElement4 = true;
            }

            if (EMP_textBoxEmployeeNumber.Text.Length < 10)
            {
                LabelEmployeeNumber.ForeColor = Color.Red;
                warning_label.Text = "An inputted value appears to be invalid.";
                globals.formElement5 = false;
            }
            else
            {
                LabelEmployeeNumber.ForeColor = Color.Black;
                warning_label.Text = string.Empty;
                globals.formElement5 = true;
            }

            if (EMP_textBoxPosition.Text == string.Empty)
            {
                LabelEmployeePosition.ForeColor = Color.Red;
                warning_label.Text = "An inputted value appears to be invalid.";
                globals.formElement6 = false;
            }
            else
            {
                LabelEmployeePosition.ForeColor = Color.Black;
                warning_label.Text = string.Empty;
                globals.formElement6 = true;
            }

            if (EMP_textBoxMobileNum.Text.Length < 11)
            {
                LabelEmployeeMobileNumber.ForeColor = Color.Red;
                warning_label.Text = "An inputted value appears to be invalid.";
                globals.formElement8 = false;
            }
            else
            {
                LabelEmployeeMobileNumber.ForeColor = Color.Black;
                warning_label.Text = string.Empty;
                globals.formElement8 = true;
            }

            if (EMP_textBoxLandLine.Text.Length < 7)
            {
                LabelEmployeeLandLineNumber.ForeColor = Color.Red;
                warning_label.Text = "An inputted value appears to be invalid.";
                globals.formElement9 = false;
            }
            else
            {
                LabelEmployeeLandLineNumber.ForeColor = Color.Black;
                warning_label.Text = string.Empty;
                globals.formElement9 = true;
            }

            if (globals.formElement1 && globals.formElement2 && globals.formElement5 && globals.formElement6 && globals.formElement8 &&
            globals.formElement9)
            {
                return true;
            }
            else
            {
                return false;
            }
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
            public static bool formElement8 = false;
            public static bool formElement9 = false;
            public static string gender = string.Empty;
        }

        public bool checkForNullStrings()
        {
            if (EMP_textBoxFirstName.Text != string.Empty && EMP_textBoxLastName.Text != string.Empty
                && EMP_textBoxMI.Text != string.Empty && EMP_textBoxLandLine.Text != string.Empty
                && EMP_textBoxMobileNum.Text != string.Empty && EMP_radioButtonMale.Checked || EMP_radioButtonFemale.Checked)
            {
                return true;
            }

            else
            {
                return false;
            }

        }

        public void setGender()
        {
            if (EMP_radioButtonMale.Checked)
            {
                globals.gender = "Male";
            }
            else
            {
                globals.gender = "Female";
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            Name employeeName = new Name(EMP_textBoxFirstName.Text, EMP_textBoxLastName.Text, EMP_textBoxMI.Text);
            Height employeeHeight = new Height(0, 0);
            Employee employee = new Employee(employeeName, int.Parse(EMP_textBoxAge.Text), 0, employeeHeight, globals.gender, EMP_textBoxEmployeeNumber.Text, EMP_textBoxPosition.Text);
            Name empName = employee.GetName();
            bool confirmAllAreValid = validateInput();
            bool confirmNoneAreNull = checkForNullStrings();
            if(confirmAllAreValid && confirmNoneAreNull)
            {
                EMP_textBoxMI.Text = EMP_textBoxMI.Text.ToUpper() + ".";
                globals.currentDirectory += @"\" + EMP_textBoxEmployeeNumber.Text + @"\";
                Directory.CreateDirectory(globals.currentDirectory);
                File.WriteAllText(globals.currentDirectory + EMP_textBoxLastName.Text + ".txt", empName.FName + Environment.NewLine);
                File.AppendAllText(globals.currentDirectory + EMP_textBoxLastName.Text + ".txt", empName.FLame + Environment.NewLine);
                File.AppendAllText(globals.currentDirectory + EMP_textBoxLastName.Text + ".txt", empName.MInitial + Environment.NewLine);
                File.AppendAllText(globals.currentDirectory + EMP_textBoxLastName.Text + ".txt", employee.Age + Environment.NewLine);
                File.AppendAllText(globals.currentDirectory + EMP_textBoxLastName.Text + ".txt", employee.EmployeeNumber + Environment.NewLine);
                File.AppendAllText(globals.currentDirectory + EMP_textBoxLastName.Text + ".txt", employee.Position + Environment.NewLine);
                //File.AppendAllText(globals.currentDirectory + EMP_textBoxLastName.Text + ".txt", employee.CellNo + Environment.NewLine);
                //File.AppendAllText(globals.currentDirectory + EMP_textBoxLastName.Text + ".txt", employee.LandLine + Environment.NewLine);
                MessageBox.Show("The details for " + empName.FName + " has been added to the system.");
                Dispose();
            }
            else if (!confirmAllAreValid)
            {
                warning_label.Text = warning_label.Text = "An inputted value appears to be invalid.";
            }

        }
    }
}
