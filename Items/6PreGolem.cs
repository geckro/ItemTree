using Terraria.ID;
using Terraria.ModLoader;

// After the mechanical bosses, before-after Plantera
namespace ItemTree.Items
{
    public class Empress : ModItem
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
                .AddIngredient(ItemID.PiercingStarlight)
                .AddIngredient(ItemID.RainbowWhip) // Kaleidoscope
                .AddIngredient(ItemID.FairyQueenRangedItem) // Eventide
                .AddIngredient(ItemID.FairyQueenMagicItem) // Nightglow
                .AddIngredient(ItemID.FairyQueenTrophy) // Empress of Light Trophy
                .AddIngredient(ItemID.FairyQueenMask) // Empress of Light Mask
                .AddIngredient(ItemID.RainbowCursor)
                .AddIngredient(ItemID.RainbowWings) // Empress Wings
                .AddIngredient(ItemID.HallowBossDye) // Prismatic Dye
                .AddIngredient(ItemID.SparkleGuitar) // Stellar Tune
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }
    }
    public class Frost : ModItem
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
                .AddIngredient(ItemID.StaffoftheFrostHydra)
                .AddIngredient(ItemID.IceChest)
                .AddIngredient(ItemID.FlockoBanner)
                .AddIngredient(ItemID.IceQueenTrophy)
                .AddIngredient(ItemID.BlizzardStaff)
                .AddIngredient(ItemID.NorthPole)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }
    }
    public class Fungus : ModItem
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
                .AddIngredient(ItemID.MushroomSpear)
                .AddIngredient(ItemID.Hammush)
                .AddIngredient(ItemID.Autohammer)
                .AddIngredient(ItemID.MushroomCap)
                .AddIngredient(ItemID.StrangeGlowingMushroom)
                .AddIngredient(ItemID.MySon)
                .AddIngredient(ItemID.ShroomiteBar)
                .AddIngredient(ItemID.ShroomiteDiggingClaw)
                .AddIngredient(ItemID.ShroomitePlating)
                .AddIngredient(ItemID.ShroomitePlatingWall)
                .AddIngredient(ItemID.ShroomiteHeadgear)
                .AddIngredient(ItemID.ShroomiteHelmet)
                .AddIngredient(ItemID.ShroomiteMask)
                .AddIngredient(ItemID.ShroomiteBreastplate)
                .AddIngredient(ItemID.ShroomiteLeggings)
                .AddIngredient(ItemID.FungoFishBanner)
                .AddIngredient(ItemID.FungiBulbBanner)
                .AddIngredient(ItemID.AnomuraFungusBanner)
                .AddIngredient(ItemID.MushiLadybugBanner)
                .AddIngredient(ItemID.SporeZombieBanner)
                .AddTile(TileID.Autohammer)
                .Register();
        }
    }
    public class Hallowed : ModItem
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
                .AddIngredient(ItemID.Excalibur)
                .AddIngredient(ItemID.Drax)
                .AddIngredient(ItemID.HallowJoustingLance)
                .AddIngredient(ItemID.SwordWhip) // Durendal
                .AddIngredient(ItemID.HallowedHelmet)
                .AddIngredient(ItemID.HallowedHood)
                .AddIngredient(ItemID.HallowedMask)
                .AddIngredient(ItemID.HallowedHeadgear)
                .AddIngredient(ItemID.HallowedPlateMail)
                .AddIngredient(ItemID.HallowedGreaves)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }
    }
    public class HallowedAncient : ModItem
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
                .AddIngredient(ItemID.Gungnir)
                .AddIngredient(ItemID.LightDisc)
                .AddIngredient(ItemID.PickaxeAxe)
                .AddIngredient(ItemID.HallowedRepeater)
                .AddIngredient(ItemID.AncientHallowedHelmet)
                .AddIngredient(ItemID.AncientHallowedHood)
                .AddIngredient(ItemID.AncientHallowedMask)
                .AddIngredient(ItemID.AncientHallowedHeadgear)
                .AddIngredient(ItemID.AncientHallowedPlateMail)
                .AddIngredient(ItemID.AncientHallowedGreaves)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }
    }
    public class Lihzahrd : ModItem
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
                .AddIngredient(ItemID.LihzahrdBanner)
                .AddIngredient(ItemID.FlyingSnakeBanner)
                .AddIngredient(ItemID.LihzahrdPowerCell)
                .AddIngredient(ItemID.LihzahrdFurnace)
                .AddIngredient(ItemID.SolarTablet)
                .AddIngredient(ItemID.LunarTabletFragment) // Solar Tablet Fragment
                .AddTile(TileID.LihzahrdFurnace)
                .Register();
        }
    }
    public class Plantera : ModItem
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
                .AddIngredient(ItemID.Seedler)
                .AddIngredient(ItemID.PlanteraMask)
                .AddIngredient(ItemID.PlanteraTrophy)
                .AddIngredient(ItemID.TheAxe)
                .AddIngredient(ItemID.Seedling)
                .AddIngredient(ItemID.WaspGun)
                .AddIngredient(ItemID.LeafBlower)
                .AddIngredient(ItemID.FlowerPow)
                .AddIngredient(ItemID.GrenadeLauncher)
                .AddIngredient(ItemID.NettleBurst)
                .AddIngredient(ItemID.VenusMagnum)
                .AddIngredient(ItemID.VenusMagnum)
                .AddIngredient(ItemID.PygmyStaff)
                .AddIngredient(ItemID.ThornHook)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }
    }
    public class PreGolem : ModItem
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
                .AddIngredient(ItemID.DestroyerMasterTrophy)
                .AddIngredient(ItemID.TwinsMasterTrophy)
                .AddIngredient(ItemID.SkeletronPrimeMasterTrophy)
                .AddIngredient(ItemID.PlanteraMasterTrophy)
                .AddIngredient(ItemID.FairyQueenMasterTrophy)
                .AddIngredient(ItemID.IceQueenMasterTrophy)
                .AddIngredient(ItemID.SantankMasterTrophy)
                .AddIngredient(ItemID.EverscreamMasterTrophy)
                .AddIngredient(ItemID.MourningWoodMasterTrophy)
                .AddIngredient(ItemID.PumpkingMasterTrophy)
                .AddIngredient(ItemID.OgreMasterTrophy)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }
    }
    public class Spectre : ModItem
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
                .AddIngredient(ItemID.Ectoplasm)
                .AddIngredient(ItemID.Kraken)
                .AddIngredient(ItemID.SpectreStaff)
                .AddIngredient(ItemID.SpectreBar)
                .AddIngredient(ItemID.SpectreHood)
                .AddIngredient(ItemID.SpectreMask)
                .AddIngredient(ItemID.SpectreRobe)
                .AddIngredient(ItemID.SpectreBoots)
                .AddIngredient(ItemID.SpectrePickaxe)
                .AddIngredient(ItemID.SpectreHamaxe)
                .AddIngredient(ItemID.SpectrePaintbrush)
                .AddIngredient(ItemID.SpectrePaintScraper)
                .AddIngredient(ItemID.SpectrePaintRoller)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }
    }
    public class Skeleton : ModItem
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
                .AddIngredient(ItemID.BoneWings)
                .AddIngredient(ItemID.BoneFeather)
                .AddIngredient(ItemID.BlueArmoredBonesBanner)
                .AddIngredient(ItemID.RustyArmoredBonesBanner)
                .AddIngredient(ItemID.HellArmoredBonesBanner)
                .AddIngredient(ItemID.GiantCursedSkullBanner)
                .AddIngredient(ItemID.RaggedCasterBanner)
                .AddIngredient(ItemID.DiablolistBanner) // Diabolist Banner
                .AddIngredient(ItemID.SkeletonCommandoBanner)
                .AddIngredient(ItemID.SkeletonSniperBanner)
                .AddIngredient(ItemID.NecromancerBanner)
                .AddIngredient(ItemID.TacticalSkeletonBanner)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }
    }
}
