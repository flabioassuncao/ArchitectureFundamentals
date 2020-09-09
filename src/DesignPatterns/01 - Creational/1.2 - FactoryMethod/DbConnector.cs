namespace DesignPatterns.FactoryMethod
{
    // Abstract Product
    public abstract class DbConnector
    {
        public abstract Connection Connect();

        protected DbConnector(string connectionString)
        {
            ConnectionString = connectionString;
        }

        protected string ConnectionString { get; set; }
    }
}
