using Terraria.ID;
using Terraria.ModLoader;

namespace ItemTree.ItemList.Biome
{
    public class SnowIce : GlobalItem
    {
        public class Ice : GlobalItem
        {
            // Pre-hardmode
            public static int[] IceArtifact = new int[]
            {
                ItemID.IceBlock,
                ItemID.IceTorch,
                ItemID.IceBlade,
                ItemID.IceBoomerang,
                ItemID.IceMirror,
                ItemID.IceBatBanner,
                ItemID.IceSkates,
                ItemID.IceSlimeBanner,
                ItemID.SpikedIceSlimeBanner,
                ItemID.FrozenChest,
                ItemID.IceCream
            };

            public static int[] FlinxArtifact = new int[]
            {
                ItemID.FlinxFur,
                ItemID.FlinxFurCoat,
                ItemID.FlinxStaff,
                ItemID.DeerThing
            };

            public static int[] VikingCluster = new int[]
            {
                ItemID.UndeadVikingBanner,
                ItemID.UndeadVikingStatue,
                ItemID.VikingHelmet
            };
            // Hardmode
            public static int[] FrozenArtifact = new int[]
            {
                ItemID.IceBow,
                ItemID.IceRod,
                ItemID.IceSickle,
                ItemID.IceFeather,
                ItemID.FrozenWings,
                ItemID.IceGolemBanner,
                ItemID.FrozenTurtleShell,
                ItemID.Frostbrand,
                ItemID.FlowerofFrost,
                ItemID.FrostStaff,
                ItemID.IceElementalBanner,
                ItemID.IcyMermanBanner,
                ItemID.IceTortoiseBanner
            };
            public static int[] VikingArtifact = new int[]
            {
                ItemID.ArmoredVikingBanner
            };
        }

        public class Snow : GlobalItem
        {
            // Pre-hardmode
            public static int[] SnowArtifact = new int[]
            {
                ItemID.SnowBlock,
                ItemID.Snowball,
                ItemID.SnowballCannon,
                ItemID.EskimoHood,
                ItemID.EskimoCoat,
                ItemID.EskimoPants,
                ItemID.SnowFlinxBanner,
                ItemID.SnowballLauncher,
                ItemID.FlurryBoots,
                ItemID.ZombieEskimoBanner
            };

            // Hardmode
            public static int[] FrozenArtifact = new int[]
            {
                ItemID.Milkshake,
                ItemID.ToySled,
                ItemID.FrozenKey
            };
            public static int[] WolfArtifact = new int[]
            {
                ItemID.WolfBanner,
                ItemID.WolfMountItem // Lilith's Necklace
            };
        }
    }
}