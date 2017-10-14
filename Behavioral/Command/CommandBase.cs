namespace Behavioral.Command
{
    public abstract class CommandBase : ICommand
    {
        protected readonly ICarComponent CarComponent;

        protected CommandBase(ICarComponent carComponent)
        {
            CarComponent = carComponent;
        }
        public abstract void Execute();
        public abstract void Undo();
    }
}