using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OCP.SolutionExtensionMethod
{
    public class ATM
    {
        public static void Operations()
        {
            OperationsMenu();

            var option = Console.ReadKey();
            var retur = string.Empty;

            var accountDebit = DebitData();

            switch (option.KeyChar)
            {
                case '1':
                    Console.WriteLine("");
                    retur = accountDebit.ToDebitCurrentAccount();
                    break;
                case '2':
                    Console.WriteLine("");
                    retur = accountDebit.ToDebitSavingsAccount();
                    break;
                case '3':
                    Console.WriteLine("");
                    retur = accountDebit.ToDebitInvestimentAccount();
                    break;
            }

            ReturnTransaction(retur);
        }

        private static void OperationsMenu()
        {
            Console.Clear();
            Console.WriteLine("ATM - SOLID");
            Console.WriteLine("choose one option:");
            Console.WriteLine();
            Console.WriteLine("1 - ");
            Console.WriteLine("2 - ");
            Console.WriteLine("3 - ");
        }

        private static DebitAccount DebitData()
        {
            Console.WriteLine();
            Console.WriteLine(".....................................");
            Console.WriteLine();
            Console.WriteLine("type account");
            var account = Console.ReadLine();
            Console.WriteLine("type a value");
            var value = Convert.ToDecimal(Console.ReadLine());

            var debitAccount = new DebitAccount()
            {
                AccountNumber = account,
                Value = value
            };

            return debitAccount;
        }

        private static void ReturnTransaction(string retur)
        {
            Console.WriteLine();
            Console.WriteLine("sucess! transaction: " + retur);
            Console.ReadKey();
        }
    }
}
