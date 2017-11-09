namespace Creational.Tests.Lazy.Proxy
{
    using System;

    public class Car
    {
        public int Id { get; set; }
        public virtual Radio Radio { get; set; }

        public override int GetHashCode() => $"{nameof(Car)}{Id}".GetHashCode();
    }



}