namespace Creational.Builder
{
    public class SportsCarBuilder : CarBuilder
    {
        protected internal override void MakeBrand()
        {
            Car.Brand = "Lotus";
        }

        protected internal override void MakeWheels()
        {
            Car.Wheels = WheelType.Alloy;
        }

        protected internal override void MakeDoors()
        {
            Car.Door = DoorType.Scissor;
            Car.NumberOfDoors = 2;
        }

        protected internal override void MakeEngine()
        {
            Car.Engine = EngineType.Electric;
            Car.MaxSpeed = 240d;
        }
    }
}