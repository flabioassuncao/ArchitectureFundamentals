using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OCP.SolutionExtensionMethod
{
    public static class DebitInvestimentAccount
    {
        public static string ToDebitInvestimentAccount(this DebitAccount debitAccount)
        {
            // business logic
            return debitAccount.FormatTransaction();
        }
    }
}
