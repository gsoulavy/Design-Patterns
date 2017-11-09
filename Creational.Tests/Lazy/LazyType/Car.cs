namespace Creational.Tests.Lazy.LazyType
{
    using System;

    public class Car
    {
        private readonly Lazy<Radio> _lazyRadio;

        public Car()
        {
            // Thread save initialiser
            _lazyRadio = new Lazy<Radio>(() => new Radio(), true);
        }

        public Radio Radio => _lazyRadio.Value;
    }
}