using KRPG.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRPG.Entities.Items.Equipment.Armor.Chestplate
{
    public class Chestplate : Equipment
    {
        public override EquipmentSlot Slot => EquipmentSlot.Chestplate;
        public Chestplate(int id, string name, StatsModifier statsModifier) : base(id, name, statsModifier)
        {
        }

    }
}
