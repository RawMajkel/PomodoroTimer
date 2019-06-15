using System;
using System.Windows.Forms;
using Services;

namespace AppRunner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            var loginResult = userService.TryLogin(loginTextBox.Text, passwordTextBox.Text);

            if (!loginResult.IsValidated)
            {
                MessageBox.Show(loginResult.ErrorMessage);
            }
            else
            {
                MessageBox.Show("Zalogowano pomyślnie!");
            }
        }
    }
}
