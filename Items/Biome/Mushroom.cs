using Terraria.ID;
using Terraria.ModLoader;

namespace ItemTree.ItemList.Biome
{
    public class Mushroom : GlobalItem
    {
        // Pre-hardmode
        public static int[] GlowingMushroomArtifact = new int[]
        {
            ItemID.SporeBatBanner,
            ItemID.Shroomerang,
            ItemID.SporeSkeletonBanner,
            ItemID.GlowingMushroom,
            ItemID.MushroomGrassSeeds,
            ItemID.ShroomMinecart,
            ItemID.MushroomHat,
            ItemID.MushroomVest,
            ItemID.MushroomPants
        };
        // Hardmode
        public static int[] GlowingFungusArtifact = new int[]
        {
            ItemID.MushroomSpear,
            ItemID.Hammush,
            ItemID.MushroomCap,
            ItemID.StrangeGlowingMushroom,
            ItemID.MySon
        };
    }
}