namespace SOLID.OCP.Solution
{
    public class DebitCurrentAccount : DebitAccount
    {
        public override string ToDebit(decimal value, string account)
        {
            // debt current account
            return FormatTransaction();
        }
    }
}
