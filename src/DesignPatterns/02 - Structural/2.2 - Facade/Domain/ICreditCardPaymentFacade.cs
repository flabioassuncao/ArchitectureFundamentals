namespace DesignPatterns.Facade.Domain
{
    public interface ICreditCardPaymentFacade
    {
        bool MakePayment(Request request, Payment payment);
    }
}
