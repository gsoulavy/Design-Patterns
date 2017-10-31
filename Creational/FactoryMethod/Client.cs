namespace Creational.FactoryMethod
{
    using System;
    using System.Reflection;

    public class Client
    {
        public ICar Run(string factoryName = "Creational.FactoryMethod.PorscheFactory")
        {
            var factory = Assembly.GetExecutingAssembly().CreateInstance(factoryName) as ICarFactory;
            return factory?.Create();
        }
    }
}