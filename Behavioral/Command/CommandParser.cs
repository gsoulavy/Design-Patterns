namespace Behavioral.Command
{
    using System.Collections.Generic;
    using System.Linq;

    public class CommandParser : ICommandParser
    {
        private readonly IEnumerable<ICommandFactory<ICommand>> _commandFactories;

        public CommandParser(IEnumerable<ICommandFactory<ICommand>> commandFactories)
        {
            _commandFactories = commandFactories;
        }

        public ICommand Parse(string argument)
        {
            return FindRequestedCommand(argument).Create();
        }

        private ICommandFactory<ICommand> FindRequestedCommand(string requestedCommand)
        {
            var findRequestedCommand = _commandFactories
                .FirstOrDefault(command => command.Name == requestedCommand);
            return findRequestedCommand ?? new CommandFactory<NullCommand>(null) { Name = requestedCommand };
        }
    }
}