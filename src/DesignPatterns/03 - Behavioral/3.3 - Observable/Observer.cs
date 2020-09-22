using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observable
{
    // Concrete Observer
    internal class Observer : IObserver
    {
        public Observer(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public void Notify(Investment investment)
        {
            Console.WriteLine("Notifying {0} that {1} " +
                              "had price changed to {2:C}", Name, investment.Symbol, investment.Amount);
        }
    }
}
