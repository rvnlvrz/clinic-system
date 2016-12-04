using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSLabProject
{
    public partial class AddToInventoryDialog : Form
    {
        public AddToInventoryDialog()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(ItemName_txtbx.Text == string.Empty || quantity_txtbx.Text == string.Empty)
            {
                warnLabel.Text = "You cannot leave a field empty.";
            }
            else
            {
                warnLabel.Text = string.Empty;
            }
        }
    }
}
