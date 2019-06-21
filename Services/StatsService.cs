using Common;
using Persistance;

namespace Services
{
    public class StatsService
    {
        public static void SaveStat(User user, PomodoroSpan pomodoroSpan)
        {
            using (var _ctx = new Context())
            {
                _ctx.UserStats.Add(new Stats(user.UserId, pomodoroSpan));
                _ctx.SaveChanges();
            }
        }
    }
}
