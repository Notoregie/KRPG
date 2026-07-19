using KRPG.Entities.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace KRPG.Components
{
    /// <summary>
    /// Inventory is the Inventory from the Player (not the class)
    /// </summary>
    public static class Inventory
    {
        private readonly static Dictionary<string, ItemStack> _inventoryItems = new Dictionary<string, ItemStack>();

        public static bool CollectItem(Item item)
        {
            // Item already exist in Inventory
            if (_inventoryItems.TryGetValue(item.Name, out ItemStack? itemStack) && itemStack != null)
            {
                return itemStack.TryIncrease();
            }

            // Item does not exist
            else
            {
                _inventoryItems[item.Name] = new ItemStack(item);
                return true;
            }
        }

        public static bool RemoveItem(string itemName)
        {
            if (_inventoryItems.TryGetValue(itemName, out ItemStack? itemStack) && itemStack != null)
            {
                if (!itemStack.TryDecrease())
                    return false;

                if (itemStack.IsEmpty)
                    _inventoryItems.Remove(itemName);

                return true;
            }
            return false;
        }
    }

    /// <summary>
    /// Defines the ItemStack inside the Inventory
    /// </summary>
    public class ItemStack
    {
        public bool IsEmpty => Amount <= 0;
        public bool IsFull => Amount >= Item.StackLimit;
        public Item Item { get; }
        public int Amount { get; private set; }

        public ItemStack(Item item)
        {
            Item = item;
            Amount = 1;
        }

        public bool TryIncrease()
        {
            if (IsFull)
                return false;

            Amount++;
            return true;
        }
        public bool TryDecrease()
        {
            if (IsEmpty)
                return false;

            Amount--;
            return true;
        }
    }
}
