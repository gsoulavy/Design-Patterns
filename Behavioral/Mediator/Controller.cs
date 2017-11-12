namespace Behavioral.Mediator
{
    using System.Collections.Generic;

    public class Controller : IController
    {
        private readonly List<ICar> _cars;

        public Controller()
        {
            _cars = new List<ICar>();
        }

        public void Register(ICar car)
        {
            _cars.Add(car);
        }

        public void UnRegister(ICar car)
        {
            _cars.Remove(car);
        }

        public void UpdateLocation(ICar carWithNewLocation)
        {
            foreach (var car in _cars)
            {
                carWithNewLocation.Location = (car.Location - carWithNewLocation.Location) < car.SafetyGap
                    ? car.SafetyGap
                    : carWithNewLocation.Location;
            }
        }
    }
}