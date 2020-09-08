using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    public class HelpMediumVehicleFactory : SelfHelpFactory
    {
        public override Hoist CreateHoist()
        {
            return HoistCreator.Create(Size.Medium);
        }

        public override Vehicle CreateVehicle(string model, Size size)
        {
            return VehicleCreator.Create(model, size);
        }
    }
}
