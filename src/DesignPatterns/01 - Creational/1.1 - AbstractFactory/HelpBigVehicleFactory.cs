namespace DesignPatterns.AbstractFactory
{
    // Concrete Factory
    public class HelpBigVehicleFactory : SelfHelpFactory
    {
        public override Hoist CreateHoist()
        {
            return HoistCreator.Create(Size.Big);
        }

        public override Vehicle CreateVehicle(string model, Size size)
        {
            return VehicleCreator.Create(model, size);
        }
    }
}
