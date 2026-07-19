using System;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection;
using System.Text;

namespace KRPG.Components
{
    public readonly struct Stats
    {
        public int MaxHealth { get; }
        public int Attack { get; }
        public int Defense { get; }
        public int Speed { get; }
        public int Luck { get; }
        public Stats(int maxHealth, int attack, int defense, int speed, int luck)
        {
            MaxHealth = maxHealth;
            Attack = attack;
            Defense = defense;
            Speed = speed;
            Luck = luck;
        }
        public void ShowStats()
        {
            PropertyInfo[] properties = this.GetType().GetProperties();
            Console.WriteLine(Decorator.Seperator);
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine($"{property.Name}: {property.GetValue(this)}");
            }
            Console.WriteLine(Decorator.Seperator);
        }

        public static Stats operator +(Stats a, Stats b)
        {
            return new Stats(
                a.MaxHealth + b.MaxHealth,
                a.Attack + b.Attack,
                a.Defense + b.Defense,
                a.Speed + b.Speed,
                a.Luck + b.Luck
                );
        }
        public static Stats operator +(Stats a, StatsModifier b)
        {
            return new Stats(
                a.MaxHealth + b.MaxHealth,
                a.Attack + b.Attack,
                a.Defense + b.Defense,
                a.Speed + b.Speed,
                a.Luck + b.Luck
                );
        }
    }
}
