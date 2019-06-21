using System;

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
}
