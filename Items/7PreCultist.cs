using Terraria.ID;
using Terraria.ModLoader;

namespace ItemTree.Items
{
    public class Fishron : ModItem
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
                .AddIngredient(ItemID.BubbleGun)
                .AddIngredient(ItemID.DukeFishronMask)
                .AddIngredient(ItemID.DukeFishronTrophy)
                .AddIngredient(ItemID.Flairon)
                .AddIngredient(ItemID.Fishron)
                .AddIngredient(ItemID.RazorbladeTyphoon)
                .AddIngredient(ItemID.Tsunami)
                .AddIngredient(ItemID.TempestStaff)
                .AddIngredient(ItemID.FishronWings)
                .AddTile(TileID.Autohammer)
                .Register();
        }
    }
}