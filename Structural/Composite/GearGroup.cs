namespace Structural.Composite
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class GearGroup : IBrakeable
    {
        public GearGroup()
        {
            Gears = new List<Gear>();
        }

        public string GroupPosition { get; set; }
        public IEnumerable<Gear> Gears { get; set; }

        public double BrakeForce
        {
            get => Gears.Sum(g => g.BrakeForce);
            set
            {
                var individualBrakeForce = value / Gears.Count();
                foreach (var gear in Gears)
                {
                    gear.BrakeForce = individualBrakeForce;
                }

            }
        }

        public void Brake()
        {
            foreach (var gear in Gears)
            {
                gear.Brake();
            }
        }
    }
}