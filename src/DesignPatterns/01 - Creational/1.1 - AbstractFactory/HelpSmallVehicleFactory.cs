namespace DesignPatterns.AbstractFactory
{
    public class HelpSmallVehicleFactory : SelfHelpFactory
    {
        public override Hoist CreateHoist()
        {
            return HoistCreator.Create(Size.Small);
        }

        public override Vehicle CreateVehicle(string model, Size size)
        {
            return VehicleCreator.Create(model, size);
        }
    }
}