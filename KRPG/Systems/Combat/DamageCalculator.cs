using KRPG.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace KRPG.Systems.Combat
{
    public static class DamageCalculator
    {
        private const double zufallsZahl = 0.15;
        public static int CalculateDamage(Stats attacker, Stats defender, double zufallsFaktor = zufallsZahl)
        {
            double randomFactor = new Random().NextDouble() * (zufallsFaktor * 2);
            int calculatedDamage = Math.Max(0, (int)Math.Round(attacker.Attack * randomFactor));
            return Math.Max(0, calculatedDamage - defender.Defense);
        }
    }
}
