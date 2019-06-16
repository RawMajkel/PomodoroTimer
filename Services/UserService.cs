using System.Linq;
using Persistance;
using Common;
using Common.PasswordHash;

namespace Services
{
    public class UserService
    {
        private static void Login(User user)
        {
            User.LoggedUser = user;

            using (var _ctx = new Context())
            {
                _ctx.LoggingHistory.Add(new LogHistory(User.LoggedUser.UserId));
                _ctx.SaveChanges();
            }
        }
        public static FoundUser CheckLastLoggedUser()
        {
            using (var _ctx = new Context())
            {
                if (_ctx.LoggingHistory.Select(x => x.UserId).Any())
                {
                    var lastLoggedUser = _ctx.LoggingHistory.Select(x => new LogHelper { UserId = x.UserId, LogDate = x.LogDate }).OrderByDescending(x => x.LogDate).First();

                    //jeśli tak, sprwadź czy istnieje
                    if (_ctx.Users.Any(x => x.UserId == lastLoggedUser.UserId))
                    {
                        //zaloguj
                        var user = _ctx.Users.Where(x => x.UserId == lastLoggedUser.UserId).First();
                        Login(user);
                        return new FoundUser(true, $"Found user {user.UserName}", user);
                    }
                }

                return new FoundUser(false, "No logged user found");
            }
        }
        public static ActionResult TryLogin(string userName, string password)
        {
            using (var _ctx = new Context())
            {
                if (!_ctx.Users.Any(x => x.UserName == userName))
                {
                    return new ActionResult(false, $"Nie znaleziono użytkownika o nazwie '{userName}'");
                }

                var hashBytes = _ctx.Users.Where(x => x.UserName == userName).Select(x => x.HashBytes).First();
                HashPassword hash = new HashPassword(hashBytes);

                if (!hash.Verify(password))
                {
                    return new ActionResult(false, "Podane hasło jest błędne");
                }
                else
                {
                    Login(_ctx.Users.Where(x => x.UserName == userName).First());
                    return new ActionResult(true, $"Pomyślnie zalogowano użytkownika '{userName}'");
                }
            }
        }

        public static ActionResult TryRegister(string userName, string password, string email)
        {
            using (var _ctx = new Context())
            {
                if (string.IsNullOrEmpty(userName))
                {
                    return new ActionResult(false, "Wpisz nazwę użytkownika");
                }

                if (_ctx.Users.Any(x => x.UserName == userName))
                {
                    return new ActionResult(false, $"Użytkownik o nazwie '{userName}' już istnieje");
                }

                if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email))
                {
                    return new ActionResult(false, "Wypełnij resztę wymaganych pól");
                }

                _ctx.Users.Add(new User(userName, password, email));
                _ctx.SaveChanges();

                Login(_ctx.Users.Where(x => x.UserName == userName).First());
                return new ActionResult(true, $"Pomyślnie zarejestrowano użytkownika '{userName}'");
            }
        }
    }
}
