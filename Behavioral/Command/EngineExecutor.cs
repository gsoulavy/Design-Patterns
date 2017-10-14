namespace Behavioral.Command
{
    using System.Collections.Generic;

    public class EngineExecutor : IExecutor
    {
        public EngineExecutor(ICarComponent component)
        {
            Component = component;
        }

        public ICarComponent Component { get; }

        public void Run(string argument)
        {
            var commandFactories = GetFactories(Component);
            var parser = new CommandParser(commandFactories);
            var command = parser.Parse(argument);
            command.Execute();
        }

        private static IEnumerable<ICommandFactory<ICommand>> GetFactories(ICarComponent component)
        {
            return new ICommandFactory<ICommand>[]
            {
                new CommandFactory<EngineOn>(component) {CommandName = "On"},
                new CommandFactory<EngineOff>(component) {CommandName = "Off"},
                new CommandFactory<EngineUp>(component) {CommandName = "Up"},
                new CommandFactory<EngineDown>(component) {CommandName = "Down"}
            };
        }
    }
}