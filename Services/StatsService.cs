using Common;
using Persistance;
using System.Collections.Generic;
using System.Linq;

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

        public static List<Stats> GetStats(User user)
        {
            using (var _ctx = new Context())
            {
                return _ctx.UserStats.Where(x => x.UserId == user.UserId).OrderBy(x => x.Date).ToList();
            }
        }
    }
}
