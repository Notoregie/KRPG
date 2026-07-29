using KRPG.Components.Effects;
using KRPG.Entities.Characters;

namespace KRPG.Entities.Items.Consumeables.Potions
{
    public sealed class Potion : Consumeable
    {
        public override int StackLimit => 32;
        public List<IItemEffect> Effects { get; }
        public Potion(int id, string name, params IItemEffect[] effects) : base(id, name)
        {
            Effects = effects.ToList();
        }

        public override bool CanConsume(Character target)
        {
            foreach (IItemEffect effect in Effects)
            {
                if (!effect.CanApply(target))
                    return false;
            }
            return true;
        }

        public override void Use(Character target)
        {
            foreach (IItemEffect effect in Effects)
            {
                effect.Apply(target);
            }
        }
    }
}
