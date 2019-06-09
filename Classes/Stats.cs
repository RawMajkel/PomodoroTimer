using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTimer.Classes
{
    class Stats
    {
        [Key]
        public Guid StatsId { get; } = Guid.NewGuid();
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
