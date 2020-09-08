namespace DesignPatterns.AbstractFactory
{
    public abstract class SelfHelpFactory
    {
        public abstract Hoist CreateHoist();
        public abstract Vehicle CreateVehicle(string model, Size size);
    }
}
