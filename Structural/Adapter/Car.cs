namespace Structural.Adapter
{
    using System;

    public class Car : IEngine
    {
        public string RunEngine()
        {
            return "Engine runs";
        }
    }
}