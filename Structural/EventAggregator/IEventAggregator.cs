namespace Structural.EventAggregator
{
    public interface IEventAggregator
    {
        void Subscribe(object subscriber);
        void UnSubscribe(object subscriber);
        bool IsSubscriber(object subscriber);
        void Publish<TEvent>(TEvent eventToPublish);
    }
}