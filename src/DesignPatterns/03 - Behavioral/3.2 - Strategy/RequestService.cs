using DesignPatterns.Facade.Domain;

namespace DesignPatterns.Strategy
{
    public class RequestService
    {
        private readonly IPayment _payment;

        public RequestService(IPayment payment)
        {
            _payment = payment;
        }

        public Payment RealizarPagamento(Request request, Payment payment)
        {
            return _payment.MakePayment(request, payment);
        }
    }
}
