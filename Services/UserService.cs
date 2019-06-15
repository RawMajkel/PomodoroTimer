using System.Linq;
using Persistance;
using Common.PasswordHash;

namespace Services
{
    public class UserService
    {
        private readonly Context _ctx = new Context();

        public UserService()
        {

        }

        public LoginResult TryLogin(string userName, string password)
        {
            using (_ctx)
            {
                var username = _ctx.Users.Where(x => x.UserName == userName).Select(x => x.UserName).FirstOrDefault();

                if (string.IsNullOrEmpty(username))
                {
                    return new LoginResult(false, "Nie znaleziono tego użytkownika");
                }

                var hashBytes = _ctx.Users.Where(x => x.UserName == username).Select(x => x.HashBytes).FirstOrDefault();
                HashPassword hash = new HashPassword(hashBytes);

                if (!hash.Verify(password))
                {
                    return new LoginResult(false, "Hasło się nie zgadza");
                }
                else
                {
                    return new LoginResult(true, "Pomyślnie zalogowano");
                }
            }
        }
    }
    public class LoginResult
    {
        public bool IsValidated { get; set; }
        public string ErrorMessage { get; set; }
        public LoginResult(bool isValidated, string errorMessage)
        {
            IsValidated = isValidated;
            ErrorMessage = errorMessage;
        }
    }
}
