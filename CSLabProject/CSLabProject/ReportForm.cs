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
    }
}
