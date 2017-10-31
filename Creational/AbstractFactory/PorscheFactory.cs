namespace Creational.AbstractFactory
{
    public class PorscheFactory : ICarFactory
    {
        public ICar CreateCheapest()
        {
            return new Porsche(BuildOption.Cheap);
        }

        public ICar CreateExpensive()
        {
            return new Porsche(BuildOption.Expensive);
        }
    }
}