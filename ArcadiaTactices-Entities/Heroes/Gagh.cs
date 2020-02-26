using ArcadiaTactices_Entities.Abstractions;

namespace ArcadiaTactices_Entities.Heroes
{
    public class Gagh : BaseCharacter
    {
        public Gagh(string name, int level) : base(name, level, speed: 1, health: 15)
        {
        }
    }
}
