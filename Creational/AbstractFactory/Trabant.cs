namespace Creational.AbstractFactory
{
    public class Trabant : ICar
    {
        public string Name { get; }
        public BuildOption Option { get; }

        public Trabant(BuildOption option)
        {
            Name = "Trabant";
            Option = option;
        }
    }
}