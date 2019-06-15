namespace Services
{
    public class ActionResult
    {
        public bool IsValidated { get; set; }
        public string ReturnedMessage { get; set; }
        public ActionResult(bool isValidated, string returnedMessage)
        {
            IsValidated = isValidated;
            ReturnedMessage = returnedMessage;
        }
    }
}
