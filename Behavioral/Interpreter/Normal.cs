namespace Behavioral.Interpreter
{
    public class Normal : Window
    {
        private readonly string _name;

        public Normal(int number)
        {
            _name = $"{number} {nameof(Normal).ToLower()} ";
        }

        public void Interpret(Context context)
        {
            context.Output += $"w: {_name} ";
        }
    }
}