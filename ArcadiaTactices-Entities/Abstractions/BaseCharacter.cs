using System;

namespace ArcadiaTactices_Entities.Abstractions
{
    public abstract class BaseCharacter
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Speed { get; set; }
        public int Health { get; set; }

        public BaseCharacter(string name, int level, int speed, int health)
        {
            Name = name;
            Level = level;
            Speed = speed;
            Health = health;
        }

        /// <summary>
        /// Determine if the character is dead or alive
        /// </summary>
        /// <returns></returns>
        public bool IsDead()
        {
            return Health == 0;
        }

        public override string ToString()
        {
            return $"{Name} at {Level} with {Speed}";
        }
    }
}
