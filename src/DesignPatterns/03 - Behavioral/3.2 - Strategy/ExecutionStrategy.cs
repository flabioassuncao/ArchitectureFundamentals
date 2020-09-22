using System;
using System.Collections.Generic;
using DesignPatterns.Facade.CrossCutting;
using DesignPatterns.Facade.Domain;

namespace DesignPatterns.Strategy
{
    public class ExecutionStrategy
    {
        public static void Run()
        {
            var products = new List<Product>
            {
                new Product{Name = "Adidas shoes", Amount = new Random().Next(500)},
                new Product{Name = "Boliche t-shirt", Amount = new Random().Next(500)},
                new Product{Name = "Tennis racket", Amount = new Random().Next(500)}
            };

            var request = new Request
            {
                Id = Guid.NewGuid(),
                Products = products
            };

            var creditCardMethod = new Payment
            {
                PaymentMethod = PaymentMethod.CreditCard,
                CrediCard = "5555 2222 5555 9999"
            };

            var boletoMethod = new Payment
            {
                PaymentMethod = PaymentMethod.Boleto
            };

            var TransferPaymentMethod = new Payment
            {
                PaymentMethod = PaymentMethod.BankTransfer,
                CrediCard = "5555 2222 5555 9999"
            };

            #region Forma Simples

            var pedidoCredito = new RequestService(
                                   new CreditCardPaymentService(
                                   new CreditCardPaymentFacade(
                                   new PayPalGateway(),
                                   new ConfigurationManager())));
            var pagamentoCredito = pedidoCredito.RealizarPagamento(request, creditCardMethod);
            Console.WriteLine(pagamentoCredito.Status);

            Console.WriteLine("-------------------------------------------------------");

            var pedidoBoleto = new RequestService(
                                   new BoletoPaymentService(
                                   new BoletoPaymentFacade()));

            var pagamentoBoleto = pedidoBoleto.RealizarPagamento(request, boletoMethod);
            Console.WriteLine(pagamentoBoleto.Status);

            Console.WriteLine("-------------------------------------------------------");

            var pedidoTransferencia = new RequestService(
                                          new PaymentTransferService(
                                          new PaymentTransferFacade()));

            var pagamentoTransferencia = pedidoTransferencia.RealizarPagamento(request, boletoMethod);
            Console.WriteLine(pagamentoTransferencia.Status);

            Console.WriteLine("-------------------------------------------------------");

            #endregion

            #region Forma Elegante

            var pedidoCredito2 = new RequestService(PaymentFactory.CreatePayment(creditCardMethod.PaymentMethod));
            var pagamentoCredito2 = pedidoCredito2.RealizarPagamento(request, creditCardMethod);
            Console.WriteLine(pagamentoCredito2.Status);

            Console.WriteLine("-------------------------------------------------------");

            var pedidoBoleto2 = new RequestService(PaymentFactory.CreatePayment(boletoMethod.PaymentMethod));
            var pagamentoBoleto2 = pedidoBoleto2.RealizarPagamento(request, boletoMethod);
            Console.WriteLine(pagamentoBoleto2.Status);

            Console.WriteLine("-------------------------------------------------------");

            var pedidoTransferencia2 = new RequestService(PaymentFactory.CreatePayment(TransferPaymentMethod.PaymentMethod));
            var pagamentoTransferencia2 = pedidoTransferencia2.RealizarPagamento(request, TransferPaymentMethod);
            Console.WriteLine(pagamentoTransferencia2.Status);

            #endregion
        }
    }
}
