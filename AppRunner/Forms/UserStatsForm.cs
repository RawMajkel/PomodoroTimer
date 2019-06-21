using Common;
using System;
using System.Windows.Forms;
using Services;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;

namespace AppRunner
{
    public partial class UserStatsForm : Form
    {
        public static List<Stats> userStats;
        public UserStatsForm()
        {
            InitializeComponent();

            userStats = StatsService.GetStats(User.LoggedUser);
            Console.WriteLine(userStats.Count);

            monthCalendar1.MinDate = User.LoggedUser.CreationDate;
            monthCalendar1.MaxDate = DateTime.Now;
            returnLabel.MaximumSize = new Size(100, 0);
            returnLabel.AutoSize = true;

            var dates = new List<DateTime>();

            foreach (var item in userStats)
            {
                dates.Add(item.Date);
            }

            monthCalendar1.BoldedDates = dates.Distinct().ToArray();
            UpdateStatsLabel();
        }

        public void UpdateStatsLabel()
        {
            returnLabel.Text = "";

            var data = userStats.Where(x => x.Date.ToString("MM:dd:yyyy") == monthCalendar1.SelectionRange.Start.Date.ToString("MM:dd:yyyy")).Select(x => new { x.PomodoroName, x.PomodoroTime }).ToList();

            var text = new StringBuilder();

            foreach (var item in data)
            {
                text.Append($" - {item.PomodoroName} ({item.PomodoroTime}min) \n");
            }

            returnLabel.Text = text.ToString();
        }

        private void MonthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            UpdateStatsLabel();
        }
    }
}
