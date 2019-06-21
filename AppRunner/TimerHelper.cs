using Common;
using Services;
using System;
using System.Windows.Forms;
using System.Media;

namespace AppRunner
{
    public class TimerHelper
    {
        public PomodoroSpan PomodoroSpan { get; set; }
        public Label TimerLabel { get; set; }

        private readonly Timer _timer;
        private int _timeAmount;
        public event EventHandler Finished;

        public TimerHelper(PomodoroSpan pomodoroSpan, Label timerLabel, int interval = 1000)
        {
            PomodoroSpan = pomodoroSpan;
            TimerLabel = timerLabel;

            _timer = new Timer();
            _timer.Tick += new EventHandler(Tick);
            _timeAmount = PomodoroSpan.PomodoroTime * 60;
            _timer.Interval = interval;
        }

        public void TimerStart()
        {
            _timer.Start();
        }

        public void Tick(object sender, EventArgs e)
        {
            _timeAmount--;

            if (_timeAmount == 0)
            {
                _timer.Stop();

                var alarmSound = new SoundPlayer(Properties.Resources.alarm_sound);
                alarmSound.Play();

                Finished?.Invoke(this, EventArgs.Empty);
                StatsService.SaveStat(User.LoggedUser, PomodoroSpan);
            }

            var timeSpan = TimeSpan.FromSeconds(_timeAmount);

            TimerLabel.Text = string.Format("{0:D2}:{1:D2}", timeSpan.Minutes, timeSpan.Seconds);
        }
    }
}
