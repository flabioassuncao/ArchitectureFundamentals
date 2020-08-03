using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OCP.Violation
{
    public class AccountDebit
    {
        public void Debit(decimal value, string account, AccountType type)
        {
            if (type == AccountType.Current)
            {
                // debit on current account
            }

            if (type == AccountType.Savings)
            {
                // valid something and
                // debit on Savings account
            }
        }
    }
}
