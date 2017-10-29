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
        private readonly Type _subscriberType;

        public EventAggregator(Type subscriberType)
        {
            _subscriberType = subscriberType;
        }

        public EventAggregator() : this(typeof(ISubscriber<>))
        {

        }

        public void Subscribe(object subscriber)
        {
            lock (_lock)
            {
                foreach (var interfaceGenericDefinition in GetInterfaceGenericTypeDefinitions(subscriber.GetType()))
                {
                    var weakReference = new WeakReference(subscriber);
                    AddSubscribers(interfaceGenericDefinition, weakReference);
                }
            }
        }

        public void UnSubscribe(object subscriber)
        {
            lock (_lock)
            {
                foreach (var interfaceGenericDefinition in GetInterfaceGenericTypeDefinitions(subscriber.GetType()))
                {
                    RemoveSubscribers(interfaceGenericDefinition, new WeakReference(subscriber));
                }
            }
        }

        public bool IsSubscriber(object subscriber)
        {
            lock (_lock)
            {
                return GetInterfaceGenericTypeDefinitions(subscriber.GetType())
                    .Any(id => _eventSubscribers.ContainsKey(id));
            }
        }

        private IEnumerable<Type> GetInterfaceGenericTypeDefinitions(Type subscriberType)
        {
            return subscriberType.GetInterfaces().Where(i =>
                i.IsGenericType && i.GetGenericTypeDefinition() == _subscriberType);
        }

        public void Publish<TEvent>(TEvent eventToPublish)
        {
            var subscriberType = _subscriberType.MakeGenericType(typeof(TEvent));
            var subscribers = GetSubscribers(subscriberType);
            var subscribersToRemove = new List<WeakReference>();

            foreach (var weakSubscriber in subscribers)
                if (weakSubscriber.IsAlive)
                {
                    var subscriber = (ISubscriber<TEvent>)weakSubscriber.Target;
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

        private List<WeakReference> GetSubscribers(Type subscriberType)
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

        private void RemoveSubscribers(Type subscriberType, WeakReference subscriber)
        {
            lock (_lock)
            {
                if (_eventSubscribers.TryGetValue(subscriberType, out var subscribers))
                {
                    subscribers.Remove(subscriber);
                }
            }
        }

        private void AddSubscribers(Type subscriberType, WeakReference subscriber)
        {
            lock (_lock)
            {
                if (_eventSubscribers.TryGetValue(subscriberType, out var subscribers))
                {
                    subscribers.Add(subscriber);
                }
                subscribers = new List<WeakReference> { subscriber };
                _eventSubscribers.Add(subscriberType, subscribers);
            }
        }
    }
}