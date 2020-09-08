using System;

namespace DesignPatterns.AbstractFactory
{
    // AbstractProduct   
    public abstract class Hoist
    {
        protected Hoist(Size size)
        {
            Size = size;
        }

        public abstract void Help(Vehicle vehicle);
        public Size Size { get; set; }
    }

    // Produto Concreto
    public class SmallHoist : Hoist
    {
        public SmallHoist(Size size) : base(size) { }

        public override void Help(Vehicle vehicle)
        {
            // Processo de socorro
            Console.WriteLine("Socorrendo Carro Pequeno - Modelo " + vehicle.Model);
        }
    }

    // Produto Concreto
    public class MediumHoist : Hoist
    {
        public MediumHoist(Size size) : base(size) { }

        public override void Help(Vehicle vehicle)
        {
            // Processo de socorro
            Console.WriteLine("Socorrendo Carro Medio - Modelo " + vehicle.Model);
        }
    }

    // Produto Concreto
    public class BigHoist : Hoist
    {
        public BigHoist(Size size) : base(size) { }

        public override void Help(Vehicle vehicle)
        {
            // Processo de socorro
            Console.WriteLine("Socorrendo Carro Grande - Modelo " + vehicle.Model);
        }
    }

    public class HoistCreator
    {
        public static Hoist Create(Size size)
        {
            switch (size)
            {
                case Size.Small:
                    return new SmallHoist(size);
                case Size.Medium:
                    return new MediumHoist(size);
                case Size.Big:
                    return new BigHoist(size);
                default:
                    throw new ApplicationException("Porte de Guincho desconhecido.");
            }
        }
    }
}
