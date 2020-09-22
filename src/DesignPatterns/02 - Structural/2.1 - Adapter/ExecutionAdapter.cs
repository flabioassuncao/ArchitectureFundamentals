namespace DesignPatterns.Adapter
{
    public class ExecutionAdapter
    {
        public static void Run()
        {
            var standardLogPayment = new TransactionService(new Logger());
            standardLogPayment.MakeTransaction();

            var customLogPayment = new TransactionService(new LogAdapter(new LogNetMasterService()));
            customLogPayment.MakeTransaction();
        }
    }
}
