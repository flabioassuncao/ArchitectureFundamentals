using System;

namespace DesignPatterns.AbstractFactory
{
    // AbstractProduct  
    public abstract class Vehicle
    {
        protected Vehicle(string model, Size size)
        {
            Model = model;
            Size = size;
        }

        public string Model { get; set; }
        public Size Size { get; set; }

    }

    public enum Size
    {
        Small,
        Medium,
        Big
    }

    // Produto Concreto
    public class SmallVehicle : Vehicle
    {
        public SmallVehicle(string model, Size size) : base(model, size)
        {
        }
    }

    // Produto Concreto
    public class MediumVehicle : Vehicle
    {
        public MediumVehicle(string model, Size size) : base(model, size)
        {
        }
    }

    // Produto Concreto
    public class BigVehicle : Vehicle
    {
        public BigVehicle(string model, Size size) : base(model, size)
        {
        }
    }

    public class VehicleCreator
    {
        public static Vehicle Create(string modelo, Size size)
        {
            switch (size)
            {
                case Size.Small:
                    return new SmallVehicle(modelo, size);
                case Size.Medium:
                    return new MediumVehicle(modelo, size);
                case Size.Big:
                    return new BigVehicle(modelo, size);
                default:
                    throw new ApplicationException("Porte de veiculo desconhecido.");
            }
        }
    }
}
