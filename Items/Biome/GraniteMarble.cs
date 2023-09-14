using Terraria.ID;
using Terraria.ModLoader;

namespace ItemTree.ItemList.Biome
{
    //
    // MARBLE 
    //
    public class Marble : GlobalItem
    {
        // Pre-hardmode Marble
        public static int[] MarbleArtifact = new int[]
        {
            ItemID.GreekSkeletonBanner, // Hoplite Banner
            ItemID.Javelin,
            ItemID.Gladius,
            ItemID.GladiatorHelmet,
            ItemID.GladiatorBreastplate,
            ItemID.GladiatorLeggings,
            ItemID.Marble, // Marble Block
            ItemID.MarbleWall,
            ItemID.MarbleBlock, // Smooth Marble Block
            ItemID.Pizza
        };
        // Pre-hardmode Marble 2
        public static int[] MarbleCluster = new int[]
        {
            ItemID.MarblePlatform,
            ItemID.MarbleWorkBench,
            ItemID.MarbleChandelier,
            ItemID.MarbleBathtub,
            ItemID.MarbleBed,
            ItemID.MarbleBookcase,
            ItemID.MarbleClock,
            ItemID.MarbleColumn,
            ItemID.MarbleDresser,
            ItemID.MarblePiano,
            ItemID.MarbleSofa,
            ItemID.ToiletMarble,
            ItemID.MarbleCandelabra,
            ItemID.MarbleCandle,
            ItemID.MarbleChair,
            ItemID.MarbleChest,
            ItemID.MarbleDoor,
            ItemID.MarbleLamp,
            ItemID.MarbleLantern,
            ItemID.MarbleSink,
            ItemID.MarbleTable,
            ItemID.MarbleBlockWall // Smooth Marble Wall
        };
        // Hardmode Marble
        public static int[] GreekArtifact  = new int[]
        {   
            ItemID.MedusaBanner,
            ItemID.MedusaHead,
            ItemID.PocketMirror
        };
    }
    //
    // GRANITE 
    //
    public class Granite : GlobalItem
    {
        // Pre-hardmode Granite biome 
        public static int[] GraniteArtifact = new int[]
        {
            ItemID.GraniteGolemBanner, 
            ItemID.GraniteFlyerBanner, // Granite Elemental Banner
            ItemID.Granite, // Granite Block
            ItemID.NightVisionHelmet,
            ItemID.Geode,
            ItemID.GraniteWall,
            ItemID.GraniteBlock, // Smooth Granite Block
            ItemID.GranitePlatform,
            ItemID.GraniteWorkBench,
            ItemID.GraniteChandelier,
            ItemID.GraniteBathtub,
            ItemID.GraniteGolemStatue
        };
        // Pre-hardmode Granite biome 2
        public static int[] GranitoidArtifact = new int[]
        {
            ItemID.GraniteBed,
            ItemID.GraniteBookcase,
            ItemID.GraniteClock,
            ItemID.GraniteColumn,
            ItemID.GraniteDresser,
            ItemID.GranitePiano,
            ItemID.GraniteSofa,
            ItemID.ToiletGranite,
            ItemID.GraniteCandelabra,
            ItemID.GraniteCandle,
            ItemID.GraniteChair,
            ItemID.GraniteSink,
            ItemID.GraniteLantern,
            ItemID.GraniteDoor,
            ItemID.GraniteChest,
            ItemID.GraniteTable,
            ItemID.GraniteBlockWall // Smooth Granite Wall
        };
    }
    //
    // GRANITE-MARBLE 
    //
    public class GraniteMarble : GlobalItem
    {
        // Pre-hardmode Granite biome 
        public static int[] GraniteMarbleCluster = new int[]
        {
        };
    }
}
