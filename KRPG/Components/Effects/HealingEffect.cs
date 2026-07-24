using KRPG.Entities.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRPG.Components.Effects
{
    public class HealingEffect : IItemEffect
    {
        private readonly int _amount;

        public HealingEffect(int amount)
        {
            _amount = amount;
        }

        public void Apply(Character target)
        {
            target.Heal(_amount);
        }
    }
}
