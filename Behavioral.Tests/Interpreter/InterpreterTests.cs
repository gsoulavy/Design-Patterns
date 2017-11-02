namespace Behavioral.Tests.Interpreter
{
    using Behavioral.Interpreter;
    using Xunit;

    public class InterpreterTests
    {
        [Fact(DisplayName = "Interpreter: interpret car")]
        public void InterpretTest()
        {
            var context = new Context();
            var car = new Car(new Wheels()
            {
                new Wheel("1 tire"),
                new Wheel("2 tire")
            }, new Color(), new Window("conventional"), new Doors
            {
                new Door("1 butterfly"),
                new Door("2 butterfly")
            });
            car.Interpret(context);
            Assert.Equal("|Windows: {w: 1 tire w: 2 tire } -Color:  -Window: conventional -Doors { d: 1 butterfly d: 2 butterfly } |", context.Output);
        }
    }
}