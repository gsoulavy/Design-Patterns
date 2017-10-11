namespace Structural.Bridge
{
    public class Car : Vehicle
    {
        public Car(IEngine engine) : base(engine)
        {
        }

        public override int RunWithMaxSpeed()
        {
            return Engine.GetMaxSpeed(MaxSpeed);
        }
    }
}