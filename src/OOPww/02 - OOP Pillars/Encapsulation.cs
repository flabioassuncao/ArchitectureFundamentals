using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class CoffeeAutomation
    {
        public void ServingCoffee()
        {
            var express = new CoffeMachine();
            express.TurnOn();
            express.PrepareCoffee();
            express.TurnOff();
        }
    }
}
