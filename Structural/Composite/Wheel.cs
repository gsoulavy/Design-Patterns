namespace Structural.Composite
{
    using System;

    public class Wheel : IBrakeable
    {
        public string Position { get; set; }
        public double BrakeForce { get; set; }

        public void Brake()
        {
            Console.WriteLine($"Wheel: {Position}, Brake force: {BrakeForce}.");
        }
    }
}