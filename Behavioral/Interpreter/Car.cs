namespace Behavioral.Interpreter
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    // Backus–Naur form (BNR) from:
    // <Car> ::=  <Wheels> <Color> <Window> <Doors>
    // <Wheels> ::=  {<Wheel>}
    // <Color> ::= <Black>|<Blue>
    // <Window> ::= <Normal>|<BulletProof>
    // <Doors> ::= {<Door>}
    // <Door> ::= <Conventional>|<Butterfly>
    
    public class Car : Expression
    {
        public Wheels Wheels { get; set; }
        public Color Color { get; set; }
        public Window Window { get; set; }
        public Doors Doors { get; set; }

        public Car(Wheels wheels, Color color, Window window, Doors doors)
        {
            Wheels = wheels;
            Color = color;
            Window = window;
            Doors = doors;
        }
        public void Interpret(Context context)
        {
            context.Output += "|";
            Wheels.Interpret(context);
            context.Output += "-";
            Color.Interpret(context);
            context.Output += "-";
            Window.Interpret(context);
            context.Output += "-";
            Doors.Interpret(context);
            context.Output += "|";
        }
    }

    public class Wheels : List<Wheel>, Expression
    {
        public void Interpret(Context context)
        {
            context.Output += "Windows: {";
            ForEach(w => w.Interpret(context));
            context.Output += "} ";
        }
    }

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

    public class Color : Expression
    {
        public string Name { get; set; }
        public void Interpret(Context context)
        {
            context.Output += $"Color: {Name} ";
        }
    }

    public class Window : Expression
    {
        private readonly string _name;

        public Window(string name)
        {
            _name = name;
        }

        public void Interpret(Context context)
        {
            context.Output += $"Window: {_name} ";
        }
    }

    public class Doors : List<Door>, Expression
    {
        public void Interpret(Context context)
        {
            context.Output += "Doors { ";
            ForEach(d => d.Interpret(context));
            context.Output += "} ";
        }
    }

    public class Door : Expression
    {
        private readonly string _name;

        public Door(string name)
        {
            _name = name;
        }
        public void Interpret(Context context)
        {
            context.Output += $"d: {_name} ";
        }
    }
}