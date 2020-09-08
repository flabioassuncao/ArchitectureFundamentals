using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    // Client Class
    public class SelfHelp
    {
        private readonly Vehicle _vehicle;
        private readonly Hoist _hoist;

        public SelfHelp(SelfHelpFactory factory, Vehicle vehicle)
        {
            _vehicle = factory.CreateVehicle(vehicle.Model, vehicle.Size);
            _hoist = factory.CreateHoist();
        }

        public void CarryOutService()
        {
            _hoist.Help(_vehicle);
        }

        public static SelfHelp CreateSelfHelp(Vehicle vehicle)
        {
            switch (vehicle.Size)
            {
                case Size.Small:
                    return new SelfHelp(new HelpSmallVehicleFactory(), vehicle);
                case Size.Medium:
                    return new SelfHelp(new HelpMediumVehicleFactory(), vehicle);
                case Size.Big:
                    return new SelfHelp(new HelpBigVehicleFactory(), vehicle);
                default:
                    throw new ApplicationException("Não foi possível identificar o veículo");
            }
        }
    }
}
