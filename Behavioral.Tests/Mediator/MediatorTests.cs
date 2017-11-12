namespace Behavioral.Tests.Mediator
{
    using Behavioral.Mediator;
    using Xunit;

    public class MediatorTests
    {
        [Fact(DisplayName = "Mediator: using controller")]
        public void StillOutOfSafetyGap()
        {
            var controller = new Controller();
            var porsche = new Porsche(controller) {Location = 1500};
            var bmw = new BMW(controller) {Location = 1000};

            controller.Register(porsche);
            controller.Register(bmw);

            Assert.Equal(1500, porsche.Location);
            Assert.Equal(1000, bmw.Location);
            porsche.Location = 1090;
            Assert.Equal(1090, porsche.Location);
            porsche.Location = 1190;
            Assert.Equal(1100, porsche.Location);
        }
    }
}