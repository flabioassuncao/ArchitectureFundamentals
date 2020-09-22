using System;
using System.Collections.Generic;
using DesignPatterns.Facade.CrossCutting;
using DesignPatterns.Facade.Domain;

namespace DesignPatterns.Facade
{
    public class ExecutionFacade
    {
        public static void Run()
        {
            var products = new List<Product>
            {
                new Product{Name = "Tenis Adidas", Amount = new Random().Next(500)},
                new Product{Name = "Camisa Boliche", Amount = new Random().Next(500)},
                new Product{Name = "Raquete Tenis", Amount = new Random().Next(500)}
            };

            var request = new Request
            {
                Id = Guid.NewGuid(),
                Products = products
            };

            var payment = new Payment
            {
                CrediCard = "5555 2222 5555 9999"
            };

            // Resolva com DI
            var paymentService = new CreditCardPaymentService(
                new CreditCardPaymentFacade(
                    new PayPalGateway(),
                    new ConfigurationManager()));

            var paymentResult = paymentService.MakePayment(request, payment);

            Console.WriteLine(paymentResult.Status);
        }
    }
}
