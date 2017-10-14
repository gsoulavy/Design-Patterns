namespace Behavioral.Command
{
    public class EngineOn : CommandBase
    {
        public EngineOn(ICarComponent carComponent) : base(carComponent)
        {
        }

        public override void Execute()
        {
            CarComponent.On();
        }

        public override void Undo()
        {
            CarComponent.Off();
        }
    }
}