namespace Behavioral.Interpreter
{
    public class Blue : Color
    {
        public void Interpret(Context context)
        {
            context.Output += $"Color: {nameof(Blue)} ";
        }
    }
}