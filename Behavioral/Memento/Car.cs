namespace Behavioral.Memento
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Car
    {
        private readonly Stack<IMemento> _undoStates;
        private readonly Stack<IMemento> _redoStates;
        private readonly EngineWithUndo _engine;

        public Car()
        {
            _undoStates = new Stack<IMemento>();
            _redoStates = new Stack<IMemento>();
            _engine = new EngineWithUndo();
            StoreState();
        }
        public void Undo()
        {
            if (_undoStates.Count > 1)
            {
                _redoStates.Push(_undoStates.Peek());
                _undoStates.Pop();
                var lastState = _undoStates.Peek();
                _engine.SetMemento(lastState);
            }
        }

        public void Redo()
        {
            if (_redoStates.Count > 0)
            {
                var lastState = _redoStates.Pop();
                _engine.SetMemento(lastState);
                StoreState();
            }
        }

        public int Speed
        {
            get => _engine.Speed;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException(nameof(value));
                _engine.Speed = value;
                StoreState();
            }
        }

        private void StoreState()
        {
            var memento = _engine.CreateMemento();
            _undoStates.Push(memento);
        }
    }
}