using KRPG.Components.Effects;
using KRPG.Entities.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRPG.Entities.Items.Consumeables.Potions
{
    public class Potion : Consumeable
    {
        public override int StackLimit => 32;
        public List<IItemEffect> Effects { get; }
        public Potion(int id, string name, List<IItemEffect> effects) : base(id, name)
        {
            Effects = effects;
        }

        public override void Use(Character.Character target)
        {
            foreach (IItemEffect effect in Effects)
            {
                effect.Apply(target);
            }
        }
    }
}
