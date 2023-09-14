using Terraria.ID;
using Terraria.ModLoader;

namespace ItemTree.Items
{
    public class Shark : ModItem
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
                .AddIngredient(ItemID.Minishark)
                .AddIngredient(ItemID.SharkFin)
                .AddIngredient(ItemID.SharkStatue)
                .AddIngredient(ItemID.SharkBanner)
                .AddIngredient(ItemID.SharkBait)
                .AddIngredient(ItemID.ReaverShark)
                .AddIngredient(ItemID.SawtoothShark)
                .AddIngredient(ItemID.KiteShark)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
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
    public class Jellyfish : ModItem
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
                .AddIngredient(ItemID.BlueJellyfish)
                .AddIngredient(ItemID.PinkJellyfish)
                .AddIngredient(ItemID.KiteJellyfishBlue)
                .AddIngredient(ItemID.KiteJellyfishPink)
                .AddIngredient(ItemID.JellyfishBanner) // Blue Jellyfish banner
                .AddIngredient(ItemID.PinkJellyfishBanner)
                .AddIngredient(ItemID.JellyfishNecklace)
                .AddIngredient(ItemID.JellyfishStatue)
                .AddTile(TileID.Furnaces)
                .Register();
        }
    }
}