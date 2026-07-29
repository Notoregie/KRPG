using KRPG.Entities.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace KRPG.Interfaces.Contracts
{
    /// <summary>
    /// Defines an entity that can take damage
    /// </summary>
    public interface IDamageable
    {
        int Health { get; }
        bool IsDefeated { get; }
        /// <summary>
        /// Process of taking damage
        /// </summary>
        /// <param name="attacker"></param>
        void TakeDamage(Character attacker, IDamageCalculator damageCalculator);
    }
}
