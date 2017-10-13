namespace Behavioral.ChainOfResponsibility
{
    public interface IGear
    {
        GearResponse Monitor(Rotation rotation);
        string Name { get; set; }
    }
}