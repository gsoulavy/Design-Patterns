namespace Structural.Decorator
{
    public abstract class Car
    {
        protected string _name;
        protected double _cost;

        public virtual string Name
        {
            get { return _name; }
        }

        public virtual double Cost
        {
            get { return _cost; }
        }
    }
}