namespace Behavioral.Command
{
    public interface IExecutor
    {
        ICarComponent Component { get; }
        void Run(string argument);
    }
}