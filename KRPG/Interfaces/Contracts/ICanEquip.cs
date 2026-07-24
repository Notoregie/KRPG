using KRPG.Entities.Items.Equipment;
using System;
using System.Collections.Generic;
using System.Text;

namespace KRPG.Interfaces.Contracts
{
    /// <summary>
    /// Defines an entity that can equip an Equipment
    /// </summary>
    public interface ICanEquip
    {
        /// <summary>
        /// Try to equip an Equipment in the suitable Equipmentslot
        /// </summary>
        /// <param name="equipment"></param>
        void Equip(Equipment equipment);
        /// <summary>
        /// Try to unequip an equipment from a Equipmentslot. Does nothing if there is nothing equiped in the slot 
        /// </summary>
        /// <param name="equipmentSlot"></param>
        void Unequip(EquipmentSlot equipmentSlot);
    }
}
