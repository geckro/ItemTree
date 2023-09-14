using Terraria.ID;
using Terraria.ModLoader;

namespace ItemTree.Items
{
    public class Bomb : ModItem
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
                .AddIngredient(ItemID.Grenade)
                .AddIngredient(ItemID.Bomb)
                .AddIngredient(ItemID.BombStatue)
                .AddIngredient(ItemID.BombFish)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
    public class Dynamite : ModItem
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
                .AddIngredient(ItemID.Dynamite)
                .AddIngredient(ItemID.DynamiteFish)
                .AddIngredient(ItemID.Explosives)
                .AddIngredient(ItemID.TNTBarrel)
                .AddTile(TileID.TinkerersWorkbench)
                .Register();
        }
    }
}