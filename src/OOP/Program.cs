using System;

namespace OOP
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Choose a operation:");
            Console.WriteLine("");
            Console.WriteLine("1 - Encapsulation");
            Console.WriteLine("2 - Inheritance Composition 1");
            Console.WriteLine("3 - Inheritance Composition 2");
            Console.WriteLine("4 - Interface Implementation");

            var opcao = Console.ReadKey();

            switch (opcao.KeyChar)
            {
                case '1':
                    new CoffeeAutomation().ServingCoffee();
                    break;
                case '2':
                    new TestInheritanceComposition();
                    break;
                case '3':
                    new TestInheritanceComposition2();
                    break;
                case '4':
                    new TestInterfaceImplementation();
                    break;
            }

            Main();
        }
    }
}
