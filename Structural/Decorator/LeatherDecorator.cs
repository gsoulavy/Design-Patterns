namespace Structural.Decorator
{
    public class LeatherDecorator : CarDecorator
    {
        public LeatherDecorator(Car car) : base(car)
        {
            _name = "leather";
            _cost = 450;
        }

        public override string Name => $"{Car.Name} + {_name}";

        public override double Cost => Car.Cost + _cost;
    }
}