using KRPG.Entities.Items;
using KRPG.Entities.Items.Consumeables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRPG.Interfaces.Contracts
{
    /// <summary>
    /// Represents an entity capable of using Connsumeable Items
    /// </summary>
    public interface ICanUseItems
    {
        /// <summary>
        /// Uses an Consumeable Item.
        /// </summary>
        /// <param name="item">Item that is consumed</param>
        void Use(Consumeable item);
    }
}
