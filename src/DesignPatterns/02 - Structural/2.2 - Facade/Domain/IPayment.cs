namespace DesignPatterns.Facade.Domain
{
    public interface IPayment
    {
        Payment MakePayment(Request request, Payment payment);
    }
}
