using System;
namespace ArcadiaTactics_Tools
{
    public class DiceRoller
    {
        private readonly Random random;
        private readonly int diceSides;

        public DiceRoller(int sides)
        {
            diceSides = sides;
            random = new Random();
        }

        public int Roll()
        {
            return random.Next(1, diceSides + 1);
        }
    }
}
