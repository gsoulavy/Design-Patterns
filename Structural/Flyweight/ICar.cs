namespace Structural.Flyweight
{
    public interface ICar
    {
        Color Color { get; set; }
        string Name { get; set; }
        Size Size { get; set; }
    }
}