namespace Behavioral.Command
{
    public class EngineDown : CommandBase
    {
        public override void Execute()
        {
            CarComponent.Down();
        }

        public override void Undo()
        {
            CarComponent.Up();
        }

        public EngineDown(ICarComponent carComponent) : base(carComponent) { }
    }
}