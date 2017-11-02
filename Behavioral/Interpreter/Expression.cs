namespace Behavioral.Interpreter
{
    public interface Expression
    {
        void Interpret(Context context);
    }
}