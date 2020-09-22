using System;
using DesignPatterns.AbstractFactory;
using DesignPatterns.Adapter;
using DesignPatterns.Command;
using DesignPatterns.Composite;
using DesignPatterns.Facade;
using DesignPatterns.FactoryMethod;
using DesignPatterns.Observable;
using DesignPatterns.Singleton;
using DesignPatterns.Strategy;

namespace DesignPatterns
{
    class Program
    {
        private static void Main()
        {
            Console.WriteLine("Choose the operation:");
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
                    ExecutionAbstractFactory.Run();
                    break;
                case '2':
                    ExecutionFactoryMethod.Run();
                    break;
                case '3':
                    ExecutionSingleton.Run();
                    break;
                case '4':
                    ExecutionAdapter.Run();
                    break;
                case '5':
                    ExecutionFacade.Run();
                    break;
                case '6':
                    ExecutionComposite.Run();
                    break;
                case '7':
                    ExecutionCommand.Run();
                    break;
                case '8':
                    ExecutionStrategy.Run();
                    break;
                case '9':
                    ExecutionObserver.Run();
                    break;
            }

            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
