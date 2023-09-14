using Terraria.ID;
using Terraria.ModLoader;

namespace ItemTree.ItemList.Biome
{
    //
    // Dungeon Pre Hardmode
    //
    public class DungeonPreHardmode : GlobalItem
    {
        public static int[] BoneArtifact = new int[]
        {
            ItemID.Bone,
            ItemID.SkeletronHand,
            ItemID.AngryBonesBanner,
            ItemID.SkeletonMageBanner, // Dark Caster Banner
            ItemID.CursedSkullBanner,
            ItemID.BoneWelder
        };

        public static int[] WaveArtifact = new int[]
        {
            ItemID.Muramasa,
            ItemID.BlueMoon,
            ItemID.AquaScepter,
            ItemID.MagicMissile,
            ItemID.WaterBolt,
            ItemID.CobaltShield
        };
    }
    //
    // Dungeon Post Plantera
    //
    public class DungeonPostPlant : GlobalItem
    {
        public static int[] SkeletonArtifact = new int[]
        {
            ItemID.BoneFeather,
            ItemID.BlueArmoredBonesBanner,
            ItemID.HellArmoredBonesBanner,
            ItemID.RustyArmoredBonesBanner,
            ItemID.NecromancerBanner,
            ItemID.RaggedCasterBanner,
            ItemID.SkeletonSniperBanner,
            ItemID.BoneLeeBanner,
            ItemID.TacticalSkeletonBanner,
            ItemID.SkeletonCommandoBanner,
            ItemID.DiablolistBanner,
            ItemID.GiantCursedSkullBanner
        };
        public static int[] EctoplasmArtifact = new int[]
        {
            ItemID.SpectreStaff,
            ItemID.Ectoplasm,
            ItemID.SpectreMask,
            ItemID.SpectreHood,
            ItemID.SpectreRobe,
            ItemID.SpectreBoots,
            ItemID.DungeonSpiritBanner,
            ItemID.SpectreBar,
            ItemID.SpectreHamaxe,
            ItemID.SpectrePickaxe,
            ItemID.GhostWings // Spectre Wings
        };
    }
}