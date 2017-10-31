namespace Creational.AbstractFactory
{
    public interface ICar
    {
        string Name { get; }
        BuildOption Option { get; }
    }
}