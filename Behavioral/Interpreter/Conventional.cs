namespace Behavioral.Interpreter
{
    public class Conventional : Door
    {
        private readonly string _name;

        public Conventional(int number)
        {
            _name = $"{number} {nameof(Conventional).ToLower()} ";
        }
        public void Interpret(Context context)
        {
            context.Output += $"d: {_name} ";
        }
    }
}