namespace Structural.Tests.Bridge
{
    using Structural.Bridge;
    using Xunit;

    public class BridgeTests
    {
        [Fact(DisplayName = "Bridge: Car with normal engine")]
        public void CarWithNormalEngine()
        {
            var car = new Car(new NormalEngine())
            {
                MaxSpeed = 5
            };

            Assert.Equal(5, car.RunWithMaxSpeed());
        }

        [Fact(DisplayName = "Bridge: Car with super fast engine")]
        public void CarWithSuperfastengine()
        {
            var car = new Car(new SuperfastEngine())
            {
                MaxSpeed = 5
            };

            Assert.Equal(10, car.RunWithMaxSpeed());
        }
    }
}