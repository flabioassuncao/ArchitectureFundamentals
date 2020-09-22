using System;
using System.Linq;
using DesignPatterns.Facade.Domain;

namespace DesignPatterns.Strategy
{
    public class BoletoPaymentService : IPayment
    {
        private readonly IBoletoPaymentFacade _boletoPaymentFacade;

        public BoletoPaymentService(IBoletoPaymentFacade boletoPaymentFacade)
        {
            _boletoPaymentFacade = boletoPaymentFacade;
        }

        public Payment MakePayment(Request request, Payment payment)
        {
            payment.Amount = request.Products.Sum(p => p.Amount);
            Console.WriteLine("Starting Payment via Boleto - Amount € " + payment.Amount);


            payment.DigitableLineBoleto = _boletoPaymentFacade.GenerateBoleto();
            payment.Status = "Awaiting payment";
            return payment;
        }
    }
}
