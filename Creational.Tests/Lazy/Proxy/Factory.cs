namespace Creational.Tests.Lazy.Proxy
{
    public class Factory
    {
        public Car Create(int id) => new CarProxy { Id = id };
    }
}