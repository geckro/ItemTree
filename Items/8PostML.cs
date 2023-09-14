using Terraria.ID;
using Terraria.ModLoader;

namespace ItemTree.Items
{
    public class Luminite : ModItem
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
                .AddIngredient(ItemID.LunarOre)
                .AddIngredient(ItemID.LunarBar)
                .AddIngredient(ItemID.MoonlordArrow) // Luminite Arrow
                .AddIngredient(ItemID.MoonlordBullet) // Luminite Bullet
                .AddIngredient(ItemID.LunarFlareBook) // Lunar Flare
                .AddIngredient(ItemID.MoonlordTurretStaff) // Lunar Portal Staff
                .AddTile(TileID.LunarCraftingStation)
                .Register();
        }
    }
    public class SolarArtifact : ModItem
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
                .AddIngredient(ItemID.FragmentSolar)
                .AddIngredient(ItemID.SolarFlarePickaxe)
                .AddIngredient(ItemID.LunarHamaxeSolar)
                .AddIngredient(ItemID.SolarEruption)
                .AddIngredient(ItemID.SolarFlareDrill)
                .AddIngredient(ItemID.SolarFlareHelmet)
                .AddIngredient(ItemID.SolarFlareBreastplate)
                .AddIngredient(ItemID.SolarFlareLeggings)
                .AddIngredient(ItemID.WingsSolar)
                .AddIngredient(ItemID.DayBreak)
                .AddTile(TileID.LunarCraftingStation)
                .Register();
        }
    }
    public class Stardust : ModItem
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
                .AddIngredient(ItemID.FragmentStardust)
                .AddIngredient(ItemID.StardustPickaxe)
                .AddIngredient(ItemID.LunarHamaxeStardust)
                .AddIngredient(ItemID.StardustDragonStaff)
                .AddIngredient(ItemID.StardustDrill)
                .AddIngredient(ItemID.StardustHelmet)
                .AddIngredient(ItemID.StardustBreastplate)
                .AddIngredient(ItemID.StardustLeggings)
                .AddIngredient(ItemID.WingsStardust)
                .AddIngredient(ItemID.StardustCellStaff)
                .AddTile(TileID.LunarCraftingStation)
                .Register();
        }
    }
    public class Vortex : ModItem
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
                .AddIngredient(ItemID.FragmentVortex)
                .AddIngredient(ItemID.VortexPickaxe)
                .AddIngredient(ItemID.LunarHamaxeVortex)
                .AddIngredient(ItemID.VortexBeater)
                .AddIngredient(ItemID.VortexDrill)
                .AddIngredient(ItemID.VortexHelmet)
                .AddIngredient(ItemID.VortexBreastplate)
                .AddIngredient(ItemID.VortexLeggings)
                .AddIngredient(ItemID.WingsVortex)
                .AddIngredient(ItemID.Phantasm)
                .AddTile(TileID.LunarCraftingStation)
                .Register();
        }
    }
    public class Nebula : ModItem
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
                .AddIngredient(ItemID.FragmentNebula)
                .AddIngredient(ItemID.NebulaPickaxe)
                .AddIngredient(ItemID.LunarHamaxeNebula)
                .AddIngredient(ItemID.NebulaArcanum)
                .AddIngredient(ItemID.NebulaDrill)
                .AddIngredient(ItemID.NebulaHelmet)
                .AddIngredient(ItemID.NebulaBreastplate)
                .AddIngredient(ItemID.NebulaLeggings)
                .AddIngredient(ItemID.WingsNebula)
                .AddIngredient(ItemID.NebulaBlaze)
                .AddTile(TileID.LunarCraftingStation)
                .Register();
        }
    }
}