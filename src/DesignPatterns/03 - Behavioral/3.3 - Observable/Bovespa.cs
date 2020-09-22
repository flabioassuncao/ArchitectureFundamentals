namespace DesignPatterns.Observable
{
    public class Bovespa : Investment
    {
        public Bovespa(string symbol, decimal price)
            :base (symbol, price)
        {
        }
    }
}
