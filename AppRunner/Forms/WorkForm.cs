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
        public static List<Button> controlButtons;
        public static Color buttonsColor;
        public WorkForm()
        {
            InitializeComponent();

            buttonsColor = workButton.BackColor;

            controlButtons = new List<Button>()
            {
                workButton,
                shortBreakButton,
                longBreakButton
            };
        }

        public void ChangeButtonsState(object sender = null, EventArgs e = null)
        {
            for (int i = 0; i < controlButtons.Count; i++)
            {
                controlButtons[i].Enabled = !controlButtons[i].Enabled;
                controlButtons[i].BackColor = (!controlButtons[i].Enabled) ? ColorTranslator.FromHtml("#666") : buttonsColor;
            }
        }

        private void WorkForm_Load(object sender, EventArgs e)
        {
            Text = $"{Consts.ProjectName} | {User.LoggedUser.UserName}";
        }

        private void WorkButton_Click(object sender, EventArgs e)
        {
            var timer = new TimerHelper(Consts.PomodoroWork, timerLabel);
            timer.TimerStart();
            timer.Finished += ChangeButtonsState;

            ChangeButtonsState();
        }

        private void ShortBreakButton_Click(object sender, EventArgs e)
        {
            var timer = new TimerHelper(Consts.PomodoroShortBreak, timerLabel, 50);
            timer.TimerStart();
            timer.Finished += ChangeButtonsState;

            ChangeButtonsState();
        }


        private void LongBreakButton_Click(object sender, EventArgs e)
        {
            var timer = new TimerHelper(Consts.PomodoroLongBreak, timerLabel);
            timer.TimerStart();
            timer.Finished += ChangeButtonsState;

            ChangeButtonsState();
        }

        private void ChangeUser_Click(object sender, EventArgs e)
        {
            Hide();
            new WelcomeForm().ShowDialog();
            Close();
        }
    }
}
