using Terraria.ID;
using Terraria.ModLoader;

namespace ItemTree.ItemList.Biome
{
    //
    // FOREST 
    //
    public class Forest : GlobalItem
    {
        // Slimes
        public static int[] GelArtifact = new int[]
        {
            ItemID.GreenSlimeBanner,
            ItemID.Gel,
            ItemID.SlimeBanner, // Blue Slime Banner
            ItemID.PinkyBanner,
            ItemID.SlimeStaff,
            ItemID.PurpleSlimeBanner,
            ItemID.PinkGel
        };
        // Zombie
        public static int[] ZombieArtifact = new int[]
        {
            ItemID.ZombieArm,
            ItemID.ZombieArmStatue,
            ItemID.ZombieBanner,
            ItemID.Shackle
        };
        // Demon Eye
        public static int[] EyeArtifact = new int[]
        {
            ItemID.SuspiciousLookingEye,
            ItemID.Lens,
            ItemID.BlackLens,
            ItemID.DemonEyeBanner
        };
    }
}
