using Terraria.ID;
using Terraria.ModLoader;

namespace ItemTree.Items
{
    public class Skeletron : ModItem
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
                .AddIngredient(ItemID.SkeletronMask)
                .AddIngredient(ItemID.SkeletronHand)
                .AddIngredient(ItemID.BookofSkulls)
                .AddIngredient(ItemID.SkeletronTrophy)
                .AddIngredient(ItemID.Bone)
                .AddIngredient(ItemID.BoneWand)
                .AddIngredient(ItemID.NecroHelmet)
                .AddIngredient(ItemID.NecroBreastplate)
                .AddIngredient(ItemID.NecroGreaves)
                .AddIngredient(ItemID.AncientNecroHelmet)
                .AddIngredient(ItemID.AngryBonesBanner)
                .AddIngredient(ItemID.CursedSkullBanner)
                .AddIngredient(ItemID.SkeletonMageBanner) // Dark Caster Banner
                .AddIngredient(ItemID.BoneWelder)
                .AddTile(TileID.BoneWelder)
                .Register();
        }
    }
    public class DungeonWater : ModItem
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
                .AddIngredient(ItemID.Muramasa)
                .AddIngredient(ItemID.BlueMoon)
                .AddIngredient(ItemID.AquaScepter)
                .AddIngredient(ItemID.MagicMissile)
                .AddIngredient(ItemID.Nazar)
                .AddIngredient(ItemID.DungeonSlimeBanner)
                .AddIngredient(ItemID.WaterCandle)
                .AddTile(TileID.BoneWelder)
                .Register();
        }
    }
    public class PreHardmodeWOF : ModItem
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
                .AddIngredient(ItemID.SkeletronMasterTrophy)
                .AddIngredient(ItemID.DeerclopsMasterTrophy)
                .AddTile(TileID.DemonAltar)
                .Register();
        }
    }
}
