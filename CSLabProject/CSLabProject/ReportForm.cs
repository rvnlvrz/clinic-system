using System.Windows.Forms;

namespace CSLabProject
{
    public partial class frmReportForm : Form
    {
        public frmReportForm()
        {
            InitializeComponent();
        }

        private void tbxStudNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmReportForm_Load(object sender, System.EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void btnClear_Click(object sender, System.EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is GroupBox)
                {
                    foreach (Control subctrl in ctrl.Controls)
                    {
                        if (subctrl is TextBox)
                            subctrl.Text = "";

                        if (subctrl is ListBox)
                        {
                            ListBox lbox = (ListBox)subctrl;
                            lbox.ClearSelected();
                        }
                    }
                }
            }
        }
    }
}
