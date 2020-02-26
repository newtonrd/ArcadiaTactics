using ArcadiaTactices_Entities.Abstractions;
using ArcadiaTactices_Entities.Enemies.Interfaces;

namespace ArcadiaTactices_Entities.Enemies.Basic
{
    public class Goblin : BaseCharacter, IEnemy
    {
        public Goblin(string name, int level = 1) : base(name, level, speed: 1, health: 5)
        {
        }
    }
}
