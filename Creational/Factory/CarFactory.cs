namespace Creational.Factory
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    public static class CarFactory
    {
        private static readonly Dictionary<string, Type> Cars;

        static CarFactory()
        {
            Cars = new Dictionary<string, Type>();

            var types = Assembly.GetExecutingAssembly()
                .GetTypes().Where(t => t.GetInterface(typeof(ICar).ToString()) != null)
                .ToArray();

            foreach (var type in types)
            {
                Cars.Add(type.Name.ToLower(), type);
            }

        }
        public static ICar Create(string carName)
        {
            if (Cars.TryGetValue(carName.ToLower(), out var iCarType))
            {
                return Activator.CreateInstance(iCarType) as ICar;
            }
            return new NullCar();

        }

        private static Type GetTypeByName(string carName)
        {
            Cars.TryGetValue(carName, out var iCar);
            return iCar;
        }
    }
}