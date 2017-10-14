namespace Structural.Tests.Adapter
{
    using Structural.Adapter;
    using Xunit;

    public class AdapterTests
    {
        [Fact(DisplayName = "Adapter: Driver with bike")]
        public void DriverWithBike()
        {
            var driver = new Driver(new ManforceAdapter(new Bicycle()));

            Assert.Equal("Ride the bike", driver.Move());
        }

        [Fact(DisplayName = "Adapter: Driver with car")]
        public void DriverWithCar()
        {
            var driver = new Driver(new Car());

            Assert.Equal("Engine runs", driver.Move());
        }
    }
}