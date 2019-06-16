using System.Windows.Forms;

namespace AppRunner
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, System.EventArgs e)
        {
            Hide();
            new RegisterForm().ShowDialog();
            Close();
        }

        private void Button2_Click(object sender, System.EventArgs e)
        {
            Hide();
            new LoginForm().ShowDialog();
            Close();
        }
    }
}
