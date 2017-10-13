namespace Behavioral.Tests.ChainOfResponsibility
{
    using Behavioral.ChainOfResponsibility;
    using Xunit;

    public class ChainOfResponsibilityTests
    {
        [Fact(DisplayName = "CoR: Stop at first gear")]
        public void StopAtGearOne()
        {
            var g1 = new GearHandler(new Gear(50, "G1"));
            var g2 = new GearHandler(new Gear(100, "G2"));
            var g3 = new GearHandler(new Gear(150, "G3"));
            var g4 = new GearHandler(new Gear(200, "G4"));
            var g5 = new GearHandler(new Gear(250, "G5"));

            g1.SetNextHandler(g2);
            g2.SetNextHandler(g3);
            g3.SetNextHandler(g4);
            g4.SetNextHandler(g5);

            var response = g1.ApplySpeed(49);

            Assert.Equal(GearResponse.InLimit, response.response);
            Assert.Equal("G1", response.gearName);
        }

        [Fact(DisplayName = "CoR: Stop at second gear")]
        public void StopAtGearTwo()
        {
            var g1 = new GearHandler(new Gear(50, "G1"));
            var g2 = new GearHandler(new Gear(100, "G2"));
            var g3 = new GearHandler(new Gear(150, "G3"));
            var g4 = new GearHandler(new Gear(200, "G4"));
            var g5 = new GearHandler(new Gear(250, "G5"));

            g1.SetNextHandler(g2);
            g2.SetNextHandler(g3);
            g3.SetNextHandler(g4);
            g4.SetNextHandler(g5);

            var response = g1.ApplySpeed(50);

            Assert.Equal(GearResponse.InLimit, response.response);
            Assert.Equal("G2", response.gearName);
        }

        [Fact(DisplayName = "CoR: Stop at fifth gear")]
        public void StopAtGearFive()
        {
            var g1 = new GearHandler(new Gear(50, "G1"));
            var g2 = new GearHandler(new Gear(100, "G2"));
            var g3 = new GearHandler(new Gear(150, "G3"));
            var g4 = new GearHandler(new Gear(200, "G4"));
            var g5 = new GearHandler(new Gear(250, "G5"));

            g1.SetNextHandler(g2);
            g2.SetNextHandler(g3);
            g3.SetNextHandler(g4);
            g4.SetNextHandler(g5);

            var response = g1.ApplySpeed(220);

            Assert.Equal(GearResponse.InLimit, response.response);
            Assert.Equal("G5", response.gearName);
        }

        [Fact(DisplayName = "CoR: Stop at Top gear")]
        public void StopAtGearTop()
        {
            var g1 = new GearHandler(new Gear(50, "G1"));
            var g2 = new GearHandler(new Gear(100, "G2"));
            var g3 = new GearHandler(new Gear(150, "G3"));
            var g4 = new GearHandler(new Gear(200, "G4"));
            var g5 = new GearHandler(new Gear(250, "G5"));

            g1.SetNextHandler(g2);
            g2.SetNextHandler(g3);
            g3.SetNextHandler(g4);
            g4.SetNextHandler(g5);

            var response = g1.ApplySpeed(300);

            Assert.Equal(GearResponse.Denied, response.response);
            Assert.Equal("TopGear", response.gearName);
        }
    }
}
