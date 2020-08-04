namespace SOLID.DIP.Violation
{
    public class Email
    {
        public string EmailAddress { get; set; }

        public bool Valid()
        {
            return EmailAddress.Contains("@");
        }
    }
}
