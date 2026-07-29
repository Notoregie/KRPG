using KRPG.Entities.Characters;
using KRPG.Interfaces.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRPG.Components.Effects
{
    public sealed class HealingEffect : ItemEffect
    {
        private readonly int _amount;

        public HealingEffect(int amount)
        {
            _amount = amount;
        }

        public override bool CanApply(Character target) => target is IHealable;

        protected override bool ApplyLogic(Character target)
        {
            IHealable healable = (IHealable)target;
            healable.Heal(_amount);
            return true;
        }
    }
}
