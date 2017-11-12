namespace Behavioral.Mediator
{
    public interface ICar
    {
        string CarIdentifyer { get; set; }
        int Location { get; set; }
        int SafetyGap { get; set; }
    }
}