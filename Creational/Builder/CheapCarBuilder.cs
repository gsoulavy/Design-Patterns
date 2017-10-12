namespace Creational.Builder
{
    public class CheapCarBuilder : CarBuilder
    {
        protected internal override void MakeBrand()
        {
            Car.Brand = "Trabant";
        }

        protected internal override void MakeWheels()
        {
            Car.Wheels = WheelType.Aluminium;
        }

        protected internal override void MakeDoors()
        {
            Car.Door = DoorType.Normal;
            Car.NumberOfDoors = 3;
        }

        protected internal override void MakeEngine()
        {
            Car.Engine = EngineType.Benzin;
            Car.MaxSpeed = 120d;
        }
    }
}