using KRPG.Entities.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRPG.Components.Effects
{
    public interface IItemEffect
    {
        /// <summary>
        /// Determines if the IItemEffect can be applied to his target.
        /// </summary>
        /// <param name="target">Character that determines whether the effect can be applied.</param>
        /// <returns></returns>
        bool CanApply(Character target);
        /// <summary>
        /// Tries to apply the IItemEffect on a target.
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        bool Apply(Character target);
    }
}
