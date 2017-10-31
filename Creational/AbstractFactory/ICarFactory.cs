namespace Creational.AbstractFactory
{
    public interface ICarFactory
    {
        ICar CreateCheapest();
        ICar CreateExpensive();
    }
}