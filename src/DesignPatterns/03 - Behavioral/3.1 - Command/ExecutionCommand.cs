using System;

namespace DesignPatterns.Command
{
    public class ExecutionCommand
    {
        public static void Run()
        {
            var user = new User();

            user.Add('+', 100);
            Console.ReadKey();
            user.Add('-', 50);
            Console.ReadKey();
            user.Add('*', 10);
            Console.ReadKey();
            user.Add('/', 2);
            Console.ReadKey();

            user.Undo(4);
            Console.ReadKey();

            user.Return(3);
        }
    }
}
