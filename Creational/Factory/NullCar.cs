namespace Creational.Factory
{
    public class NullCar : ICar
    {
        public string Name { get; }

        public NullCar()
        {
            Name = "NullCar";
        }
    }
}