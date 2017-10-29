namespace Structural.EventAggregator
{
    public class Coordinator : ISubscriber<FreeSeatsChanged>, ISubscriber<AvailabilityChanged>
    {
        public int FreeSeatChangeEventCount { get; private set; }
        public int AvailibilityChangeEventCount { get; private set; }

        public Coordinator(IEventAggregator eventAggregator)
        {
            eventAggregator.Subscribe(this);
        }
        public void OnEvent(FreeSeatsChanged e)
        {
            FreeSeatChangeEventCount++;
        }

        public void OnEvent(AvailabilityChanged e)
        {
            AvailibilityChangeEventCount++;
        }
    }
}