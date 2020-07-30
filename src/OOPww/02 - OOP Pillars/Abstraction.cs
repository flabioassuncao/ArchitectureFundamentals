using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public abstract class HouseholdAppliance
    {
        private readonly string _name;
        private readonly int _voltage;

        protected HouseholdAppliance(string name, int voltage)
        {
            _name = name;
            _voltage = voltage;
        }

        public abstract void TurnOn();
        public abstract void TurnOff();

        public void Test()
        {
            // test the equipment
        }

        public virtual void Test2()
        {
            // test the equipment
        }
    }
}
