using Terraria.ID;
using Terraria.ModLoader;

namespace ItemTree.Items
{
    public class Pirate : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.rare = ItemRarityID.Blue;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.PirateStaff)
                .AddIngredient(ItemID.Cutlass)
                .AddIngredient(ItemID.PirateCaptainBanner)
                .AddIngredient(ItemID.PirateHat)
                .AddIngredient(ItemID.PirateShirt)
                .AddIngredient(ItemID.PiratePants)
                .AddIngredient(ItemID.PirateCorsairBanner)
                .AddIngredient(ItemID.PirateCrossbowerBanner)
                .AddIngredient(ItemID.PirateDeadeyeBanner)
                .AddIngredient(ItemID.PirateBanner) // Pirate deckhand
                .AddIngredient(ItemID.FlyingDutchmanTrophy)
                .AddIngredient(ItemID.PirateMinecart) // The Dutchman
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
    public class Shadowflame : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.rare = ItemRarityID.Blue;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.GoblinSummonerBanner)
                .AddIngredient(ItemID.ShadowFlameHexDoll)
                .AddIngredient(ItemID.ShadowFlameBow)
                .AddIngredient(ItemID.ShadowFlameKnife)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }
    }
}