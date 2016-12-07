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
    public partial class SearchInventoryDialog : Form
    {
        public SearchInventoryDialog()
        {
            InitializeComponent();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            Inventory.globals.searchItem = searchThisItem_textBox.Text;
            Close();
        }

        private void searchThisItem_textBox_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
