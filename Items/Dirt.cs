using Terraria.ID;
using Terraria.ModLoader;

namespace ItemTree.Items
{
    public class Dirt : ModItem
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
                .AddIngredient(ItemID.DirtBlock)
                .AddIngredient(ItemID.Dirtfish)
                .AddIngredient(ItemID.DirtiestBlock)
                .AddIngredient(ItemID.DirtWall)
                .AddIngredient(ItemID.DirtBomb)
                .AddIngredient(ItemID.CaveWall1Echo) // Cave Dirt
                .AddIngredient(ItemID.CaveWall2Echo) // Rough Dirt
                .AddIngredient(ItemID.Cave6Echo) // Rocky Dirt
                .AddIngredient(ItemID.Dirt1Echo) // Layered Dirt
                .AddIngredient(ItemID.Dirt2Echo) // Crumbling Dirt
                .AddIngredient(ItemID.Dirt3Echo) // Cracked Dirt
                .AddIngredient(ItemID.Dirt4Echo) // Wavy Dirt
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
}