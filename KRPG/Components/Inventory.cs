using KRPG.Entities.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace KRPG.Components
{
    /// <summary>
    /// Inventory is the Inventory from the Player (not the class)
    /// </summary>
    public class Inventory
    {
        private readonly Dictionary<int, ItemStack> _inventoryItems = new Dictionary<int, ItemStack>();

        public Inventory()
        {

        }
        public bool CollectItem(Item item)
        {
            // Item already exist in Inventory
            if (_inventoryItems.TryGetValue(item.Id, out ItemStack? itemStack) && itemStack != null)
            {
                return itemStack.TryIncrease();
            }

            // Item does not exist
            else
            {
                _inventoryItems[item.Id] = new ItemStack(item);
                return true;
            }
        }

        public bool RemoveItem(Item item)
        {
            if (_inventoryItems.TryGetValue(item.Id, out ItemStack? itemStack) && itemStack != null)
            {
                if (!itemStack.TryDecrease())
                    return false;

                if (itemStack.IsEmpty)
                    _inventoryItems.Remove(item.Id);

                return true;
            }
            return false;
        }

        public bool ContainItem(Item item)
        {
            return _inventoryItems.TryGetValue(item.Id, out _);
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
