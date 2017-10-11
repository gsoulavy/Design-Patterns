namespace Structural.Adapter
{
    using System;

    public class Bicycle : IManforce
    {
        public string Ride()
        {
            return "Ride the bike";
        }
    }
}