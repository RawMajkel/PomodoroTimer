namespace Common.Consts
{
    public class Consts
    {
        public const string ProjectName = "PomodoroTimer";
        public const string MessageCaption = "Wiadomość zwrotna";

        public static readonly PomodoroSpan PomodoroWork = new PomodoroSpan("Praca", 25);
        public static readonly PomodoroSpan PomodoroShortBreak = new PomodoroSpan("Przerwa", 5);
        public static readonly PomodoroSpan PomodoroLongBreak = new PomodoroSpan("Przerwa", 10);
    }
}
