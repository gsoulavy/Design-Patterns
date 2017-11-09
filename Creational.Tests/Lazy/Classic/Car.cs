namespace Creational.Tests.Lazy.Classic
{
    public class Car
    {
        private Radio _radio;

        public Radio Radio => _radio = _radio ?? new Radio();
    }
}