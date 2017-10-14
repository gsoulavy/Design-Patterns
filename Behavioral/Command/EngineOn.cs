namespace Behavioral.Command
{
    public class EngineOn : CommandBase
    {
        public override void Execute()
        {
            CarComponent.On();
        }

        public override void Undo()
        {
            CarComponent.Off();
        }

        public EngineOn(ICarComponent carComponent) : base(carComponent) { }
    }
}