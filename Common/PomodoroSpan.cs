using System;

namespace Common
{
    public class PomodoroSpan
    {
        public Guid PomodoroSpanId { get; set; } = Guid.NewGuid();
        public string PomodoroName { get; set; }
        public int PomodoroTime { get; set; }

        public PomodoroSpan(string pomodoroName, int pomodoroTime)
        {
            PomodoroName = pomodoroName;
            PomodoroTime = pomodoroTime;
        }
    }
}
