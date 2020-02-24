namespace ArcadiaTactices_Entities.Abstractions
{
    public abstract class BaseCharacter
    {
        private string Name { get; set; }
        private int Level { get; set; }

        public BaseCharacter(string name, int level)
        {
            Name = name;
            Level = level;
        }

        public override string ToString()
        {
            return $"{Name} at {Level}";
        }
    }
}
