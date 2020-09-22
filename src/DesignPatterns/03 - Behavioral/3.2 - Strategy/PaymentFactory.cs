using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Facade.CrossCutting;
using DesignPatterns.Facade.Domain;

namespace DesignPatterns.Strategy
{
    public class PaymentFactory
    {
        // Nesse caso seria necessário usar um tipo de Service Locator
        // Ou injetar todas as instâncias para retornar apenas uma
        public static IPayment CreatePayment(PaymentMethod paymentMethod)
        {
            switch (paymentMethod)
            {
                case PaymentMethod.CreditCard:
                    return new CreditCardPaymentService(
                               new CreditCardPaymentFacade(
                               new PayPalGateway(),
                               new ConfigurationManager()));

                case PaymentMethod.Boleto:
                    return new BoletoPaymentService(new BoletoPaymentFacade());

                case PaymentMethod.BankTransfer:
                    return new PaymentTransferService(new PaymentTransferFacade());

                default:
                    throw new ApplicationException("Unknown Payment Method");
            }
        }
    }
}
