using Terraria.ID;
using Terraria.ModLoader;

namespace ItemTree.Items
{
    public class CrimtanePreSkele : ModItem
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
                .AddIngredient(ItemID.CrimsonHelmet)
                .AddIngredient(ItemID.CrimsonScalemail)
                .AddIngredient(ItemID.CrimsonGreaves)
                .AddIngredient(ItemID.DeathbringerPickaxe)
                .AddIngredient(ItemID.FleshGrinder)
                .AddIngredient(ItemID.TheMeatball)
                .AddTile(TileID.Hellforge)
                .Register();
        }
    }
    public class DemonitePreSkele : ModItem
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
                .AddIngredient(ItemID.ShadowHelmet)
                .AddIngredient(ItemID.ShadowScalemail)
                .AddIngredient(ItemID.ShadowGreaves)
                .AddIngredient(ItemID.NightmarePickaxe)
                .AddIngredient(ItemID.TheBreaker)
                .AddIngredient(ItemID.ShadowScale)
                .AddTile(TileID.Hellforge)
                .Register();
        }
    }
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
                .AddIngredient(ItemID.FlowerofFire)
                .AddIngredient(ItemID.Flamelash)
                .AddTile(TileID.Furnaces)
                .Register();
        }
    }
    public class PreSkeletron : ModItem
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
                .AddIngredient(ItemID.EaterofWorldsMasterTrophy)
                .AddIngredient(ItemID.BrainofCthulhuMasterTrophy)
                .AddIngredient(ItemID.QueenBeeMasterTrophy)
                .AddIngredient(ItemID.DarkMageMasterTrophy)
                .AddTile(TileID.DemonAltar)
                .Register();
        }
    }
}
