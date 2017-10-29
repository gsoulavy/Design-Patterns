namespace Structural.EventAggregator
{
    public class Car
    {
        private readonly IEventAggregator _eventAggregator;
        private int _passengers;
        private bool _isAvailable;

        public string Name { get; set; }

        public int MaxSeats { get; set; }
        private int FreeSeats => MaxSeats - Passengers;

        private bool IsAvailable(int passengers)
        {
            var originalState = _isAvailable;
            _isAvailable = passengers <= MaxSeats;
            if (_isAvailable != originalState) AvailabilityChanged();
            return _isAvailable;
        }

        public int Passengers
        {
            get => _passengers;
            set
            {
                if (!IsAvailable(value)) return;
                _passengers = value;
                FreeSeatChanged();
            }
        }

        private void FreeSeatChanged()
        {
            _eventAggregator.Publish(new FreeSeatsChanged {CarName = Name, FreeSeats = FreeSeats });
        }

        private void AvailabilityChanged()
        {
            _eventAggregator.Publish(new AvailabilityChanged {CarName = Name, IsAvailable = _isAvailable});
        }

        public Car(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
        }
    }
}