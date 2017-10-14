namespace Creational.Tests.Builder
{
    using Creational.Builder;
    using Xunit;

    public class BuilderTests
    {
        [Fact(DisplayName = "Builder: Build cheap car")]
        public void BuildCheapCarTest()
        {
            var maker = new CarMaker(new CheapCarBuilder());
            maker.MakeCar();

            var car = maker.GetCar();

            Assert.Equal("Trabant", car.Brand);
            Assert.Equal(DoorType.Normal, car.Door);
            Assert.Equal(120d, car.MaxSpeed);
            Assert.Equal(EngineType.Benzin, car.Engine);
            Assert.Equal(3, car.NumberOfDoors);
            Assert.Equal(WheelType.Aluminium, car.Wheels);
        }

        [Fact(DisplayName = "Builder: Build sports car")]
        public void BuildSportsCarTest()
        {
            var maker = new CarMaker(new SportsCarBuilder());
            maker.MakeCar();

            var car = maker.GetCar();

            Assert.Equal("Lotus", car.Brand);
            Assert.Equal(DoorType.Scissor, car.Door);
            Assert.Equal(240d, car.MaxSpeed);
            Assert.Equal(EngineType.Electric, car.Engine);
            Assert.Equal(2, car.NumberOfDoors);
            Assert.Equal(WheelType.Alloy, car.Wheels);
        }
    }
}