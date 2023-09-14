using Terraria.ID;
using Terraria.ModLoader;

namespace ItemTree.Items
{
    public class Goblin : ModItem
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
                .AddIngredient(ItemID.Harpoon)
                .AddIngredient(ItemID.SpikyBall)
                .AddIngredient(ItemID.GoblinScoutBanner)
                .AddIngredient(ItemID.TatteredCloth)
                .AddIngredient(ItemID.GoblinPeonBanner)
                .AddIngredient(ItemID.GoblinSorcererBanner)
                .AddIngredient(ItemID.GoblinThiefBanner)
                .AddIngredient(ItemID.GoblinWarriorBanner)
                .AddIngredient(ItemID.GoblinArcherBanner)
                .AddIngredient(ItemID.GoblinBattleStandard)
                .AddIngredient(ItemID.GoblinStatue)
                .AddTile(TileID.TinkerersWorkbench)
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