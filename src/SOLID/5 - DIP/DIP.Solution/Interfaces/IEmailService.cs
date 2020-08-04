namespace SOLID.DIP.Solution.Interfaces
{
    public interface IEmailService
    {
        void Send(string from, string to, string topic, string message);
    }
}
