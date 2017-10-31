namespace Creational.FactoryMethod
{
    public class TrabantFactory : ICarFactory
    {
        public ICar Create()
        {
            return new Trabant();
        }
    }
}