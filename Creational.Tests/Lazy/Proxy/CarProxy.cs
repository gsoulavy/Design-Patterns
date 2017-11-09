namespace Creational.Tests.Lazy.Proxy
{
    public class CarProxy : Car
    {
        public override Radio Radio
        {
            get => base.Radio ?? (base.Radio = new Radio());
            set => base.Radio = value;
        }

        public override bool Equals(object obj) =>
            obj is Car other && Id == other.Id;

        protected bool Equals(CarProxy other) => Equals((object)other);

        public override int GetHashCode() => base.GetHashCode();

        public static bool operator ==(CarProxy left, CarProxy right) => object.Equals(left, right);

        public static bool operator !=(CarProxy left, CarProxy right) => !object.Equals(left, right);
    }
}