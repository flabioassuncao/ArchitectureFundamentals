namespace DesignPatterns.Adapter
{
    public class TransactionService
    {
        private readonly ILogger _logger;

        public TransactionService(ILogger logger)
        {
            _logger = logger;
        }

        public void MakeTransaction()
        {
            // Transação
            _logger.Log("Transaction completed");
        }
    }
}
