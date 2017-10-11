namespace Structural.Bridge
{
    public class SuperfastEngine : IEngine
    {
        public int GetMaxSpeed(int initialMax)
        {
            return initialMax * 2;
        }
    }
}