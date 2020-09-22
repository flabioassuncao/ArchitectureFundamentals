using System;

namespace DesignPatterns.Observable
{
    public static class ExecutionObserver
    {
        public static void Run()
        {
            var joao = new Observer("João");
            var eduardo = new Observer("Eduardo");
            var bill = new Observer("Bill");

            var amazon = new Bovespa("Amazon", NextDecimal());
            var microsoft = new Bovespa("Microsoft", NextDecimal());

            amazon.Subscribe(joao);
            amazon.Subscribe(eduardo);

            microsoft.Subscribe(eduardo);
            microsoft.Subscribe(bill);

            Console.WriteLine("");
            Console.WriteLine("------------------");
            Console.WriteLine("");

            for (int i = 0; i < 5; i++)
            {
                amazon.Amount = NextDecimal();
                microsoft.Amount = NextDecimal();

                if (i == 1)
                {
                    amazon.UnSubscribe(eduardo);
                }
            }
        }

        public static decimal NextDecimal()
        {
            var random = new Random();
            var r = random.Next(141421, 314160);
            return r / (decimal)100000.00;
        }
    }
}
