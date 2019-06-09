using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTimer.Classes
{
    class User
    {
        [Key]
        public Guid UserId { get; } = Guid.NewGuid();
        public string Login { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public User(string login, string email, string password)
        {
            Login = login;
            Email = email;
            Password = password;
        }

        private User()
        {

        }
    }
}
