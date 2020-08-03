using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OCP.SolutionExtensionMethod
{
    public static class DebitCurrentAccount
    {
        public static string ToDebitCurrentAccount(this DebitAccount debitAccount)
        {
            // business logic
            return debitAccount.FormatTransaction();
        }
    }
}
