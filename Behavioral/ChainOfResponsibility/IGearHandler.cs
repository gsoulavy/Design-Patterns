namespace Behavioral.ChainOfResponsibility
{
    public interface IGearHandler
    {
        void SetNextHandler(IGearHandler nextGear);
        (GearResponse response, string gearName) ApplySpeed(Rotation speed);
    }
}