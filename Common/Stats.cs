using System;

namespace Common
{
    public class Stats
    {
        public Guid StatsId { get; private set; } = Guid.NewGuid();
        public DateTime Date { get; set; } = DateTime.Now;
        public Guid UserId { get; set; }
        public string PomodoroName { get; set; }
        public int PomodoroTime { get; set; }

        public Stats(Guid userId, PomodoroSpan pomodoroType)
        {
            UserId = userId;
            PomodoroName = pomodoroType.PomodoroName;
            PomodoroTime = pomodoroType.PomodoroTime;
        }
        public Stats(Guid userId, PomodoroSpan pomodoroType, DateTime date)
        {
            UserId = userId;
            PomodoroName = pomodoroType.PomodoroName;
            PomodoroTime = pomodoroType.PomodoroTime;
            Date = date;
        }

        private Stats()
        {

        }
    }
}
