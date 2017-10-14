namespace Behavioral.Command
{
    public class EngineOff : CommandBase
    {
        public EngineOff(ICarComponent carComponent) : base(carComponent)
        {
        }

        public override void Execute()
        {
            CarComponent.Off();
        }

        public override void Undo()
        {
            CarComponent.On();
        }
    }
}