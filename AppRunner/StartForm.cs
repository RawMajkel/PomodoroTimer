using System;
using System.Windows.Forms;
using Services;
using Common;
using Common.Consts;

namespace AppRunner
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //Logowanie
            var loginResult = UserService.TryLogin(loginUserNameTextBox.Text, loginPasswordTextBox.Text);

            //Pokaż zwrotkę oraz wyczyść okienka
            MessageBox.Show(loginResult.ReturnedMessage, Consts.MessageCaption);
            loginUserNameTextBox.Text = loginPasswordTextBox.Text = string.Empty;

            if (loginResult.IsValidated)
            {
                ActiveForm.Text = $"{Consts.ProjectName} | {User.LoggedUser.UserName}";
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            //Rejestracja
            var registerResult = UserService.TryRegister(registerUserNameTextbox.Text, registerPasswordTextbox.Text, registerEmailTextbox.Text);

            //Pokaż zwrotkę oraz wyczyść okienka
            MessageBox.Show(registerResult.ReturnedMessage, Consts.MessageCaption);
            registerUserNameTextbox.Text = registerPasswordTextbox.Text = registerEmailTextbox.Text = string.Empty;
        }
    }
}
