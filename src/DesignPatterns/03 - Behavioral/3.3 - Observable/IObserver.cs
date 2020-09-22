using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observable
{
    public interface IObserver
    {
        string Name { get; }
        void Notify(Investment investment);
    }
}
