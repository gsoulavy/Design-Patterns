namespace Structural.Flyweight
{
    public class Car : ICar
    {
        public Color Color { get; set; }
        public string Name { get; set; }
        public Size Size { get; set; }
    }

    public enum Color : int
    {
        Black,
        Blue,
        Gery,
        Green,
        Yellow,
        Red
    }

    public struct Size
    {
        public double Width { get; set; }
        public double Height { get; set; }
    }
}