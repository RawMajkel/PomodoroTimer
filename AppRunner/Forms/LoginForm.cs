using Common;
using Common.Consts;
using Services;
using System;
using System.Windows.Forms;

namespace AppRunner
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //Logowanie
            var loginResult = UserService.TryLogin(loginUserNameTextbox.Text, loginPasswordTextbox.Text);

            //Pokaż zwrotkę oraz wyczyść okienka
            MessageBox.Show(loginResult.ReturnedMessage, Consts.MessageCaption);
            loginUserNameTextbox.Text = loginPasswordTextbox.Text = string.Empty;

            if (loginResult.IsValidated)
            {
                Hide();
                new WorkForm().ShowDialog();
                Close();
            }
        }
    }
}
