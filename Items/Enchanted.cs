using Terraria.ID;
using Terraria.ModLoader;

namespace ItemTree.Items
{
    public class Enchanted : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.rare = ItemRarityID.Blue;
            Item.value = 9000; // 1g + 5g + 3g
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.EnchantedBoomerang)
                .AddIngredient(ItemID.Arkhalis)
                .AddIngredient(ItemID.EnchantedSword)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}