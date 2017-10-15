namespace Behavioral.Command
{
    using System;

    internal class NullCommand : ICommand
    {
        public void Execute()
        {
            LogError();
        }

        public void Undo()
        {
            LogError();
        }

        private static void LogError()
        {
            Console.WriteLine("Given command doesn't exist.");
        }
    }
}