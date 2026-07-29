using KRPG.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRPG.Entities.Items.Equipment.Armor.Helmet
{
    public class Helmet : Equipment
    {
        public override EquipmentSlot Slot => EquipmentSlot.Helmet;
        public Helmet(int id, string name, StatsModifier statsModifier) : base(id, name, statsModifier)
        {
        }
    }
}
