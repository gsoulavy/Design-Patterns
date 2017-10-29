namespace Structural.EventAggregator
{
    public class AvailabilityChanged
    {
        public string CarName { get; set; }
        public bool IsAvailable { get; set; }
    }
}