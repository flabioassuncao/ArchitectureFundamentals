namespace DesignPatterns.Facade.Domain
{
    public class Payment
    {
        public string Status { get; set; }
        public decimal Amount { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

        // Possiveis meios de pagamento implementados direto 
        // na classe pagamento por brevidade do exemplo
        public string CrediCard { get; set; }
        public string DigitableLineBoleto { get; set; }
        public string TransferConfirmation { get; set; }
    }
}
