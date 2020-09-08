using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    class ExecutionAbstractFactory
    {
        public static void Executar()
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
