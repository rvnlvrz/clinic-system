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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void BTNcreateNew_Click(object sender, EventArgs e)
        {
            AddToInventoryDialog addToInventoryDialog = new AddToInventoryDialog();
            addToInventoryDialog.ShowDialog();
        }

        private void BTNclose_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
