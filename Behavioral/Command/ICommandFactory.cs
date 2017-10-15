namespace Behavioral.Command
{
    public interface ICommandFactory<out T>
    {
        string Name { get; set; }

        T Create();
    }
}