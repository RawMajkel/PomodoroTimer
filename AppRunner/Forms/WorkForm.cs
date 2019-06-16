using Common;
using Common.Consts;
using System;
using System.Windows.Forms;

namespace AppRunner
{
    public partial class WorkForm : Form
    {
        private Timer timer;
        private int timeAmount;
        TimeSpan timeSpan;

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

        private void Timer_Tick(object sender, EventArgs e)
        {
            timeAmount--;

            if (timeAmount == 0)
            {
                timer.Stop();
            }

            timeSpan = TimeSpan.FromSeconds(timeAmount);
            timerLabel.Text = string.Format("{0}:{1}", timeSpan.Minutes, timeSpan.Seconds);
        }

        private void WorkButton_Click(object sender, EventArgs e)
        {
            timeAmount = 25 * 60; //25 minutes
            timer = new Timer();
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Interval = 1000;
            timer.Start();
        }

        private void ShortBreakButton_Click(object sender, EventArgs e)
        {
            timeAmount = 5 * 60; //5 minutes
            timer = new Timer();
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Interval = 1000;
            timer.Start();
        }

        private void LongBreakButton_Click(object sender, EventArgs e)
        {
            timeAmount = 10 * 60; //10 minutes
            timer = new Timer();
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Interval = 1000;
            timer.Start();
        }
    }
}
