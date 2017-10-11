namespace Structural.Adapter
{
    public class ManforceAdapter : IEngine
    {
        private readonly IManforce _manforce;

        public ManforceAdapter(IManforce manforce)
        {
            _manforce = manforce;
        }
        public string RunEngine()
        {
            return _manforce.Ride();
        }
    }
}