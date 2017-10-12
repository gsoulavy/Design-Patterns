namespace Creational.Builder
{
    public class CarMaker
    {
        private readonly CarBuilder _builder;

        public CarMaker(CarBuilder builder)
        {
            _builder = builder;
        }

        public void MakeCar()
        {
            _builder.CreateCar();
            _builder.MakeBrand();
            _builder.MakeEngine();
            _builder.MakeDoors();
            _builder.MakeWheels();
        }

        public Car GetCar()
        {
            return _builder.GetCar();
        }
    }
}