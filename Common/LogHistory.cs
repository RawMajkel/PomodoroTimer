using System;
using System.ComponentModel.DataAnnotations;

namespace Common
{
    public class LogHelper
    {
        public Guid UserId { get; set; } = Guid.NewGuid();
        public DateTime LogDate { get; set; } = DateTime.Now;
        public LogHelper(Guid userId, DateTime logDate)
        {
            UserId = userId;
            LogDate = logDate;
        }

        public LogHelper()
        {

        }
    }
    public class LogHistory
    {
        [Key]
        public Guid LogHistoryId { get; set; } = Guid.NewGuid();
        public Guid UserId { get; set; }
        public DateTime LogDate { get; set; } = DateTime.Now;

        public LogHistory(Guid userId)
        {
            UserId = userId;
        }
    }
}
