using Common;
using Common.Consts;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AppRunner
{
    public partial class WorkForm : Form
    {
        public static List<Button> ControlButtons { get; set; }
        public static Color ButtonsColor { get; set; }

        public WorkForm()
        {
            InitializeComponent();

            ButtonsColor = workButton.BackColor;

            ControlButtons = new List<Button>()
            {
                workButton,
                shortBreakButton,
                longBreakButton
            };
        }

        private void ConfigureTimer(TimerHelper timer)
        {
            timer.TimerStart();
            timer.Finished += TimerFinished;
        }

        public void TimerFinished(object sender = null, EventArgs e = null)
        {
            ChangeButtonsState();
            CenterToScreen();
            Activate();
            Focus();
        }

        public void ChangeButtonsState()
        {
            for (int i = 0; i < ControlButtons.Count; i++)
            {
                ControlButtons[i].Enabled = !ControlButtons[i].Enabled;
                ControlButtons[i].BackColor = (!ControlButtons[i].Enabled) ? ColorTranslator.FromHtml("#666") : ButtonsColor;
            }
        }

        private void WorkForm_Load(object sender, EventArgs e)
        {
            Text = $"{Consts.ProjectName} | {User.LoggedUser.UserName}";
        }

        private void WorkButton_Click(object sender, EventArgs e)
        {
            ConfigureTimer(new TimerHelper(Consts.PomodoroWork, timerLabel, 10));
            ChangeButtonsState();
        }

        private void ShortBreakButton_Click(object sender, EventArgs e)
        {
            ConfigureTimer(new TimerHelper(Consts.PomodoroShortBreak, timerLabel, 10));
            ChangeButtonsState();
        }

        private void LongBreakButton_Click(object sender, EventArgs e)
        {
            ConfigureTimer(new TimerHelper(Consts.PomodoroLongBreak, timerLabel, 10));
            ChangeButtonsState();
        }

        private void ChangeUser_Click(object sender, EventArgs e)
        {
            Hide();
            new WelcomeForm().ShowDialog();
            Close();
        }

        private void ShowStats_Click(object sender, EventArgs e)
        {
            var statsForm = new UserStatsForm();
            statsForm.ShowDialog();
        }
    }
}
