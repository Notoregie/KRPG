using KRPG.Entities.Items.Equipment.Armor.Chestplate;
using KRPG.Entities.Items.Equipment.Armor.Helmet;
using KRPG.Entities.Items.Equipment.Armor.Leggings;
using KRPG.Entities.Items.Equipment.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRPG.Entities.Items.Equipment
{
    public class EquipmentSet
    {
        private readonly Dictionary<EquipmentSlot, Equipment> _allEquipments = new();
        public IReadOnlyCollection<Equipment> AllEquipments => _allEquipments.Values;
        public Weapon.Weapon? Weapon => GetEquipment<Weapon.Weapon>(EquipmentSlot.Weapon);
        public Helmet? Helmet => GetEquipment<Helmet>(EquipmentSlot.Helmet);
        public Chestplate? Chestplate => GetEquipment<Chestplate>(EquipmentSlot.Chestplate);
        public Leggings? Leggings => GetEquipment<Leggings>(EquipmentSlot.Leggings);

        public void Equip(Equipment equipment)
        {
            _allEquipments[equipment.Slot] = equipment;
        }

        public void Unequip(EquipmentSlot equipmentSlot)
        {
            _allEquipments.Remove(equipmentSlot);
        }

        private T? GetEquipment<T>(EquipmentSlot equipmentSlot) where T: Equipment
        {
            return _allEquipments.TryGetValue(equipmentSlot, out Equipment? equipment) ? equipment as T : null; 
        }
    }
}
