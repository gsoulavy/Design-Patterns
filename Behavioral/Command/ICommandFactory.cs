namespace Behavioral.Command
{
    public interface ICommandFactory<out T>
    {
        string CommandName { get; set; }

        T Create();
    }
}