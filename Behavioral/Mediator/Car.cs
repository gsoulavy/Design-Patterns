namespace Behavioral.Mediator
{
    public abstract class Car : ICar
    {
        private readonly IController _controller;
        private int _location;
        public string CarIdentifyer { get; set; }

        public Car(IController controller)
        {
            _controller = controller;
        }
        public int Location
        {
            get => _location;
            set
            {
                _location = value;
                _controller.UpdateLocation(this);   
            }
        }

        public abstract int SafetyGap { get; set; }

        public void Move()
        {
            throw new System.NotImplementedException();
        }
    }
}