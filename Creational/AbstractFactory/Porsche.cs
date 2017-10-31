namespace Creational.AbstractFactory
{
    public class Porsche : ICar
    {
        public string Name { get; }
        public BuildOption Option { get; }

        public Porsche(BuildOption option)
        {
            Name = "Porsche";
            Option = option;
        }
    }
}