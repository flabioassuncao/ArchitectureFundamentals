namespace SOLID.OCP.Solution
{
    public class DebitInvestimentAccount : DebitAccount
    {
        public override string ToDebit(decimal value, string account)
        {
            // business logic
            return FormatTransaction();
        }
    }
}
