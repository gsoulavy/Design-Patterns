namespace Creational.FactoryMethod
{
    public class Porsche : ICar
    {
        public string Name { get; }

        public Porsche()
        {
            Name = "Porsche";
        }
    }
}