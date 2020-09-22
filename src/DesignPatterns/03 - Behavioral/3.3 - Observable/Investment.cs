using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observable
{
    public abstract class Investment
    {
        private decimal _amount;
        private readonly List<IObserver> _observers = new List<IObserver>();

        protected Investment(string symbol, decimal amount)
        {
            Symbol = symbol;
            _amount = amount;
        }

        public string Symbol { get; }
        public decimal Amount
        {
            get => _amount;
            set
            {
                if (_amount == value) return;

                _amount = value;
                Notify();
            }
        }


        public void Subscribe(IObserver observer)
        {
            _observers.Add(observer);
            Console.WriteLine($"Notifying that {observer.Name} is receiving updates from {Symbol}");
        }

        public void UnSubscribe(IObserver observer)
        {
            _observers.Remove(observer);
            Console.WriteLine($"Notifying that {observer.Name} is NOT receiving updates from {Symbol}");
        }

        private void Notify()
        {
            foreach (var investor in _observers)
            {
                investor.Notify(this);
            }

            Console.WriteLine("");
        }
    }
}
