using System;
using System.ComponentModel.DataAnnotations;
using Common.PasswordHash;

namespace Common
{
    public class User
    {
        [Key]
        public Guid UserId { get; private set; } = Guid.NewGuid();
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public string PasswordHashed { get; set; }
        public byte[] HashBytes { get; set; }
        public User(string userName, string email, string password)
        {
            UserName = userName;
            NormalizedUserName = userName.ToUpper();
            Email = email;
            NormalizedEmail = email.ToUpper();
            HashBytes = new HashPassword(password).ToArray();
            PasswordHashed = Convert.ToBase64String(HashBytes);
        }

        private User()
        {

        }
    }
}
