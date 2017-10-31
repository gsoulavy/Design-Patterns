namespace Creational.Tests.FactoryMethod
{
    using Creational.FactoryMethod;
    using Xunit;

    public class FactoryMethodTests
    {
        [Fact(DisplayName = "FactoryMethod: get default")]
        public void GetDefaultCarFactoryTest()
        {
            var client = new Client();
            var car = client.Run();
            Assert.Equal("Porsche", car.Name);
        }

        [Fact(DisplayName = "FactoryMethod: get selected")]
        public void GetTrabantFactoryTest()
        {
            var client = new Client();
            var car = client.Run("Creational.FactoryMethod.TrabantFactory");
            Assert.Equal("Trabant", car.Name);
        }
    }
}