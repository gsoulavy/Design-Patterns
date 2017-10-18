namespace Structural.Tests.Composite
{
    using System.Collections.Generic;
    using System.Runtime.InteropServices.ComTypes;
    using Structural.Composite;
    using Xunit;

    public class CompositeTests
    {
        [Fact(DisplayName = "Composite: Distribute")]
        public void CompositeTest()
        {
            const double totalForce = 1500d;
            var flwheel = new Wheel {Position = "Front Left"};
            var frwheel = new Wheel {Position = "Front Right"};
            var mlwheel = new Wheel {Position = "Middle Left"};
            var mrwheel = new Wheel {Position = "Middle Rigth"};
            var rlwheel = new Wheel {Position = "Rear Left"};
            var rrwheel = new Wheel {Position = "Rear Right"};
            var rearWheels = new WheelGroup {Gears = new List<Wheel> {rlwheel, rrwheel}};

            new WheelGroup
            {
                Gears = new List<IBrakeable> {flwheel, frwheel, mlwheel, mrwheel, rearWheels},
                BrakeForce = totalForce
            };

            Assert.Equal(300, flwheel.BrakeForce);
            Assert.Equal(150, rlwheel.BrakeForce);
            Assert.Equal(300, rearWheels.BrakeForce);
        }
    }
}