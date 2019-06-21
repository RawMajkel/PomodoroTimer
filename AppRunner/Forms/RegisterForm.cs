using System;
using System.Windows.Forms;
using Services;
using Common.Consts;
using Common;

namespace AppRunner
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            //Rejestracja
            var registerResult = UserService.TryRegister(registerUserNameTextbox.Text, registerPasswordTextbox.Text, registerEmailTextbox.Text);

            //Pokaż zwrotkę oraz wyczyść okienka
            MessageBox.Show(registerResult.ReturnedMessage, Consts.MessageCaption);
            registerUserNameTextbox.Text = registerPasswordTextbox.Text = registerEmailTextbox.Text = string.Empty;

            if (registerResult.IsValidated)
            {
                ActiveForm.Text = $"{Consts.ProjectName} | {User.LoggedUser.UserName}";
                Hide();
                new WorkForm().ShowDialog();
                Close();
            }
        }
    }
}
