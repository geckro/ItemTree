using Terraria.ID;
using Terraria.ModLoader;

namespace ItemTree.Items
{
    public class PreCorruptCrimBossRelics : ModItem
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
                .AddIngredient(ItemID.KingSlimeMasterTrophy)
                .AddIngredient(ItemID.EyeofCthulhuMasterTrophy)
                .AddTile(TileID.DemonAltar)
                .Register();
        }
    }
    public class Eye2 : ModItem
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
                .AddIngredient(ItemID.EyeOfCthulhuPetItem)
                .AddIngredient(ItemID.EoCShield)
                .AddIngredient(ItemID.EyeofCthulhuTrophy)
                .AddIngredient(ItemID.EyeMask)
                .AddIngredient(ItemID.Binoculars)
                .AddTile(TileID.DemonAltar)
                .Register();
        }
    }
    public class Grass : ModItem
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
                .AddIngredient(ItemID.GrassSeeds)
                .AddIngredient(ItemID.Daybloom)
                .AddIngredient(ItemID.DaybloomSeeds)
                .AddIngredient(ItemID.PurificationPowder)
                .AddIngredient(ItemID.Sunflower)
                .AddIngredient(ItemID.StaffofRegrowth)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
    public class Ninja : ModItem
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
                .AddIngredient(ItemID.Shuriken)
                .AddIngredient(ItemID.NinjaHood)
                .AddIngredient(ItemID.NinjaShirt)
                .AddIngredient(ItemID.NinjaPants)
                .AddTile(TileID.Solidifier)
                .Register();
        }
    }
    public class Slimy : ModItem
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
                .AddIngredient(ItemID.SlimeHook)
                .AddIngredient(ItemID.KingSlimeMask)
                .AddIngredient(ItemID.KingSlimeTrophy)
                .AddIngredient(ItemID.SlimeGun)
                .AddIngredient(ItemID.Solidifier)
                .AddIngredient(ItemID.SlimySaddle)
                .AddIngredient(ItemID.SlimeBlock)
                .AddIngredient(ItemID.RoyalGel)
                .AddIngredient(ItemID.KingSlimePetItem)
                .AddIngredient(ItemID.SlimeBlockWall)
                .AddTile(TileID.Solidifier)
                .Register();
        }
    }
}
