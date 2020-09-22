using System;

namespace DesignPatterns.Command
{
    internal class Calculator
    {
        private int _currentAmount;

        public void Operation(char operating, int amount)
        {
            switch (operating)
            {
                case '+': _currentAmount += amount; break;
                case '-': _currentAmount -= amount; break;
                case '*': _currentAmount *= amount; break;
                case '/': _currentAmount /= amount; break;
            }
            Console.WriteLine("(dado {1} {2}) - current amount = {0,3}", _currentAmount, operating, amount);
        }
    }
}
