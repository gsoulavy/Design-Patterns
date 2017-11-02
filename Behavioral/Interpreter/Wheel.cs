namespace Behavioral.Interpreter
{
    public class Wheel : Expression
    {
        private readonly string _name;

        public Wheel(string name)
        {
            _name = name;
        }
        public void Interpret(Context context)
        {
            context.Output += $"w: {_name} ";
        }
    }
}