using KRPG.Components;
using KRPG.Entities.Items;
using KRPG.Entities.Items.Consumeables;
using KRPG.Entities.Items.Equipment;
using KRPG.Entities.Items.Equipment.Weapon;
using KRPG.Interfaces;
using KRPG.Interfaces.Contracts;
using KRPG.Systems.Combat;
using System;
using System.Collections.Generic;
using System.Text;

namespace KRPG.Entities.Character.Player
{
    /// <summary>
    /// Represents a playable Character in the game world
    /// </summary>
    public class Player : Character, IAttackable, IDamageable, ICanEquip, IHealable, ICanUseItems
    {   
        public bool IsDefeated => Health <= 0;
        public EquipmentSet EquipmentSet { get; } = new EquipmentSet();
        public override Stats ActualStats
        {
            get
            {
                Stats actualStats = BaseStats;
                foreach (Equipment equipment in EquipmentSet.AllEquipments)
                {
                    actualStats += equipment.StatsModifier;
                }
                return actualStats;
            }
        }
        public Player(int id, string name, Stats stats) : base(id, name, stats)
        {

        }

        public void Use(Consumeable consumeable)
        {
           consumeable.Use(this);
        }

        /// <summary>
        /// A methode to test sertant things like fighting
        /// </summary>
        /// <returns></returns>
        public static Player CreateTestPlayer()
        {
            Stats stats = new Stats(30, 15, 10, 10, 3);
            return new Player(0000, "TestPlayer", stats);
        }

        public void Attack(IDamageable target)
        {
            target.TakeDamage(this, EquipmentSet.Weapon.DamageCalculator);
        }

        public void TakeDamage(Character attacker, IDamageCalculator damageCalculator)
        {
            int calculatedDamage = damageCalculator.Calculate(attacker.ActualStats, ActualStats);
            // If damage is negativ it will still cause a minimum damage of 0.
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

        public void Heal(int amount)
        {
            this.Health += amount;
        }
    }
}
