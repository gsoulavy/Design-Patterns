namespace Structural.Tests.EventAggregator
{
    using System.Threading;
    using System.Threading.Tasks;
    using Structural.EventAggregator;
    using Xunit;

    public class EventAggregatorTests
    {
        [Fact(Skip = "Unable to test yet.", DisplayName = "EventAggregator: Free seats changed")]
        public void FreeSeatsChanged()
        {
            var ea = new EventAggregator();
            var car1 = new Car(ea)
            {
                Name = "Car1",
                MaxSeats = 3
            };

            var coordinator = new Coordinator(ea);
            car1.Passengers += 1;
            car1.Passengers += 1;
            car1.Passengers += 1;
            car1.Passengers += 1;

            Assert.Equal(3, coordinator.FreeSeatChangeEventCount);
            Assert.Equal(2, coordinator.AvailibilityChangeEventCount);

            car1.Passengers -= 1;
            Assert.Equal(3, coordinator.AvailibilityChangeEventCount);
            Assert.Equal(4, coordinator.FreeSeatChangeEventCount);
        }
    }
}