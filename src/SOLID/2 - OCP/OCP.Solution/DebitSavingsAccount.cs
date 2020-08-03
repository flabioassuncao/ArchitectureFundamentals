namespace SOLID.OCP.Solution
{
    public class DebitSavingsAccount : DebitAccount
    {
        public override string ToDebit(decimal value, string account)
        {
            // business logic
            return FormatTransaction();
        }
    }
}
