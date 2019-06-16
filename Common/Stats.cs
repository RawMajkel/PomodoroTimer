using System;

namespace Common
{
    public class Stats
    {
        public Guid StatsId { get; private set; } = Guid.NewGuid();
        public DateTime Date { get; set; } = DateTime.Now;
        public User User { get; set; }
        public PomodoroSpan PomodoroType { get; set; }

        private Stats()
        {

        }

        public Stats(User user, PomodoroSpan pomodoroType)
        {
            User = user;
            PomodoroType = pomodoroType;
        }
    }
}
