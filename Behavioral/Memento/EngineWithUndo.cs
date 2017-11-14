namespace Behavioral.Memento
{
    public class EngineWithUndo : Engine
    {
        public IMemento CreateMemento()
        {
            var copy = Speed;
            return new EngineMemento { State = copy};
        }

        public void SetMemento(IMemento memento) => Speed = (int)memento.State;

        public class EngineMemento : IMemento
        {
            public object State { get; set; }
        }
    }
}