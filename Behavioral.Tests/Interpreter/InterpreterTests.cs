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
            }, new Black(), 
            new BulletProof(1), 
            new Doors
            {
                new Butterfly(1),
                new Conventional(2)
            });

            car.Interpret(context);
            Assert.Equal(
                "|Windows: {w: 1 tire w: 2 tire } -Color: Black -w: 1 bulletproof  -Doors { d: 1 butterfly  d: 2 conventional  } |",
                context.Output);
        }
    }
}