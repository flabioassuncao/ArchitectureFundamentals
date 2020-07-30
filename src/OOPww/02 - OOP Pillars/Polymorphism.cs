using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    // Polymorphism
    public class CoffeMachine : HouseholdAppliance
    {
        public CoffeMachine(string name, int voltage) : base(name, voltage)
        {
        }

        public CoffeMachine()
        : base("coffe", 220)
        {

        }

        private static void HeatWater() { }
        private static void GrindGrain() { }

        public void PrepareCoffee()
        {
            Test();
            HeatWater();
            GrindGrain();

            // ETC...
        }

        public override void Test2()
        {
            // test the coffe machine
        }

        public override void TurnOn()
        {
            // to do something  
        }

        public override void TurnOff()
        {
            //to do something 
        }
    }
}
