using System;
using System.Linq;

namespace SOLID.OCP.Solution
{
    public abstract class DebitAccount
    {
        public string TransactionNumber { get; set; }
        public abstract string ToDebit(decimal value, string account);

        public string FormatTransaction()
        {
            const string chars = "AKJVDKOHDBLKDBDLKDBLKDNDKLDNÇDNDÇKLDNMÇDKL";
            var random = new Random();
            TransactionNumber = new string(Enumerable.Repeat(chars, 15)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            return TransactionNumber;
        }
    }
}
