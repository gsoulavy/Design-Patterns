namespace Creational.FactoryMethod
{
    public class PorscheFactory : ICarFactory
    {
        public ICar Create()
        {
            return new Porsche();;
        }
    }
}