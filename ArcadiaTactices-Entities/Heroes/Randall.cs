using System;
using ArcadiaTactices_Entities.Abstractions;
using ArcadiaTactices_Entities.Heroes.Interfaces;

namespace ArcadiaTactices_Entities.Heroes
{
    public class Randall : BaseCharacter, IHero
    {
        public Randall(string name = "Randall Arkswin", int level = 1) : base(name, level, speed: 2, health: 10)
        {
        }
    }
}
