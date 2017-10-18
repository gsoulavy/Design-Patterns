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
            var totalForce = 1500d;
            var flg = new Gear {Position = "Front Left"};
            var frg = new Gear {Position = "Front Right"};
            var mlg = new Gear {Position = "Middle Left"};
            var mrg = new Gear {Position = "Middle Rigth"};
            var blg = new Gear {Position = "Rear Left"};
            var brg = new Gear {Position = "Rear Right"};
            var rearGears = new GearGroup {Gears = new List<Gear> {blg, brg}};

            var gears = new List<IBrakeable> {flg, frg, mlg, mrg, rearGears};

            var totalSplit = gears.Count;

            var amountForEach = totalForce / totalSplit;

            foreach (var brakeable in gears)
            {
                brakeable.BrakeForce = amountForEach;
            }

            Assert.Equal(300, flg.BrakeForce);
            Assert.Equal(150, blg.BrakeForce);
            Assert.Equal(300, rearGears.BrakeForce);
        }
    }
}