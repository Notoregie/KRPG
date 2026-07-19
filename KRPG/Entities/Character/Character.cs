using KRPG.Components;
using KRPG.Entities.Items.Equipment;
using KRPG.Interfaces.Contracts;
using KRPG.Systems.Combat;
using System;
using System.Collections.Generic;
using System.Text;

namespace KRPG.Entities.Character
{
    public abstract class Character : Entity, IAttackable, IDamageable, ICanEquip
    {
        #region Properties & Fields
        public override string Type => nameof(Character);
        public int Health { get; private set; }
        public Stats BaseStats { get; private set; }

        private readonly Dictionary<EquipmentSlot, Equipment> _equipment = new();
        public Stats ActualStats
        {
            get
            {
                Stats actualStats = BaseStats;
                foreach (Equipment equipment in _equipment.Values)
                {
                    actualStats += equipment.StatsModifier;
                }
                return actualStats;
            }
        }
        #endregion
        public Character(string name, Stats stats) : base(name) 
        {
            BaseStats = stats;
            Health = BaseStats.MaxHealth;
        }
        #region Methods

        public void Attack(IDamageable target)
        {
            target.TakeDamage(this);
        }

        public void TakeDamage(Character attacker)
        {
            int calculatedDamage = DamageCalculator.CalculateDamage(attacker.ActualStats, ActualStats);
            Health = Math.Max(Health - calculatedDamage, 0);
        }

        public void Equip(Equipment equipment)
        {
            _equipment[equipment.Slot] = equipment; 
        }

        public void Unequip(EquipmentSlot equipmentSlot)
        {
            _equipment.Remove(equipmentSlot);
        }
        #endregion
    }
}
