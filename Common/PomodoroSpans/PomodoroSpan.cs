namespace Common
{
    public class PomodoroSpan
    {
        public string PomodoroName { get; set; }
        public int PomodoroTime { get; set; }

        public PomodoroSpan(string pomodoroName, int pomodoroTime)
        {
            PomodoroName = pomodoroName;
            PomodoroTime = pomodoroTime;
        }
    }
}
