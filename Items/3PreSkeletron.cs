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
    public class ObsidianHouse : ModItem
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
                .AddIngredient(ItemID.ObsidianBathtub)
                .AddIngredient(ItemID.ObsidianBed)
                .AddIngredient(ItemID.ObsidianBookcase)
                .AddIngredient(ItemID.ObsidianBrick)
                .AddIngredient(ItemID.ObsidianBrickWall)
                .AddIngredient(ItemID.ObsidianCandelabra)
                .AddIngredient(ItemID.ObsidianCandle)
                .AddIngredient(ItemID.ObsidianChair)
                .AddIngredient(ItemID.ObsidianChandelier)
                .AddIngredient(ItemID.ObsidianChest)
                .AddIngredient(ItemID.ObsidianClock)
                .AddIngredient(ItemID.ObsidianDoor)
                .AddIngredient(ItemID.ObsidianDresser)
                .AddIngredient(ItemID.ObsidianLamp)
                .AddIngredient(ItemID.ObsidianLantern)
                .AddIngredient(ItemID.ObsidianPiano)
                .AddIngredient(ItemID.ObsidianPlatform)
                .AddIngredient(ItemID.ObsidianSink)
                .AddIngredient(ItemID.ObsidianSofa)
                .AddIngredient(ItemID.ObsidianTable)
                .AddIngredient(ItemID.ObsidianVase)
                .AddIngredient(ItemID.ObsidianWorkBench)
                .AddIngredient(ItemID.ToiletObsidian)
                .AddTile(TileID.Hellforge)
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
