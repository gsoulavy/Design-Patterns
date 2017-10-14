namespace Behavioral.Command
{
    /// <summary>
    ///     CarEngine is the receiver
    /// </summary>
    public class CarEngine : ICarComponent
    {
        private double _rpm;

        public double Rpm
        {
            get => _rpm;
            private set
            {
                if (value >= 0)
                    _rpm = value;
            }
        }

        public bool IsEngineOn { get; private set; }

        public void On()
        {
            IsEngineOn = true;
        }

        public void Off()
        {
            IsEngineOn = false;
            Rpm = 0;
        }

        public void Up()
        {
            if (IsEngineOn)
                Rpm++;
        }

        public void Down()
        {
            if (IsEngineOn)
                Rpm--;
        }
    }
}