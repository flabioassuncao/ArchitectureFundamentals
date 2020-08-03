using System;
using System.Linq;

namespace SOLID.OCP.SolutionExtensionMethod
{
    public class DebitAccount
    {
        public string AccountNumber { get; set; }
        public decimal Value { get; set; }
        public string TransactionNumber { get; set; }

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
