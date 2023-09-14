using Terraria.ID;
using Terraria.ModLoader;

namespace ItemTree.ItemList.Biome
{
    public class Corruption : GlobalItem
    {
        // Pre-hardmode corrupt pre EOW
        public static int[] ShadowArtifact = new int[]
        {
            ItemID.DemoniteOre,
            ItemID.DemoniteBar,
            ItemID.BallOHurt,
            ItemID.Vilethorn
        };
        // Pre-hardmode corrupt post EOW
        public static int[] CorruptArtifact = new int[]
        {
            ItemID.ShadowScale,
            ItemID.NightmarePickaxe,
            ItemID.TheBreaker,
            ItemID.ShadowHelmet,
            ItemID.ShadowScalemail,
            ItemID.ShadowGreaves
        };
    }
}