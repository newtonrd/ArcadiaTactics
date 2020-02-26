using System;
using ArcadiaTactices_Entities.Abstractions;

namespace ArcadiaTactices_Entities.Heroes
{
    public class Saskia : BaseCharacter
    {
        public Saskia(string name, int level = 1) : base(name, level, speed: 10, health: 7)
        {
        }
    }
}
