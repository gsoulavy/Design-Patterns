namespace Creational.Builder
{
    public abstract class CarBuilder
    {
        protected Car Car;

        public Car GetCar()
        {
            return Car;
        }

        protected internal void CreateCar()
        {
            Car = new Car();
        }

        protected internal abstract void MakeBrand();
        protected internal abstract void MakeEngine();
        protected internal abstract void MakeDoors();
        protected internal abstract void MakeWheels();
    }
}