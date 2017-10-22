namespace Structural.Tests.Decorator
{
    using Structural.Decorator;
    using Xunit;

    public class DecoratorTests
    {
        [Fact(DisplayName = "Decorator: Create Trabant")]
        public void CreateTrabant()
        {
            var car = new Trabant();

            Assert.Equal("Trabant", car.Name);
            Assert.Equal(5000, car.Cost);
        }

        [Fact(DisplayName = "Decorator: Create Porsche")]
        public void CreatePorsche()
        {
            var car = new Porsche();

            Assert.Equal("Porsche", car.Name);
            Assert.Equal(100000, car.Cost);
        }

        [Fact(DisplayName = "Decorator: Create Trabant + color")]
        public void CreateTrabantWithColor()
        {
            Car car = new Trabant();
            car = new ColorDecorator(car);

            Assert.Equal("Trabant + color", car.Name);
            Assert.Equal(5250, car.Cost);
        }

        [Fact(DisplayName = "Decorator: Create Porsche + color")]
        public void CreatePorscheWithColor()
        {
            Car car = new Porsche();
            car = new ColorDecorator(car);

            Assert.Equal("Porsche + color", car.Name);
            Assert.Equal(100250, car.Cost);
        }

        [Fact(DisplayName = "Decorator: Create Trabant + color + leather")]
        public void CreateTrabantWithColorAndLeather()
        {
            Car car = new Trabant();
            car = new ColorDecorator(car);
            car = new LeatherDecorator(car);

            Assert.Equal("Trabant + color + leather", car.Name);
            Assert.Equal(5700, car.Cost);
        }

        [Fact(DisplayName = "Decorator: Create Porsche + color + leather")]
        public void CreatePorscheWithColorAndLeather()
        {
            Car car = new Porsche();

            car = new ColorDecorator(car);
            car = new LeatherDecorator(car);

            Assert.Equal("Porsche + color + leather", car.Name);
            Assert.Equal(100700, car.Cost);
        }
    }
}