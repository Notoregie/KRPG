using System;
using System.Collections.Generic;
using System.Text;

namespace KRPG.Interfaces.Contracts
{
    /// <summary>
    /// Defines something that can attack
    /// </summary>
    public interface IAttackable
    {
        /// <summary>
        /// Attack an damageable object
        /// </summary>
        /// <param name="target">The object that is getting  attacked</param>
        void Attack(IDamageable target);
    }
}
