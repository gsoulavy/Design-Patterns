namespace Creational.Builder
{
    public class Car
    {
        public string Brand { get; set; }
        public DoorType Door { get; set; }
        public int NumberOfDoors { get; set; }
        public double MaxSpeed { get; set; }
        public EngineType Engine { get; set; }
        public WheelType Wheels { get; set; }
    }
}