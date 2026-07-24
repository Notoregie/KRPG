using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRPG.Interfaces.Contracts
{
    /// <summary>
    /// Represents an enity that can heal his Health
    /// </summary>
    public interface IHealable
    {
        /// <summary>
        /// Restores health to this entity. Usually invoked by Items or abilities. 
        /// </summary>
        /// <param name="amount">Amount of Health getting healed</param>
        void Heal(int amount);
    }
}
