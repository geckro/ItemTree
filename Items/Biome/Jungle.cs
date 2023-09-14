using Terraria.ID;
using Terraria.ModLoader;

namespace ItemTree.ItemList.Biome
{
    //
    // SURFACE JUNGLE
    //
    public class JungleSurface : GlobalItem
    {
        // Pre-hardmode UG jungle
        public static int[] JungleGrassArtifact = new int[]
        {
            ItemID.JungleGrassSeeds,
            ItemID.SkyBlueFlower,
            ItemID.JungleRose,
            ItemID.NaturesGift,
            ItemID.JungleSlimeBanner,
            ItemID.SnatcherBanner,
            ItemID.JungleBatBanner,
            ItemID.ArchaeologistsHat,
            ItemID.DoctorBonesBanner
        };
    }
    //
    // UNDERGROUND JUNGLE
    //
    public class JungleUnderground : GlobalItem
    {
        // Pre-hardmode UG jungle
        public static int[] JungleArtifact = new int[]
        {
            ItemID.ThornChakram,
            ItemID.BladeofGrass,
            ItemID.IvyWhip,
            ItemID.JungleHat,
            ItemID.JungleShirt,
            ItemID.JunglePants,
            ItemID.AnkletoftheWind,
            ItemID.JungleSpores,
            ItemID.Vine,
            ItemID.StaffofRegrowth,
            ItemID.FeralClaws,
            ItemID.IvyWhip // Snapthorn
        };
        // Pre-hardmode UG jungle 2
        public static int[] MossyArtifact = new int[]
        {
            ItemID.FiberglassFishingPole,
            ItemID.Boomstick,
            ItemID.FlowerBoots,
            ItemID.Seaweed,
            ItemID.Bezoar,
            ItemID.LivingMahoganyWand,
            ItemID.LivingMahoganyLeafWand,
            ItemID.JungleTorch,
            ItemID.JungleYoyo, // Amazon
            ItemID.AcornAxe // Axe of Regrowth
        };
        // Hardmode UG jungle
        public static int[] JungleCluster = new int[]
        {
            ItemID.TortoiseBanner, // Giant Tortoise Banner
            ItemID.TurtleShell,
            ItemID.Uzi,
            ItemID.Yelets,
            ItemID.JungleCreeperBanner,
            ItemID.MothBanner,
            ItemID.AngryTrapperBanner
        };
    }
    //
    // HONEY
    //
    public class Honey : GlobalItem
    {
        // Pre-Queen bee
        public static int[] HoneyArtifact = new int[]
        {
            ItemID.CrispyHoneyBlock,
            ItemID.HoneyDispenser,
            ItemID.Stinger,
            ItemID.HornetBanner,
            ItemID.BeeMinecart
        };
        // Post Queen Bee Pre-hardmode 1
        public static int[] BeeArtifact = new int[]
        {
            ItemID.BeeGun,
            ItemID.BeeKeeper,
            ItemID.BeesKnees, // The Bee's Knees
            ItemID.BeeWax,
            ItemID.Beenade,
            ItemID.HoneyedGoggles,
            ItemID.HiveWand,
            ItemID.BeeHat,
            ItemID.BeeShirt,
            ItemID.BeePants,
            ItemID.HoneyComb,
            ItemID.BeeMask // Queen Bee Mask
        };
        // Post Queen Bee Pre-hardmode 2
        public static int[] BeeCluster = new int[]
        {
            ItemID.QueenBeeTrophy,
            ItemID.HiveFive,
            ItemID.HornetStaff,
            ItemID.BeeHeadgear,
            ItemID.BeeBreastplate,
            ItemID.BeeGreaves
        };
        // Hardmode
        public static int[] WaspArtifact = new int[]
        {
            ItemID.MossHornetBanner,
            ItemID.TatteredBeeWing,
            ItemID.BeeWings
        };
    }
}