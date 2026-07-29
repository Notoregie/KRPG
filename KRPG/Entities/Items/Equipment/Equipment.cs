using KRPG.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace KRPG.Entities.Items.Equipment
{
    public abstract class Equipment : Item
    {
        public override int StackLimit => 3;
        public abstract EquipmentSlot Slot { get; }
        public StatsModifier StatsModifier { get; }

        public Equipment(int id, string name, StatsModifier statsModifier) : base(id, name)
        {
            StatsModifier = statsModifier;
        }
    }
}
