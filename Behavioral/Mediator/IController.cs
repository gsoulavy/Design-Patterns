namespace Behavioral.Mediator
{
    public interface IController
    {
        void Register(ICar car);
        void UnRegister(ICar car);
        void UpdateLocation(ICar car);
    }
}