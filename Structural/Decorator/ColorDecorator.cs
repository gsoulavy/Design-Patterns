namespace Structural.Decorator
{
    public class ColorDecorator : CarDecorator
    {
        public ColorDecorator(Car car) : base(car)
        {
            _name = "color";
            _cost = 250;
        }

        public override string Name => $"{Car.Name} + {_name}";

        public override double Cost => Car.Cost + _cost;
    }
}