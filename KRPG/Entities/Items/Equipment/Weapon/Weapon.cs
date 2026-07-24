using KRPG.Components;
using KRPG.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRPG.Entities.Items.Equipment.Weapon
{
    public abstract class Weapon : Equipment
    {
        public override EquipmentSlot Slot => EquipmentSlot.Weapon;
        public IDamageCalculator DamageCalculator { get; }
        public Weapon(int id, string name, StatsModifier statsModifier, IDamageCalculator damageCalculator) : base(id, name, statsModifier)
        {
            DamageCalculator = damageCalculator;
        }
    }
}
