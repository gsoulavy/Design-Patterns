namespace Behavioral.ChainOfResponsibility
{
    public class GearHandler : IGearHandler
    {
        private readonly IGear _gear;
        private IGearHandler _nextHandler = TopHandler.Instance;

        public GearHandler(IGear gear)
        {
            _gear = gear;
        }

        public void SetNextHandler(IGearHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public (GearResponse response, string gearName) ApplySpeed(Rotation speed)
        {
            var response = _gear.Monitor(speed);
            return response == GearResponse.InLimit ? (response, _gear.Name) : _nextHandler.ApplySpeed(speed);
        }
    }
}