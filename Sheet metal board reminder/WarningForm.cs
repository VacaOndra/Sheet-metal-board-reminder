using System.Windows.Forms;

namespace Sheet_metal_board_reminder
{
    public partial class WarningForm : Form
    {
        public WarningForm(string s)
        {
            InitializeComponent();
            lblListOfEmptyContainers.Text = s;
        }
    }
}
