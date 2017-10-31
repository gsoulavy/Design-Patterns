namespace Creational.FactoryMethod
{
    using System.Reflection;
    using Factory;

    public interface ICarFactory
    {
        ICar Create();
    }

    public class PorscheFactory : ICarFactory
    {
        public ICar Create()
        {
            return new Porsche();;
        }
    }

    public class TrabantFactory : ICarFactory
    {
        public ICar Create()
        {
            return new Trabant();
        }
    }

    public interface ICar
    {
        string Name { get; }
    }

    public class Porsche : ICar
    {
        public string Name { get; }

        public Porsche()
        {
            Name = "Porsche";
        }
    }

    public class Trabant : ICar
    {
        public string Name { get; }

        public Trabant()
        {
            Name = "Trabant";
        }
    }
}