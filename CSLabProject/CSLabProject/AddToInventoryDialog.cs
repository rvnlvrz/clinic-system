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
                frmInventory.globals.addedAs = AddingAs_txtbx.Text;
                frmInventory.globals.position = Position_txtbx.Text;
                frmInventory.globals.currentDate = currentDate_txtbx.Text;
                frmInventory.globals.itemName = ItemName_txtbx.Text;
                frmInventory.globals.itemQuantity = quantity_txtbx.Text;
                frmInventory.globals.medType = comboBoxMedicineType.SelectedItem.ToString();
            }
        }

        public bool checkIfAllAreFilled()
        {
            if(ItemName_txtbx.Text == string.Empty)
            {
                itemName_lbl.ForeColor = Color.Yellow;
                frmInventory.globals.flag = 0;
                return false;
            }
            else if(ItemName_txtbx.Text != string.Empty)
            {
                itemName_lbl.ForeColor = Color.White;
                frmInventory.globals.flag = 1;
            }

            if (quantity_txtbx.Text == string.Empty)
            {
                quantity_lbl.ForeColor = Color.Yellow;
                frmInventory.globals.flag = 0;
            }

            else if(quantity_txtbx.Text != string.Empty)
            {
                quantity_lbl.ForeColor = Color.White;
                frmInventory.globals.flag = 1;
                return true;
            }

            if(quantity_txtbx.Text == string.Empty && ItemName_txtbx.Text == string.Empty)
            {
                quantity_lbl.ForeColor = Color.Yellow;
                itemName_lbl.ForeColor = Color.Yellow;
                frmInventory.globals.flag = 0;
            }
            else if(quantity_txtbx.Text != string.Empty && ItemName_txtbx.Text != string.Empty)
            {
                quantity_lbl.ForeColor = Color.White;
                itemName_lbl.ForeColor = Color.White;
                frmInventory.globals.flag = 1;
            }

            if (frmInventory.globals.flag == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            bool allAreFilled = checkIfAllAreFilled();
            if (!allAreFilled)
            {
                warnLabel.Text = "You cannot leave a field empty.";
            }
            else if(allAreFilled)
            {
                validateInput();
                warnLabel.Text = string.Empty;
                Dispose();
            }





        }

        private void ItemName_txtbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[^?:\\/:*?\""<>0-9|+$]"))
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

        private void ItemName_txtbx_Click(object sender, EventArgs e)
        {
            warnLabel.Text = string.Empty;
            itemName_lbl.ForeColor = Color.White;
        }

        private void quantity_txtbx_Click(object sender, EventArgs e)
        {
            warnLabel.Text = string.Empty;
            quantity_lbl.ForeColor = Color.White;
        }

        private void ItemName_txtbx_Leave(object sender, EventArgs e)
        {
            if(ItemName_txtbx.Text == string.Empty)
            {
                itemName_lbl.ForeColor = Color.Yellow;
            }
            else
            {
                itemName_lbl.ForeColor = Color.White;
            }
        }

        private void quantity_txtbx_Leave(object sender, EventArgs e)
        {
            if(quantity_txtbx.Text == string.Empty)
            {
                quantity_lbl.ForeColor = Color.Yellow;
            }
            else
            {
                quantity_lbl.ForeColor = Color.White;
            }
        }
    }
}
