using System;
using System.Collections.Generic;
using System.Text;

namespace KRPG.Components
{
    public readonly struct StatsModifier
    {
        public int MaxHealth { get; }
        public int Attack { get; }
        public int Defense { get; }
        public int Speed { get; }
        public int Luck { get; }

        public StatsModifier(int maxHealth, int attack, int defense, int speed, int luck)
        {
            MaxHealth = maxHealth;
            Attack = attack;
            Defense = defense;
            Speed = speed;
            Luck = luck;
        }
    }
}
