namespace Structural.Tests.Adapter
{
    using Structural.Adapter;
    using Xunit;

    public class AdapterTest
    {
        [Fact(DisplayName = "Adapter: Driver with car")]
        public void DriverWithCar()
        {
            var driver = new Driver(new Car());

            Assert.Equal("Engine runs", driver.Move());
        }

        [Fact(DisplayName = "Adapter: Driver with bike")]
        public void DriverWithBike()
        {
            var driver = new Driver(new BicycleAdapter());

            Assert.Equal("Ride the bike", driver.Move());
        }
    }
}