namespace Behavioral.Mediator
{
    public class Porsche : Car
    {
        public Porsche(IController controller) : base(controller)
        {
        }

        public override int SafetyGap { get; set; } = 400;
    }
}