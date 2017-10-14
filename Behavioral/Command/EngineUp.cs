namespace Behavioral.Command
{
    public class EngineUp : CommandBase
    {
        public EngineUp(ICarComponent carComponent) : base(carComponent)
        {
        }

        public override void Execute()
        {
            CarComponent.Up();
        }

        public override void Undo()
        {
            CarComponent.Down();
        }
    }
}