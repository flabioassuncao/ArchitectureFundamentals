namespace SOLID.DIP.Solution
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
