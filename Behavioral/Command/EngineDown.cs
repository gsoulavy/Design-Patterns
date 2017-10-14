namespace Behavioral.Command
{
    public class EngineDown : CommandBase
    {
        public EngineDown(ICarComponent carComponent) : base(carComponent)
        {
        }

        public override void Execute()
        {
            CarComponent.Down();
        }

        public override void Undo()
        {
            CarComponent.Up();
        }
    }
}