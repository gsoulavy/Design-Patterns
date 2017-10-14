namespace Structural.Adapter
{
    public class Car : IEngine
    {
        public string RunEngine()
        {
            return "Engine runs";
        }
    }
}