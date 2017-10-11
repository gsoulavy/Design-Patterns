namespace Structural.Bridge
{
    public class Car
    {
        private IEngine _engine;

        public Car(IEngine engine)
        {
            _engine = engine;
        }

        public int MaxSpeed { get; set; }

        public int RunWithMaxSpeed()
        {
            return _engine.GetMaxSpeed(MaxSpeed);
        }
    }
}