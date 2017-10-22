namespace Structural.Decorator
{
    public class CarDecorator : Car
    {
        protected readonly Car Car;

        public CarDecorator(Car car)
        {
            Car = car;
        }

        public override string Name => Car.Name;

        public override double Cost => Car.Cost;
    }
}