using Terraria.ID;
using Terraria.ModLoader;

namespace ItemTree.ItemList.Biome
{
    public class Underworld : GlobalItem
    {
        // Pre-hardmode lava pre EOW/BOC
        public static int[] LavaArtifact = new int[]
        {
            ItemID.LavaBucket,
            ItemID.LavaCharm,
        };
        // Pre-hardmode hell pre EOW/BOC
        public static int[] HotStoneArtifact = new int[]
        {
            ItemID.HellbatBanner,
            ItemID.MagmaStone,
            ItemID.LavaSlimeBanner,
            ItemID.FireImpBanner,
            ItemID.ObsidianRose,
            ItemID.PlumbersHat
        };
        // Pre hardmode hell post EOW/BOC
        public static int[] HellstoneArtifact = new int[]
        {
            ItemID.HellstoneBar,
            ItemID.Cascade,
            ItemID.FieryGreatsword, // Volcano
            ItemID.MoltenPickaxe,
            ItemID.MoltenHamaxe,
            ItemID.PhoenixBlaster,
            ItemID.Sunfury,
            ItemID.Flamarang,
            ItemID.MoltenFury,
            ItemID.Flamelash
        };
        // Hardmode
        public static int[] FieryArtifact = new int[]
        {
            ItemID.HelFire,
            ItemID.LivingFireBlock,
            ItemID.FireWhip,
            ItemID.RedDevilBanner,
            ItemID.LavaBatBanner,
            ItemID.FlowerofFire
        };
    }
}