using System;
using System.Linq;
using DesignPatterns.Facade.Domain;

namespace DesignPatterns.Strategy
{
    public class PaymentTransferService : IPayment
    {
        private readonly IPaymentTransferFacade _paymentTransferFacade;

        public PaymentTransferService(IPaymentTransferFacade paymentTransferFacade)
        {
            _paymentTransferFacade = paymentTransferFacade;
        }

        public Payment MakePayment(Request request, Payment payment)
        {
            payment.Amount = request.Products.Sum(p => p.Amount);
            Console.WriteLine("Starting Payment by Transfer - Amount € " + payment.Amount);

            payment.TransferConfirmation = _paymentTransferFacade.MakeTransfer();
            payment.Status = "Paid via Transfer";
            return payment;
        }
    }
}
