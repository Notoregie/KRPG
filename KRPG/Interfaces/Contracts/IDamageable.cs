using KRPG.Entities.Character;
using System;
using System.Collections.Generic;
using System.Text;

namespace KRPG.Interfaces.Contracts
{
    /// <summary>
    /// Defines something that can take damage
    /// </summary>
    public interface IDamageable
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="attacker"></param>
        void TakeDamage(Character attacker);
    }
}
