using KRPG.Components;
using KRPG.Interfaces;
using KRPG.Interfaces.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace KRPG.Systems.Combat
{
    public class PhysicalDamageCalculator : IDamageCalculator
    {
        public static PhysicalDamageCalculator Instance { get; } = new PhysicalDamageCalculator();
        public int Calculate(Stats attacker, Stats defender)
        {
            return Math.Max(0, attacker.Attack - defender.Defense);
        }
    }
}
