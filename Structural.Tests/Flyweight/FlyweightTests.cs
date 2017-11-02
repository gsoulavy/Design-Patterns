namespace Structural.Tests.Flyweight
{
    using System;
    using Structural.Flyweight;
    using Xunit;

    public class FlyweightTests
    {
        [Fact(DisplayName = "Flyweight: create many object")]
        public void CreateManyObjects()
        {
            var car1 = FlyweightFactory.Create(Color.Black, GetRandomSize());
            var car2 = FlyweightFactory.Create(Color.Gery, GetRandomSize());
            var car3 = FlyweightFactory.Create(Color.Green, GetRandomSize());
            var car4 = FlyweightFactory.Create(Color.Black, GetRandomSize());

            Assert.False(object.ReferenceEquals(car1, car2));
            Assert.False(object.ReferenceEquals(car1, car3));
            Assert.True(object.ReferenceEquals(car1, car4));
            Assert.False(object.ReferenceEquals(car2, car3));
            Assert.False(object.ReferenceEquals(car2, car4));
            Assert.False(object.ReferenceEquals(car3, car4));
        }

        private static Size GetRandomSize()
        {
            var random = new Random();
            var size = new Size {Height = random.NextDouble() * 10, Width = random.NextDouble() * 10};
            return size;
        }
    }
}