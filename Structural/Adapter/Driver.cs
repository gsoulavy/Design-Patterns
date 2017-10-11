namespace Structural.Adapter
{
    public class Driver
    {
        private readonly IVehicle _vehicle;

        public Driver(IVehicle vehicle)
        {
            _vehicle = vehicle;
        }
        public string Move()
        {
            return _vehicle.RunEngine();
        }
    }
}