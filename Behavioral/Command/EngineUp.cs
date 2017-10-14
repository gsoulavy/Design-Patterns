namespace Behavioral.Command
{
    public class EngineUp : CommandBase
    {
        public override void Execute()
        {
            CarComponent.Up();
        }

        public override void Undo()
        {
            CarComponent.Down();
        }

        public EngineUp(ICarComponent carComponent) : base(carComponent) { }
    }
}