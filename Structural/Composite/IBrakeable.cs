namespace Structural.Composite
{
    public interface IBrakeable
    {
        double BrakeForce { get; set; }
        void Brake();
    }
}