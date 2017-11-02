namespace Behavioral.Interpreter
{
    public class Butterfly : Door
    {
        private readonly string _name;

        public Butterfly(int number)
        {
            _name =  $"{number} {nameof(Butterfly).ToLower()} ";
        }
        public void Interpret(Context context)
        {
            context.Output += $"d: {_name} ";
        }
    }
}