using KRPG.Entities.Characters;
using KRPG.Systems.Combat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRPG.Entities.Items.Consumeables
{
    public abstract class Consumeable : Item
    {
        public Targeting Targeting { get; }
        public Consumeable(int id, string name, Targeting targeting) : base(id, name)
        {
            Targeting = targeting;
        }

        /// <summary>
        /// Determines if the Consumeable can be applied (to his target).
        /// </summary>
        /// <param name="target">Character that determines whether the effect can be applied.</param>
        public abstract bool CanConsume(Character? target = null);

        /// <summary>
        /// Tries to Use the Item on a target.
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public bool Use(Character? target = null)
        {
            // Defensive check. The UI should prevent using invalid items, but this avoids errors if Use() is called directly.
            if (!CanConsume(target))
                return false;

            return UseLogic(target);
        }

        /// <summary>
        /// Executes the internal Use logic after validation.
        /// This method is only called by Use() and should not be called directly.
        /// </summary>
        /// <param name="target"></param>
        protected abstract bool UseLogic(Character? target);
    }
}
