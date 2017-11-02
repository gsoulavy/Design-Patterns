namespace Behavioral.Interpreter
{
    using System.Collections.Generic;

    public class Doors : List<Door>, Expression
    {
        public void Interpret(Context context)
        {
            context.Output += "Doors { ";
            ForEach(d => d.Interpret(context));
            context.Output += "} ";
        }
    }
}