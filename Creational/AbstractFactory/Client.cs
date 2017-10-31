namespace Creational.AbstractFactory
{
    using System.Reflection;

    public class Client
    {
        public ICar Run(string factoryName = "Creational.AbstractFactory.PorscheFactory", BuildOption buildOption = BuildOption.Cheap)
        {
            var factory = Assembly.GetExecutingAssembly().CreateInstance(factoryName) as ICarFactory;
            switch (buildOption)
            {
                case BuildOption.Cheap:
                    return factory?.CreateCheapest();
                case BuildOption.Expensive:
                    return factory?.CreateExpensive();
                default:
                    return factory?.CreateCheapest();
            }
        }
    }
}