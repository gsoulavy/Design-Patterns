namespace Behavioral.Command
{
    public class EnginePanel
    {
        private readonly ICommand _command;

        public EnginePanel(ICommand command)
        {
            _command = command;
        }

        public void Interact()
        {
            _command.Execute();
        }

        public void Reverse()
        {
            _command.Undo();
        }
    }
}