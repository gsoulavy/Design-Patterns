namespace Structural.Adapter
{
    using System;

    public class Car : IVehicle
    {
        public string RunEngine()
        {
            return "Engine runs";
        }
    }
}