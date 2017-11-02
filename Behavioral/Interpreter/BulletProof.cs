namespace Behavioral.Interpreter
{
    public class BulletProof : Window
    {
        private readonly string _name;

        public BulletProof(int number)
        {
            _name = $"{number} {nameof(BulletProof).ToLower()} ";
        }

        public void Interpret(Context context)
        {
            context.Output += $"w: {_name} ";
        }
    }
}