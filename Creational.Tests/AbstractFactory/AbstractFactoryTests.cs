namespace Creational.Tests.AbstractFactory
{
    using Creational.AbstractFactory;
    using Xunit;

    public class AbstractFactoryTests
    {
        [Fact(DisplayName = "AbstractFactory: create default")]
        public void CreateDefaultCheapCar()
        {
            var client = new Client();
            var car = client.Run();
            Assert.Equal("Porsche", car.Name);
            Assert.Equal(BuildOption.Cheap, car.Option);
        }
    }
}