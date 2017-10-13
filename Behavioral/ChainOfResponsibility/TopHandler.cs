namespace Behavioral.ChainOfResponsibility
{
    using System;

    internal class TopHandler : IGearHandler
    {
        private TopHandler() { }

        public static IGearHandler Instance { get; } = new TopHandler();

        public void SetNextHandler(GearHandler nextGear)
        {
            throw new InvalidOperationException();
        }

        public (GearResponse response, string gearName) ApplySpeed(Rotation speed)
        {
            return (GearResponse.Denied, "TopGear");
        }
    }
}