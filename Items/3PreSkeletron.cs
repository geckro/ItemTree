using Terraria.ID;
using Terraria.ModLoader;

namespace ItemTree.Items
{
    public class Hellstone : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.rare = ItemRarityID.Blue;
        }
        public override void AddRecipes()
        {
            // TOOD: Some of this stuff is post skele fix this shit
            CreateRecipe()
                .AddIngredient(ItemID.HellstoneBar)
                .AddIngredient(ItemID.Cascade)
                .AddIngredient(ItemID.FieryGreatsword) // Volcano
                .AddIngredient(ItemID.MoltenPickaxe)
                .AddIngredient(ItemID.MoltenHamaxe)
                .AddIngredient(ItemID.PhoenixBlaster)
                .AddIngredient(ItemID.Sunfury)
                .AddIngredient(ItemID.Flamarang)
                .AddIngredient(ItemID.MoltenFury)
                .AddIngredient(ItemID.Flamelash)
                .AddTile(TileID.Furnaces)
                .Register();
        }
            
    }
}
