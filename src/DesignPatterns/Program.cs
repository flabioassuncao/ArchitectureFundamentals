using System;
using DesignPatterns.AbstractFactory;
using DesignPatterns.FactoryMethod;
using DesignPatterns.Singleton;

namespace DesignPatterns
{
    class Program
    {
        private static void Main()
        {
            Console.WriteLine("Escolha a operação:");
            Console.WriteLine("------------------------");
            Console.WriteLine("Creational Patterns");
            Console.WriteLine("------------------------");
            Console.WriteLine("1 - Abstract Factory");
            Console.WriteLine("2 - Method Factory");
            Console.WriteLine("3 - Singleton");
            Console.WriteLine("------------------------");
            Console.WriteLine("Structural Patterns");
            Console.WriteLine("------------------------");
            Console.WriteLine("4 - Adapter");
            Console.WriteLine("5 - Facade");
            Console.WriteLine("6 - Composite");
            Console.WriteLine("------------------------");
            Console.WriteLine("Behavioral Patterns");
            Console.WriteLine("------------------------");
            Console.WriteLine("7 - Command");
            Console.WriteLine("8 - Strategy");
            Console.WriteLine("9 - Observer");
            Console.WriteLine("------------------------");

            var opcao = Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine("------------------------");
            Console.WriteLine("");

            switch (opcao.KeyChar)
            {
                case '1':
                    ExecutionAbstractFactory.Executar();
                    break;
                case '2':
                    ExecutionFactoryMethod.Executar();
                    break;
                case '3':
                    ExecutionSingleton.Executar();
                    break;
                    //case '4':
                    //    ExecutionAdapter.Executar();
                    //    break;
                    //case '5':
                    //    ExecutionFacade.Executar();
                    //    break;
                    //case '6':
                    //    ExecutionComposite.Executar();
                    //    break;
                    //case '7':
                    //    ExecutionCommand.Executar();
                    //    break;
                    //case '8':
                    //    ExecutionStrategy.Executar();
                    //    break;
                    //case '9':
                    //    ExecutionObserver.Executar();
                    //    break;
            }

            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
