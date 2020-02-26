using System;
using ArcadiaTactices_Entities.Abstractions;

namespace ArcadiaTactices_Entities.Heroes
{
    public class Aramis : BaseCharacter
    {
        public Aramis(string name, int level = 1) : base(name, level, speed: 3, health: 5)
        {
        }
    }
}
