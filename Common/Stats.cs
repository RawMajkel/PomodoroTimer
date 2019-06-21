using System;

namespace Common
{
    public class Stats
    {
        public Guid StatsId { get; private set; } = Guid.NewGuid();
        public DateTime Date { get; set; } = DateTime.Now;
        public Guid UserID { get; set; }
        public string PomodoroName { get; set; }
        public int PomodoroTime { get; set; }

        private Stats()
        {

        }

        public Stats(Guid userId, PomodoroSpan pomodoroType)
        {
            UserID = userId;
            PomodoroName = pomodoroType.PomodoroName;
            PomodoroTime = pomodoroType.PomodoroTime;
        }
    }
}
