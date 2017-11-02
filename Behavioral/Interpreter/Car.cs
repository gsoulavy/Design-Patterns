namespace Behavioral.Interpreter
{
    using System.Collections;
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
}