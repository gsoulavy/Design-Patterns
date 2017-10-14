namespace Behavioral.Tests.Command
{
    using Behavioral.Command;
    using Xunit;

    public class CommandTests
    {
        [Fact(DisplayName = "Command: Turn on and off with executor")]
        public void TurnOnAndOffWithExecutor()
        {
            var engine = new CarEngine();
            var executor = new EngineExecutor(engine);
            Assert.False(engine.IsEngineOn);
            executor.Run("On");
            Assert.True(engine.IsEngineOn);
            executor.Run("Off");
            Assert.False(engine.IsEngineOn);
        }


        [Fact(DisplayName = "Command: Turn on, up, down and off with executor")]
        public void TurnOnAndUpAndDownWithExecutor()
        {
            var engine = new CarEngine();
            var executor = new EngineExecutor(engine);
            Assert.False(engine.IsEngineOn);
            executor.Run("On");
            Assert.True(engine.IsEngineOn);
            Assert.Equal(0, engine.Rpm);
            executor.Run("Up");
            Assert.Equal(1, engine.Rpm);
            executor.Run("Up");
            Assert.Equal(2, engine.Rpm);
            executor.Run("Down");
            Assert.Equal(1, engine.Rpm);
            Assert.True(engine.IsEngineOn);
            executor.Run("Off");
            Assert.False(engine.IsEngineOn);
            Assert.Equal(0, engine.Rpm);
        }

        [Fact(DisplayName = "Command: Turn on and up with executor")]
        public void TurnOnAndUpWithExecutor()
        {
            var engine = new CarEngine();
            var executor = new EngineExecutor(engine);
            Assert.False(engine.IsEngineOn);
            executor.Run("On");
            Assert.True(engine.IsEngineOn);
            Assert.Equal(0, engine.Rpm);
            executor.Run("Up");
            Assert.Equal(1, engine.Rpm);
        }

        [Fact(DisplayName = "Command: Turn on")]
        public void TurnOnTest()
        {
            var engine = new CarEngine();

            var on = new EngineOn(engine);
            var off = new EngineOff(engine);
            var up = new EngineUp(engine);
            var down = new EngineDown(engine);

            var panelOn = new EnginePanel(on);

            Assert.False(engine.IsEngineOn);
            panelOn.Interact();
            Assert.True(engine.IsEngineOn);
        }

        [Fact(DisplayName = "Command: Turn on with executor")]
        public void TurnOnWithExecutor()
        {
            var engine = new CarEngine();
            var executor = new EngineExecutor(engine);
            Assert.False(engine.IsEngineOn);
            executor.Run("On");
            Assert.True(engine.IsEngineOn);
        }

        [Fact(DisplayName = "Command: Up with executor")]
        public void UpWithExecutor()
        {
            var engine = new CarEngine();
            var executor = new EngineExecutor(engine);
            Assert.False(engine.IsEngineOn);
            Assert.Equal(0, engine.Rpm);
            executor.Run("Up");
            Assert.Equal(0, engine.Rpm);
        }
    }
}