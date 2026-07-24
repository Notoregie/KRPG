using KRPG.Components.Effects;
using KRPG.Entities.Items.Consumeables.Potions;
using static KRPG.Global.GameConstants;

namespace KRPG.Entities.Items
{
    public static class ItemDefinitions
    {
        public static readonly Potion SmallHealingPotion =
            new Potion(2000, "Small Healing Potion",
                new() { new HealingEffect(SmallHealingPotionValue) });


    }
}
