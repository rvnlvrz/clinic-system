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

        public static class globals
        {
            public static string itemName = string.Empty;
            public static string itemQuantity = string.Empty;
            public static string addedAs = string.Empty;
            public static string currentDate = string.Empty;
            public static string position = string.Empty;
            public static string medType = string.Empty;
            public static string searchItem = "";
            public static bool itemIsPresent = false;
        }
        private void Inventory_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void BTNcreateNew_Click(object sender, EventArgs e)
        {
            AddToInventoryDialog addToInventoryDialog = new AddToInventoryDialog();
            addToInventoryDialog.ShowDialog();
            string[] dataElements = new string[] { globals.itemQuantity, globals.medType, globals.currentDate, globals.addedAs, globals.position };
            inventoryGrid.Items.Add(globals.itemName).SubItems.AddRange(dataElements);
        }

        private void BTNclose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BTNdsearchItem_Click(object sender, EventArgs e)
        {
            //W.I.P.
            SearchInventoryDialog searchInvDialogForm = new SearchInventoryDialog();
            searchInvDialogForm.ShowDialog();
            ListViewItem test = inventoryGrid.FindItemWithText(globals.searchItem);
            searchResultsForm searchResultsFrm = new searchResultsForm();
            if(test != null)
            {
                searchResultsFrm.ShowDialog();
            }
        }
    }
}
