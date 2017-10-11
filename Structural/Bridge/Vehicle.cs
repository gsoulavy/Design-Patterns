namespace Structural.Bridge
{
    public abstract class Vehicle
    {
        protected IEngine Engine;

        protected Vehicle(IEngine engine)
        {
            Engine = engine;
        }

        public int MaxSpeed { get; set; }

        public abstract int RunWithMaxSpeed();
    }
}