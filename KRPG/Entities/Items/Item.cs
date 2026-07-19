using System;
using System.Collections.Generic;
using System.Text;

namespace KRPG.Entities.Items
{
    public abstract class Item : Entity
    {
        public abstract int StackLimit { get; }

        public Item(string name) : base(name)
        {
        }
    }
}
