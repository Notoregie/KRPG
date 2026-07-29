using KRPG.Entities.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRPG.Components.Effects
{
    public abstract class ItemEffect : IItemEffect
    {
        public bool Apply(Character target)
        {
            // Defensive check. The UI should prevent applying invalid effects, but this avoids errors if Apply() is called directly.
            if (!CanApply(target))
                return false;

            return ApplyLogic(target);
        }

        public abstract bool CanApply(Character target);

        /// <summary>
        /// Executes the internal effect logic after validation.
        /// This method is only called by Apply() and should not be called directly.
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        protected abstract bool ApplyLogic(Character target);
    }
}
