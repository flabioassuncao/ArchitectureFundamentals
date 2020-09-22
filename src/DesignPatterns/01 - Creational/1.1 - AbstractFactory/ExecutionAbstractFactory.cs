using System.Collections.Generic;

namespace DesignPatterns.AbstractFactory
{
    class ExecutionAbstractFactory
    {
        public static void Run()
        {
            var veiculosSocorro = new List<Vehicle>
            {
                VehicleCreator.Create("Celta", Size.Small),
                VehicleCreator.Create("Jetta", Size.Medium),
                VehicleCreator.Create("BMW X6", Size.Big)
            };

            veiculosSocorro.ForEach(v => SelfHelp.CreateSelfHelp(v).CarryOutService());
        }
    }
}
