using KRPG.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRPG.Entities.Items.Equipment.Armor.Leggings
{
    public class Leggings : Equipment
    {
        public override EquipmentSlot Slot => EquipmentSlot.Leggings;
        public Leggings(int id, string name, StatsModifier statsModifier) : base(id, name, statsModifier)
        {
        }

    }
}
