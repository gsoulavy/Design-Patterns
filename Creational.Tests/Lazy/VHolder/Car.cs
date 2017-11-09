namespace Creational.Tests.Lazy.VHolder
{
    using System.Collections.Generic;

    public class Car
    {
        public int Id { get; set; }
        public ValueHolder<List<Wheel>> _wheels;
        public List<Wheel> Wheels =>  _wheels.Value;

        internal void Set(ValueHolder<List<Wheel>> valueHolder)
        {
            _wheels = valueHolder;
        }

    }

    public interface IValueLoader<out T>
    {
        T Load();
    }

    public class ValueHolder<T>
    {
        private T _value;
        private readonly IValueLoader<T> _loader;

        public ValueHolder(IValueLoader<T> loader)
        {
            _loader = loader;
        }

        public T Value
        {
            get
            {
                if (_value == null)
                {
                    _value = _loader.Load();
                }
                return _value;
            }
        }
    }

    public class WheelLoader : IValueLoader<List<Wheel>>
    {
        private readonly int _carId;

        public WheelLoader(int carId)
        {
            _carId = carId;
        }
        public List<Wheel> Load()
        {
            // get the data (lazy call here)
            return new List<Wheel>();
        }
    }

    public class Factory
    {
        public Car Create(int id)
        {
            var car = new Car{Id = id};
            car.Set(new ValueHolder<List<Wheel>>(new WheelLoader(id)));
            return car;
        }
    }

    public class Wheel
    {
        public int Id { get; set; }
    }
}