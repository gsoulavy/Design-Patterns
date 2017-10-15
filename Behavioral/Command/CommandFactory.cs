namespace Behavioral.Command
{
    using System;

    public class CommandFactory<T> : ICommandFactory<T>
    {
        private readonly ICarComponent _component;

        public CommandFactory(ICarComponent component)
        {
            _component = component;
        }

        public string CommandName { get; set; }

        public T Create()
        {
            return (T) Activator.CreateInstance(typeof(T), _component);
        }
    }
}