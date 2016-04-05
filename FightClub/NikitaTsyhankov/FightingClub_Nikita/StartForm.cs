using System.Windows.Forms;

namespace FightingClub_Nikita
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        public string StartName;

        private void butStart_Click(object sender, System.EventArgs e)
        {
            StartName = textBoxSetName.Text;
            Close();
        }

        private void textBoxSetName_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode || Keys.Escape == e.KeyCode)
            {
                StartName = textBoxSetName.Text;
                Close();
            }
        }
    }
}
