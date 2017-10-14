namespace Behavioral.ChainOfResponsibility
{
    public class Rotation
    {
        public Rotation(double rotation)
        {
            Rpm = rotation;
        }
        public double Rpm { get; }

        public static implicit operator Rotation(double rotation)
        {
            return new Rotation(rotation);
        }

        public static bool operator <(Rotation r, double d)
        {
            return r.Rpm < d;
        }

        public static bool operator <(double d, Rotation r)
        {
            return d < r.Rpm;
        }

        public static bool operator >(Rotation r, double d)
        {
            return r.Rpm > d;
        }

        public static bool operator >(double d, Rotation r)
        {
            return d > r.Rpm;
        }

        public static bool operator >=(Rotation r, double d)
        {
            return r.Rpm >= d;
        }

        public static bool operator >=(double d, Rotation r)
        {
            return d >= r.Rpm;
        }

        public static bool operator <=(Rotation r, double d)
        {
            return r.Rpm <= d;
        }

        public static bool operator <=(double d, Rotation r)
        {
            return d <= r.Rpm;
        }
    }
}