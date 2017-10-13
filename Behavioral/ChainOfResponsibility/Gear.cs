namespace Behavioral.ChainOfResponsibility
{
    public class Gear : IGear
    {
        private readonly double _upperLimit;
        public string Name { get; set; }


        public Gear(double upperLimit, string name)
        {
            Name = name;
            _upperLimit = upperLimit;
        }

        public GearResponse Monitor(Rotation rotation)
        {
            return rotation >= _upperLimit ? GearResponse.OverLimit : GearResponse.InLimit;
        }
    }
}