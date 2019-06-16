using Common;

namespace Services
{
    public class ActionResult
    {
        public bool IsValidated { get; set; }
        public string ReturnedMessage { get; set; }
        public ActionResult(bool isValidated, string returnedMessage = "")
        {
            IsValidated = isValidated;
            ReturnedMessage = returnedMessage;
        }
    }
    public class FoundUser : ActionResult
    {
        public User User { get; set; }
        public FoundUser(bool isValidated, string returnedMessage = "", User user = null) : base(isValidated, returnedMessage)
        {
            User = user;
        }
    }
}
