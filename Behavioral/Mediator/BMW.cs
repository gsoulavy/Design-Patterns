namespace Behavioral.Mediator
{
    public class BMW : Car
    {
        public BMW(IController controller) : base(controller)
        {
        }

        public override int SafetyGap { get; set; } = 350;
    }
}