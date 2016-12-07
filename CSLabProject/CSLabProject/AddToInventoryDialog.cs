using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CSLabProject
{
    public partial class AddToInventoryDialog : Form
    {
        public AddToInventoryDialog()
        {
            InitializeComponent();
        }

        private void AddToInventoryDialog_Load(object sender, EventArgs e)
        {
            currentDate_txtbx.Text = DateTime.Now.ToString("D");
            AddingAs_txtbx.Text = "Registred fucking user.";
            Position_txtbx.Text = "Doctor";
            comboBoxMedicineType.SelectedIndex = 0;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        public void validateInput()
        {
            if (AddingAs_txtbx.Text != string.Empty && Position_txtbx.Text != string.Empty && quantity_txtbx.Text != string.Empty && ItemName_txtbx.Text != string.Empty && currentDate_txtbx.Text != string.Empty)
            {
                Inventory.globals.addedAs = AddingAs_txtbx.Text;
                Inventory.globals.position = Position_txtbx.Text;
                Inventory.globals.currentDate = currentDate_txtbx.Text;
                Inventory.globals.itemName = ItemName_txtbx.Text;
                Inventory.globals.itemQuantity = quantity_txtbx.Text;
                Inventory.globals.medType = comboBoxMedicineType.SelectedItem.ToString();
            }
        }


        private void btn_add_Click(object sender, EventArgs e)
        {

            validateInput();
            if (ItemName_txtbx.Text == string.Empty || quantity_txtbx.Text == string.Empty)
            {
                warnLabel.Text = "You cannot leave a field empty.";
            }
            else
            {
                warnLabel.Text = string.Empty;
            }
            Dispose();





        }

        private void ItemName_txtbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[^?:\\/:*?\""<>|+$]"))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        private void quantity_txtbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[^?:\\/:*?\""<>|a-zA-Z+[$]"))
            {
                e.Handled = true;
            }

            else if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }
    }
}
