namespace Structural.Bridge
{
    public class NormalEngine : IEngine
    {
        public int GetMaxSpeed(int initialMax)
        {
            return initialMax;
        }
    }
}