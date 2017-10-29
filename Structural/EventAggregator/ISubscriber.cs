namespace Structural.EventAggregator
{
    public interface ISubscriber<in T>
    {
        void OnEvent(T e);
    }
}