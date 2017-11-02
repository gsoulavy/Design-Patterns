namespace Structural.Flyweight
{
    using System.Collections.Generic;

    public class FlyweightFactory
    {
        private static readonly Dictionary<Color, ICar> Cars = new Dictionary<Color, ICar>();
        public static ICar Create(Color color, Size size)
        {
            if (Cars.TryGetValue(color, out var car))
            {
                car.Size = size;
                return car;
            }
            var newCar = new Car {Color = color, Size = size};
            Cars.Add(color, newCar);
            return newCar;
        }
    }
}