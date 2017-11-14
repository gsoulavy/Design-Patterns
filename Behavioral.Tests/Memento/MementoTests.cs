namespace Behavioral.Tests.Memento
{
    using System.Collections;
    using System.Collections.Generic;
    using Behavioral.Memento;
    using Xunit;

    public class MementoTests
    {
        [Fact(DisplayName = "Memento: Undo")]
        public void UndoTest()
        {
            var car = new Car {Speed = 5};
            car.Speed = 12;
            car.Speed = 40;
            Assert.Equal(40, car.Speed);
            car.Undo();
            Assert.Equal(12, car.Speed);
            car.Undo();
            Assert.Equal(5, car.Speed);
        }

        [Fact(DisplayName = "Memento: Redo")]
        public void RedoTest()
        {
            var car = new Car() {Speed = 5};
            car.Speed = 12;
            car.Speed = 40;
            Assert.Equal(40, car.Speed);
            car.Undo();
            Assert.Equal(12, car.Speed);
            car.Undo();
            Assert.Equal(5, car.Speed);
            car.Redo();
            Assert.Equal(12, car.Speed);
            car.Redo();
            Assert.Equal(40, car.Speed);
        }

        [Fact(DisplayName = "Memento: Undo/Redo/Undo")]
        public void UndoRedoTest()
        {
            var car = new Car() { Speed = 5 };
            car.Speed = 12;
            car.Speed = 40;
            Assert.Equal(40, car.Speed);
            car.Undo();
            Assert.Equal(12, car.Speed);
            car.Undo();
            Assert.Equal(5, car.Speed);
            car.Redo();
            Assert.Equal(12, car.Speed);
            car.Redo();
            Assert.Equal(40, car.Speed);
            car.Undo();
            Assert.Equal(12, car.Speed);
        }
    }
}