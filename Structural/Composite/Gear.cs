namespace Structural.Composite
{
    using System;

    public class Gear : IBrakeable
    {
        public string Position { get; set; }
        public double BrakeForce { get; set; }

        public void Brake()
        {
            Console.WriteLine($"Gear: {Position}, Brake force: {BrakeForce}.");
        }
    }
}