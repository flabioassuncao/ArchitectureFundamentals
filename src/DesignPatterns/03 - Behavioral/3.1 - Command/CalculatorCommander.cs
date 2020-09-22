using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    internal class CalculatorCommander : Commander
    {
        private char _operating;
        private int _amount;
        private readonly Calculator _calculator;

        public CalculatorCommander(Calculator calculator, char operating, int amount)
        {
            _calculator = calculator;
            _operating = operating;
            _amount = amount;
        }

        public char Operator
        {
            set => _operating = value;
        }

        public int Operand
        {
            set => _amount = value;
        }

        public override void Run()
        {
            _calculator.Operation(_operating, _amount);
        }

        public override void Undo()
        {
            _calculator.Operation(Undo(_operating), _amount);
        }

        private static char Undo(char operating)
        {
            switch (operating)
            {
                case '+': return '-';
                case '-': return '+';
                case '*': return '/';
                case '/': return '*';
                default: throw new ArgumentException("Unknown operator");
            }
        }
    }
}
