namespace Behavioral.Interpreter
{
    using System.Collections.Generic;

    public class Wheels : List<Wheel>, Expression
    {
        public void Interpret(Context context)
        {
            context.Output += "Windows: {";
            ForEach(w => w.Interpret(context));
            context.Output += "} ";
        }
    }
}