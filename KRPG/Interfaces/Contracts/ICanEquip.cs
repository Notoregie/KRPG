using KRPG.Entities.Items.Equipment;
using System;
using System.Collections.Generic;
using System.Text;

namespace KRPG.Interfaces.Contracts
{
    /// <summary>
    /// Defines an object that can Equip an Equipment
    /// </summary>
    public interface ICanEquip
    {
        void Equip(Equipment equipment);
        void Unequip(EquipmentSlot equipmentSlot);
    }
}
