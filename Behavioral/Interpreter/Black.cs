namespace Behavioral.Interpreter
{
    public class Black : Color
    {
        public void Interpret(Context context)
        {
            context.Output += $"Color: {nameof(Black)} ";
        }
    }
}