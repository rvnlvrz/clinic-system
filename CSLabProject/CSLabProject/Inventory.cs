﻿using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace CSLabProject
{
    public partial class frmInventory : Form
    {
        public frmInventory()
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
            public static string searchKey = string.Empty;
            public static int flag = 0;
            public static string[] listViewItems = new string[] { };
            public static int counter = 0;
            
        }
        private void Inventory_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            searchKey_txtbox.Visible = false;
            commenceSearch_btn.Visible = false;
            BTNclose.Visible = false;
            frmStudentDetails.globals.currentDirectoryCopy = frmStudentDetails.globals.directory + @"\Raw Inventory Data\";
            DirectoryInfo dir = new System.IO.DirectoryInfo(frmStudentDetails.globals.currentDirectoryCopy);
            if (dir.Exists)
            {
                dir.Delete(true);
            }
            BTNdsearchItem.Enabled = false;

            File.Delete(frmStudentDetails.globals.currentDirectoryCopy);

            lblUsrName.Text = GlobalVar.accessUser;

        }

        private void BTNcreateNew_Click(object sender, EventArgs e)
        {
            AddToInventoryDialog addToInventoryDialog = new AddToInventoryDialog();
            addToInventoryDialog.ShowDialog();
            string temp = string.Empty;
            string[] dataElements = new string[] { globals.itemQuantity, globals.medType, globals.currentDate, globals.addedAs, globals.position };
            if (globals.flag == 1)
            {
                Directory.CreateDirectory(frmStudentDetails.globals.currentDirectoryCopy);
                temp = globals.itemName;
                File.AppendAllText(frmStudentDetails.globals.currentDirectoryCopy + "temp.txt", temp + Environment.NewLine);
                File.AppendAllText(frmStudentDetails.globals.currentDirectoryCopy + globals.itemName + ".txt", globals.itemName + Environment.NewLine);
                File.AppendAllLines(frmStudentDetails.globals.currentDirectoryCopy + globals.itemName + "Sub.txt", dataElements);
                inventoryGrid.Items.Add(globals.itemName).SubItems.AddRange(dataElements);
                BTNdsearchItem.Enabled = true;  
            }
        }


        private void BTNclose_Click(object sender, EventArgs e)
        {
            string[] itemName = File.ReadAllLines(frmStudentDetails.globals.currentDirectoryCopy + "temp.txt");
            searchKey_txtbox.Text = string.Empty;
            searchKey_txtbox.Visible = false;
            commenceSearch_btn.Visible = false;
            BTNclose.Visible = false;
            foreach(string item in itemName)
            {
                string[] subItems = File.ReadAllLines(frmStudentDetails.globals.currentDirectoryCopy + item + "Sub.txt");
                inventoryGrid.Items.Add(item).SubItems.AddRange(subItems);
            }
        }

        private void BTNdsearchItem_Click(object sender, EventArgs e)
        {
            searchKey_txtbox.Visible = true;
            commenceSearch_btn.Visible = true;
            BTNclose.Visible = true;
            searchKey_txtbox.Select();
        }

        private void BTNdeleteItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < inventoryGrid.Items.Count; i++)
            {
                if (inventoryGrid.Items[i].Selected)
                {
                    inventoryGrid.Items[i].Remove();
                    i--;
                }
            }
        }

        private void commenceSearch_btn_Click(object sender, EventArgs e)
        {
            globals.searchKey = searchKey_txtbox.Text;
            foreach (ListViewItem item in inventoryGrid.Items)
            {
                if (item.Text.Contains(globals.searchKey))
                {
                    item.Selected = true;
                }
            }
            cleanList(inventoryGrid);
        }

        private void cleanList(ListView listView)
        {
            int i = 0;
            while (true)
            {
                if (i >= listView.Items.Count)
                {
                    break;
                }
                if (listView.Items[i].Selected == false)
                {
                    listView.Items[i].Remove();
                    i--;
                }
                i++;
            }
        }

        private void searchKey_txtbox_Leave(object sender, EventArgs e)
        {
        }

        private void searchKey_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[^?:\\/:*?\""<>|0-9+[$]"))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        private void frmInventory_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
