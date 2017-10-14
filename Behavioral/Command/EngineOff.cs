namespace Behavioral.Command
{
    public class EngineOff : CommandBase
    {
        public override void Execute()
        {
            CarComponent.Off();
        }

        public override void Undo()
        {
            CarComponent.On();
        }

        public EngineOff(ICarComponent carComponent) : base(carComponent) { }
    }
}