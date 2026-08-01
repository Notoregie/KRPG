using KRPG.Components.Effects;
using KRPG.Entities.Characters;
using KRPG.Systems.Combat;

namespace KRPG.Entities.Items.Consumeables.Potions;

public sealed class Potion : Consumeable
{
    public override int StackLimit => 32;
    public List<IItemEffect> Effects { get; }
    public Potion(int id, string name, Targeting targeting, params IItemEffect[] effects) : base(id, name, targeting)
    {
        Effects = effects.ToList();
    }

    public override bool CanConsume(Character target) => Effects.All(effect => effect.CanApply(target));

    protected override bool UseLogic(Character target)
    {
        foreach (IItemEffect effect in Effects)
        {
            effect.Apply(target);
        }

        return true;
    }
}
