using KRPG.Components.Effects;
using KRPG.Entities.Items.Consumeables.Potions;
using KRPG.Systems.Combat;
using static KRPG.Global.GameConstants;

namespace KRPG.Entities.Items
{
    public static class ItemDefinitions
    {
        #region Potions

        public static readonly Potion SmallHealingPotion =
            new Potion(2000, "Small Healing Potion", new Targeting(TargetGroup.Party, TargetSelection.Single),
                new HealingEffect(SmallHealingPotionValue));

        public static readonly Potion MediumHealingPotion =
            new Potion(2001, "Medium Healing Potion", new Targeting(TargetGroup.Party, TargetSelection.Single),
                new HealingEffect(MediumHealingPotionValue));

        public static readonly Potion LargeHealingPotion =
            new Potion(2002, "Large Healing Potion", new Targeting(TargetGroup.Party, TargetSelection.Single),
                new HealingEffect(SupremeHealingPotionValue));

        public static readonly Potion SupremeHealingPotion =
            new Potion(2003, "Supreme Healing Potion", new Targeting(TargetGroup.Party, TargetSelection.Single),
                new HealingEffect(SupremeHealingPotionValue));

        public static readonly Potion OmegaHealingPotion =
            new Potion(2004, "Omega Healing Potion", new Targeting(TargetGroup.Party, TargetSelection.Single),
                new HealingEffect(OmegaHealingPotionValue));

        #endregion

    }
}
