using Common;
using Common.Consts;
using System;
using System.Windows.Forms;

namespace AppRunner
{
    public partial class WorkForm : Form
    {
        public WorkForm()
        {
            InitializeComponent();
        }

        private void WorkForm_Load(object sender, EventArgs e)
        {
            Text = $"{Consts.ProjectName} | {User.LoggedUser.UserName}";
        }

        private void ZmieńUżytkownikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new WelcomeForm().ShowDialog();
            Close();
        }
    }
}
