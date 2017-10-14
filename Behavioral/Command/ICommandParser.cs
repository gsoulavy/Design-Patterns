namespace Behavioral.Command
{
    public interface ICommandParser
    {
        ICommand Parse(string argument);
    }
}