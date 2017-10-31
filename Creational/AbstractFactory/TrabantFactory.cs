namespace Creational.AbstractFactory
{
    public class TrabantFactory : ICarFactory
    {
        public ICar CreateCheapest()
        {
            return new Trabant(BuildOption.Cheap);
        }

        public ICar CreateExpensive()
        {
            return new Trabant(BuildOption.Expensive);
        }
    }
}