namespace Creational.Tests.Factory
{
    using Creational.Factory;
    using Xunit;

    public class FactoryTests
    {
        [Fact(DisplayName = "Factory: create Porsche")]
        public void CreatePorsheTest()
        {
            var car = CarFactory.Create("Porsche");

            Assert.Equal("Porsche", car.Name);
        }

        [Fact(DisplayName = "Factory: create Trabant")]
        public void CreateTrabantTest()
        {
            var car = CarFactory.Create("Trabant");

            Assert.Equal("Trabant", car.Name);
        }

        [Fact(DisplayName = "Factory: create Null")]
        public void CreateNullTest()
        {
            var car = CarFactory.Create("BMW");

            Assert.Equal("NullCar", car.Name);
        }

    }
}