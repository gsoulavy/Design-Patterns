namespace Structural.EventAggregator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;

    public class EventAggregator : IEventAggregator
    {
        private readonly Dictionary<Type, List<WeakReference>> _eventSubscribers =
            new Dictionary<Type, List<WeakReference>>();

        private readonly object _lock = new object();
        private Type _subscriberType;

        public EventAggregator(Type subscriberType)
        {
            _subscriberType = subscriberType;
        }

        public void Subscribe(object subscriber)
        {
            lock (_lock)
            {
                var subscriberType = subscriber.GetType();
                var interfaceGenericTypeDefinitions =
                    subscriberType.GetInterfaces().Where(i =>
                        i.IsGenericType && i.GetGenericTypeDefinition() == typeof(ISubscriber<>));

                foreach (var interfaceGenericDefinition in interfaceGenericTypeDefinitions)
                {
                    var weakReference = new WeakReference(subscriber);
                    var subscribers = GetSubscriber(interfaceGenericDefinition);
                    subscribers.Add(weakReference);
                }
            }
        }

        public void Publish<TEvent>(TEvent eventToPublish)
        {
            var subscriberType = typeof(ISubscriber<>).MakeGenericType(typeof(TEvent));
            var subscribers = GetSubscriber(subscriberType);
            var subscribersToRemove = new List<WeakReference>();

            foreach (var weakSubscriber in subscribers)
                if (weakSubscriber.IsAlive)
                {
                    var subscriber = (ISubscriber<TEvent>) weakSubscriber.Target;
                    var syncContext = SynchronizationContext.Current ?? new SynchronizationContext();
                    syncContext.Post(s => subscriber.OnEvent(eventToPublish), null);
                }
                else
                {
                    subscribersToRemove.Add(weakSubscriber);
                }

            if (!subscribersToRemove.Any()) return;
            lock (_lock)
            {
                foreach (var remove in subscribersToRemove)
                    subscribers.Remove(remove);
            }
        }

        private List<WeakReference> GetSubscriber(Type subscriberType)
        {
            List<WeakReference> subscribers;
            lock (_lock)
            {
                if (_eventSubscribers.TryGetValue(subscriberType, out subscribers)) return subscribers;
                subscribers = new List<WeakReference>();
                _eventSubscribers.Add(subscriberType, subscribers);
            }
            return subscribers;
        }
    }
}