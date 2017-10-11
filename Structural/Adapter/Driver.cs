namespace Structural.Adapter
{
    public class Driver
    {
        private readonly IEngine _engine;

        public Driver(IEngine engine)
        {
            _engine = engine;
        }
        public string Move()
        {
            return _engine.RunEngine();
        }
    }
}