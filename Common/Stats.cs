using System;
using System.ComponentModel.DataAnnotations;

namespace Common
{
    public class Stats
    {
        [Key]
        public Guid StatsId { get; private set; } = Guid.NewGuid();
        public DateTime Date { get; set; }
        public Guid UserId { get; set; }
        public int ShortBreaksCount { get; set; }
        public int LongBreaksCount { get; set; }
        public int PomodoroSpans { get; set; }

        private Stats()
        {

        }
    }
}
