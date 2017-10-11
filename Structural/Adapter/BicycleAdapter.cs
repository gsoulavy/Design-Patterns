namespace Structural.Adapter
{
    public class BicycleAdapter : IVehicle
    {
        private readonly Bicycle _bicycle = new Bicycle();
        public string RunEngine()
        {
            return _bicycle.Ride();
        }
    }
}