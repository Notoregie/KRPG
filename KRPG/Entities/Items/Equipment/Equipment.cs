using KRPG.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace KRPG.Entities.Items.Equipment
{
    public abstract class Equipment : Item
    {
        public EquipmentSlot Slot { get; }
        public StatsModifier StatsModifier { get; }

        public Equipment(string name, EquipmentSlot slot, StatsModifier statsModifier) : base(name)
        {
            Slot = slot;
            StatsModifier = statsModifier;
        }
    }
}
