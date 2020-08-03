using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OCP.SolutionExtensionMethod
{
    public static class DebitSavingsAccount
    {
        public static string ToDebitSavingsAccount(this DebitAccount debitAccount)
        {
            // business logic
            return debitAccount.FormatTransaction();
        }
    }
}
