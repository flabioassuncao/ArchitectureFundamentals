using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Facade.Domain
{
    public class CreditCardPaymentService : IPayment
    {
        private readonly ICreditCardPaymentFacade _creditCardPaymentFacade;

        public CreditCardPaymentService(ICreditCardPaymentFacade creditCardPaymentFacade)
        {
            _creditCardPaymentFacade = creditCardPaymentFacade;
        }

        public Payment MakePayment(Request request, Payment payment)
        {
            payment.Amount = request.Products.Sum(p => p.Amount);
            Console.WriteLine("Starting Payment via Credit Card - Amount € " + payment.Amount);

            if (_creditCardPaymentFacade.MakePayment(request, payment))
            {
                payment.Status = "Paid via Credit Card";
                return payment;
            }

            payment.Status = "Credit Card Declined!";
            return payment;
        }
    }
}
