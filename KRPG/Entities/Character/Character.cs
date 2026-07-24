using KRPG.Components;
using KRPG.Entities.Items.Equipment;
using KRPG.Interfaces.Contracts;
using KRPG.Systems.Combat;
using System;
using System.Collections.Generic;
using System.Text;

namespace KRPG.Entities.Character
{
    /// <summary>
    /// Represents a living entity capable of acting (such as fighting) in the game world.
    /// </summary>
    public abstract class Character : Entity
    {
        #region Properties & Fields
        public int Health { get; protected set; }
        public Stats BaseStats { get; protected set; }
        public virtual Stats ActualStats => BaseStats;
        #endregion
        public Character(int id, string name, Stats stats) : base(id, name) 
        {
            BaseStats = stats;
            Health = BaseStats.MaxHealth;
        }
        #region Methods

        


        #endregion
    }
}
