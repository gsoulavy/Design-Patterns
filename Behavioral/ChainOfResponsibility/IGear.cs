namespace Behavioral.ChainOfResponsibility
{
    public interface IGear
    {
        string Name { get; set; }
        GearResponse Monitor(Rotation rotation);
    }
}