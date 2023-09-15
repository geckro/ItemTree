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
    public class LihzahrdHouse : ModItem
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
                .AddIngredient(ItemID.LihzahrdChest)
                .AddIngredient(ItemID.LihzahrdChair)
                .AddIngredient(ItemID.LihzahrdTable)
                .AddIngredient(ItemID.LihzahrdWorkBench)
                .AddIngredient(ItemID.LihzahrdPlatform)
                .AddIngredient(ItemID.LihzahrdPiano)
                .AddIngredient(ItemID.LihzahrdBed)
                .AddIngredient(ItemID.LihzahrdDresser)
                .AddIngredient(ItemID.LihzahrdDoor)
                .AddIngredient(ItemID.LihzahrdBookcase)
                .AddIngredient(ItemID.LihzahrdLantern)
                .AddIngredient(ItemID.LihzahrdChandelier)
                .AddIngredient(ItemID.LihzahrdBathtub)
                .AddIngredient(ItemID.LihzahrdLamp)
                .AddIngredient(ItemID.LihzahrdCandelabra)
                .AddIngredient(ItemID.LihzahrdSofa)
                .AddIngredient(ItemID.LihzahrdClock)
                .AddIngredient(ItemID.LihzahrdCandle)
                .AddIngredient(ItemID.LihzahrdBrick)
                .AddIngredient(ItemID.LihzahrdBrickWall)
                .AddIngredient(ItemID.ToiletLihzhard)
                .AddIngredient(ItemID.LihzahrdSink)
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
    public class SpookyHouse : ModItem
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
                .AddIngredient(ItemID.SpookyWoodWall)
                .AddIngredient(ItemID.SpookyChest)
                .AddIngredient(ItemID.SpookyChair)
                .AddIngredient(ItemID.SpookyTable)
                .AddIngredient(ItemID.SpookyWorkBench)
                .AddIngredient(ItemID.SpookyPlatform)
                .AddIngredient(ItemID.SpookyPiano)
                .AddIngredient(ItemID.SpookyBed)
                .AddIngredient(ItemID.SpookyDresser)
                .AddIngredient(ItemID.SpookyDoor)
                .AddIngredient(ItemID.SpookyBookcase)
                .AddIngredient(ItemID.SpookyLantern)
                .AddIngredient(ItemID.SpookyChandelier)
                .AddIngredient(ItemID.SpookyBathtub)
                .AddIngredient(ItemID.SpookyLamp)
                .AddIngredient(ItemID.SpookyCandelabra)
                .AddIngredient(ItemID.SpookySofa)
                .AddIngredient(ItemID.SpookyCandle)
                .AddIngredient(ItemID.SpookyClock)
                .AddIngredient(ItemID.ToiletSpooky)
                .AddIngredient(ItemID.SpookySink)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
    public class SteampunkHouse : ModItem
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
                .AddIngredient(ItemID.Cog)
                .AddIngredient(ItemID.CogWall)
                .AddIngredient(ItemID.SteampunkChest)
                .AddIngredient(ItemID.SteampunkChair)
                .AddIngredient(ItemID.SteampunkTable)
                .AddIngredient(ItemID.SteampunkWorkBench)
                .AddIngredient(ItemID.SteampunkPlatform)
                .AddIngredient(ItemID.SteampunkPiano)
                .AddIngredient(ItemID.SteampunkBed)
                .AddIngredient(ItemID.SteampunkDresser)
                .AddIngredient(ItemID.SteampunkDoor)
                .AddIngredient(ItemID.SteampunkBookcase)
                .AddIngredient(ItemID.SteampunkLantern)
                .AddIngredient(ItemID.SteampunkChandelier)
                .AddIngredient(ItemID.SteampunkBathtub)
                .AddIngredient(ItemID.SteampunkLamp)
                .AddIngredient(ItemID.SteampunkCandle)
                .AddIngredient(ItemID.SteampunkCandelabra)
                .AddIngredient(ItemID.SteampunkSofa)
                .AddIngredient(ItemID.SteampunkClock)
                .AddIngredient(ItemID.ToiletSteampunk)
                .AddIngredient(ItemID.SteampunkSink)
                .AddTile(TileID.SteampunkBoiler)
                .Register();
        }
    }
}
