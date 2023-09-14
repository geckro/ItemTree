using Terraria.ID;
using Terraria.ModLoader;

namespace ItemTree.ItemList.Biome
{
    public class Hallow : GlobalItem
    {
        // Pre-Mech
        public static int[] HallowedArtifact = new int[]
        {
            ItemID.Pwnhammer,
            ItemID.Gungnir,
            ItemID.HallowedBar,
            ItemID.Excalibur,
            ItemID.HallowedMask,
            ItemID.HallowedHelmet,
            ItemID.HallowedHeadgear,
            ItemID.HallowedHood,
            ItemID.HallowedPlateMail,
            ItemID.HallowedGreaves,
            ItemID.HallowedRepeater,
            ItemID.SwordWhip, // Durendal
            ItemID.HallowJoustingLance
        };
        // Post-Mech
        public static int[] HolyArtifact = new int[]
        {
            ItemID.LightDisc,
            ItemID.Drax,
            ItemID.PickaxeAxe
        };
    }
}